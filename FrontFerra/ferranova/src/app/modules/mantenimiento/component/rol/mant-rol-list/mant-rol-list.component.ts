import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { RolResponse } from '@models/rol-response.model';
import { RolService } from '@modules/mantenimiento/service/rol.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AccionMantConst } from '@constants/general.constants';



@Component({
  selector: 'app-mant-rol-list',
  templateUrl: './mant-rol-list.component.html',
  styleUrls: ['./mant-rol-list.component.scss']
})
export class MantRolListComponent implements OnInit {
  modalRef?     : BsModalRef;
  rol           : RolResponse[] = [];
  rolSelected   : RolResponse = new RolResponse();
  titleModal    : string = "";
  accionModal   : number = 0;



  constructor(
    private _route       : Router,
    private modalService : BsModalService,
    private _rolService  : RolService,
  ){}



  /**
   * FIXME: Es el primer evento que ejecuta el componente
   */
  ngOnInit(): void {
    this.listarRol()
}
listarRol(){
  this._rolService.getAll().subscribe({
    next:(data: RolResponse[])=>{
      this.rol = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearRol(template: TemplateRef<any>)
{
  this.rolSelected = new RolResponse();
  this.titleModal = "NUEVO ROL";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarRol(template: TemplateRef<any>, rol:RolResponse)
{
  this.rolSelected = rol;
  this.titleModal = "EDITAR ROL";
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
    this.listarRol();
  }

}
eliminarRegistro(id : number){
  let result = confirm("¿Está seguro de eliminar el registro?");
  if(result)
    {
      this._rolService.delete(id).subscribe({
        next:(data:number)=>{
          alert("Registro eliminado de forma correcta");
        },
        error:()=>{},
        complete:()=>{
          this.listarRol();
        }
      });
    }

}

}
