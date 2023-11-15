import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { AccionMantConst } from '@constants/general.constants';
import { VClienteResponse } from '@models/vcliente-response.model';
import { ClienteService } from '@modules/mantenimiento/service/cliente.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './cliente-list.component.html',
  styleUrls: ['./cliente-list.component.scss']
})
export class ClienteListComponent implements OnInit {
  modalRef?         : BsModalRef;
  cliente           : VClienteResponse[] = [];
  clienteSelected   : VClienteResponse = new VClienteResponse();
  titleModal        : string = "";
  accionModal       : number = 0;
  constructor(
    private _route           : Router,
    private modalService     : BsModalService,
    private _clienteService  : ClienteService,
  ){}


  ngOnInit(): void {
    this.listarCliente()
}
listarCliente(){
  this._clienteService.getAll().subscribe({
    next:(data: VClienteResponse[])=>{
      this.cliente = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearCliente(template: TemplateRef<any>)
{
  this.clienteSelected = new VClienteResponse();
  this.titleModal = "NUEVO cliente";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarCliente(template: TemplateRef<any>, cliente:VClienteResponse)
{
  this.clienteSelected = cliente;
  this.titleModal = "EDITAR cliente";
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
    this.listarCliente();
  }

}
eliminarRegistro(id : number){
  let result = confirm("¿Está seguro de eliminar el registro?");
  if(result)
    {
      this._clienteService.delete(id).subscribe({
        next:(data:number)=>{
          alert("Registro eliminado de forma correcta");
        },
        error:()=>{},
        complete:()=>{
          this.listarCliente();
        }
      });
    }

}

}
