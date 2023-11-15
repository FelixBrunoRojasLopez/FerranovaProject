import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AccionMantConst } from '@constants/general.constants';
import { VProductoResponse } from '@models/vproducto-response.model';

import { GenericFilterRequest } from '@modules/auth/models/generic-filter-request.model';
import { ProductoService } from '@modules/mantenimiento/service/producto.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-producto-list',
  templateUrl: './producto-list.component.html',
  styleUrls: ['./producto-list.component.scss']
})
export class ProductoListComponent implements OnInit {
  modalRef?          : BsModalRef;
  producto           : VProductoResponse[] = [];
  productoSelected   : VProductoResponse = new VProductoResponse();
  titleModal         : string = "";
  accionModal        : number = 0;
  myFormFilter       : FormGroup;
  totalItems         : number = 0;
  itemsPerPage       : number = 3;
  request            : GenericFilterRequest = new GenericFilterRequest();
 




  constructor(
    private _route          : Router,
    private fb              : FormBuilder,
    private modalService    : BsModalService,
    private _productoService: ProductoService,
  ){
    this.myFormFilter = this.fb.group({
    IdProducto  :['',[]],
    Nombre      :['',[]],
    Descripcion :['',[]],
    Stock       :['',[]],
    Precio      :['',[]],
    IdEstado    :['',[]],

});

  }



  /**
   * FIXME: Es el primer evento que ejecuta el componente
   */
  ngOnInit(): void {
    this.listarProducto()
}
listarProducto(){
  this._productoService.getAll().subscribe({
    next:(data: VProductoResponse[])=>{
      this.producto = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearProducto(template: TemplateRef<any>)
{
  this.productoSelected = new VProductoResponse();
  this.titleModal = "NUEVO Producto";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarProducto(template: TemplateRef<any>, Producto:VProductoResponse)
{
  this.productoSelected = Producto;
  this.titleModal = "EDITAR Producto";
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
    this.listarProducto();
  }

}
eliminarRegistro(id : number){
  let result = confirm("¿Está seguro de eliminar el registro?");
  if(result)
    {
      this._productoService.delete(id).subscribe({
        next:(data:number)=>{
          alert("Registro eliminado de forma correcta");
        },
        error:()=>{},
        complete:()=>{
          this.listarProducto();
        }
      });
    }

}
}
