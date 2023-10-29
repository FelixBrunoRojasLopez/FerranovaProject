import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { CargoResponse } from '@models/cargo-response.model';
import { CargoService } from '@modules/mantenimiento/service/cargo.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AccionMantConst } from '@constants/general.constants';



@Component({
  selector: 'app-mant-cargo-list',
  templateUrl: './mant-cargo-list.component.html',
  styleUrls: ['./mant-cargo-list.component.scss']
})
export class MantCargoListComponent implements OnInit {
  modalRef?     : BsModalRef;
  cargos        : CargoResponse[] = [];
  cargoSelected : CargoResponse = new CargoResponse();
  titleModal    : string = "";
  accionModal   : number = 0;



  constructor(
    private _route       : Router,
    private modalService : BsModalService,
    private _cargoService: CargoService,
  ){}



  /**
   * FIXME: Es el primer evento que ejecuta el componente
   */
  ngOnInit(): void {
    this.listarCargos()
}
listarCargos(){
  this._cargoService.getAll().subscribe({
    next:(data: CargoResponse[])=>{
      this.cargos = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearCargo(template: TemplateRef<any>)
{
  this.cargoSelected = new CargoResponse();
  this.titleModal = "NUEVO CARGO";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarCargo(template: TemplateRef<any>, cargo:CargoResponse)
{
  this.cargoSelected = cargo;
  this.titleModal = "EDITAR CARGO";
  this.accionModal = AccionMantConst.editar;
  this.openModal(template);
}

openModal(template: TemplateRef<any>){
  this.modalRef = this.modalService.show(template)
}
getCloseModalEmmit(res:boolean){
  this.modalRef?.hide();
  if(res)
  {
    this.listarCargos();
  }

}
eliminarRegistro(id : number){
  let result = confirm("¿Está seguro de eliminar el registro?");
  if(result)
    {
      this._cargoService.delete(id).subscribe({
        next:(data:number)=>{
          alert("Registro eliminado de forma correcta");
        },
        error:()=>{},
        complete:()=>{
          this.listarCargos();
        }
      });
    }

}

}
