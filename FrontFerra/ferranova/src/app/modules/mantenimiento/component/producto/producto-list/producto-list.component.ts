import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AccionMantConst } from '@constants/general.constants';
import { ProductoResponse } from '@models/producto-response.model';

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
  producto           : ProductoResponse[] = [];
  productoSelected   : ProductoResponse = new ProductoResponse();
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
    idProducto            :["",[]],
    nombre                :["",[]],
    idDetalleProducto     :["",[]],
    //descripcionProducto   :["",[]],
    stock                 :["",[]],
    precio                :["",[]],
    idEstado              :['',[]],
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
    next:(data: ProductoResponse[])=>{
      this.producto = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearProducto(template: TemplateRef<any>)
{
  this.productoSelected = new ProductoResponse();
  this.titleModal = "NUEVO Producto";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarProducto(template: TemplateRef<any>, Producto:ProductoResponse)
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
