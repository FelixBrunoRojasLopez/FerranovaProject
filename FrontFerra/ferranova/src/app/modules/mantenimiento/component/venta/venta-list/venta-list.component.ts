import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { AccionMantConst } from '@constants/general.constants';
import { VentaResponse } from '@models/venta-response.model';
import { VentaService } from '@modules/mantenimiento/service/venta.service';
import { Venta } from '@modules/shared/interfaces/venta';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-venta-list',
  templateUrl: './venta-list.component.html',
  styleUrls: ['./venta-list.component.scss']
})
export class VentaListComponent implements OnInit {

  modalRef?       : BsModalRef;
  venta           : VentaResponse[] = [];
  ventaSelected   : VentaResponse = new VentaResponse();
  titleModal      : string = "";
  accionModal     : number = 0;

  constructor(
    private _route          : Router,
    private modalService    : BsModalService,
    private _ventaService   : VentaService,
  ){}
  ngOnInit(): void {
    this.getAllSale();
  }

  getAllSale() {
    this._ventaService.getAllSale().subscribe(
      (data: VentaResponse) => {
        if (Array.isArray(data)) {
          this.venta = data;
        } else {
          // Si no es un array, asume que es un solo objeto y colócalo en un array
          this.venta = [data];
        }
      },
      (error) => {
        console.error('Error fetching sales:', error);
      }
    );
  }
  crearVenta(template: TemplateRef<any>)
{
  this.ventaSelected = new VentaResponse();
  this.titleModal = "NUEVO ROL";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}

  listarVenta(template: TemplateRef<any>)
  {
    this.ventaSelected = new VentaResponse();
    this.titleModal = "NUEVO ROL";
    this.accionModal = AccionMantConst.crear;
    this.openModal(template);
  }
  editarRol(template: TemplateRef<any>, rol:VentaResponse)
  {
    this.ventaSelected = rol;
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
      this.getAllSale();
    }
  
  }
  eliminarRegistro(id : number){
    let result = confirm("¿Está seguro de eliminar el registro?");
    if(result)
      {
        this._ventaService.delete(id).subscribe({
          next:(data:number)=>{
            alert("Registro eliminado de forma correcta");
          },
          error:()=>{},
          complete:()=>{
            this.getAllSale();
          }
        });
      }
  
  }
}