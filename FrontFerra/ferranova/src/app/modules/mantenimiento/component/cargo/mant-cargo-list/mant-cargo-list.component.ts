import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { CargoResponse } from '@models/cargo-response.model';
import { CargoService } from '@modules/mantenimiento/service/cargo.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AccionMantConst } from '@constants/general.constants';
import { FormBuilder, FormGroup } from '@angular/forms';
import { GenericFilterRequest } from '@modules/auth/models/generic-filter-request.model';
import { GenericFilterResponse } from '@models/generic-filter-response.model';



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
  myFormFilter  : FormGroup;
  totalItems    : number = 0;
  itemsPerPage  : number = 3;
  request       : GenericFilterRequest = new GenericFilterRequest();
 




  constructor(
    private _route       : Router,
    private fb           : FormBuilder,
    private modalService : BsModalService,
    private _cargoService: CargoService,
  ){
    this.myFormFilter = this.fb.group({
      codigo: ["", []],
      nombre: ["", []],
      idEstado: ["", []],
    });

  }



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
// filtrar() {
//   let valueForm = this.myFormFilter.getRawValue();
//   this.request.filtros.push({ name: "codigo", value: valueForm.codigo });
//   this.request.filtros.push({ name: "nombre", value: valueForm.nombre });
//   this.request.filtros.push({ name: "idEstado", value: valueForm.idEstado });
//   this._cargoService.genericFilter(this.request).subscribe({
//     next: (data: GenericFilterResponse<CargoResponse>) => {
//       console.log(data);
//       this.cargos = data.lista;
//       this.totalItems = data.totalRegistros;
//     },
//     error: () => {
//       console.log("error");
//     },
//     complete: () => {
//       console.log("completo");
//     },
//   });
// }

// changePage(event: PageChangedEvent) {
//   this.request.numeroPagina = event.page;
//   this.filtrar();
// }


// changeItemsPerPage() {
//   this.request.cantidad = this.itemsPerPage;
//   this.filtrar();
// }



}
