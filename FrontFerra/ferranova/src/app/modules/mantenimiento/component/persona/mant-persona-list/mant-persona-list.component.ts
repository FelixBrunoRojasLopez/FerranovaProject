import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { AccionMantConst } from '@constants/general.constants';
import { PersonaResponse } from '@models/persona-response.model';
import { GenericFilterRequest } from '@modules/auth/models/generic-filter-request.model';
import { PersonaService } from '@modules/mantenimiento/service/persona.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-mant-persona-list',
  templateUrl: './mant-persona-list.component.html',
  styleUrls: ['./mant-persona-list.component.scss']
})
export class MantPersonaListComponent implements OnInit {
  modalRef?       : BsModalRef;
  persona         : PersonaResponse[] = [];
  personaSelected : PersonaResponse = new PersonaResponse();
  titleModal      : string = "";
  accionModal     : number = 0;
  myFormFilter    : FormGroup;
  totalItems      : number = 0;
  itemsPerPage    : number = 3;
  request         : GenericFilterRequest = new GenericFilterRequest();
 




  constructor(
    private _route          : Router,
    private fb              : FormBuilder,
    private modalService    : BsModalService,
    private _personaService :PersonaService ,
  ){
    this.myFormFilter = this.fb.group({
      idPersona            : ['',[]],
      nombre               : ['',[]],
      apellido             : ['',[]],
      direccion            : ['',[]],
      telefono             : ['',[]],
      correo               : ['',[]],
      nroDocumento         : ['',[]],
      idTipoDocumento      : ['',[]],
      descripcionDocumento : ['',[]],
          
    });

  }



  /**
   * FIXME: Es el primer evento que ejecuta el componente
   */
  ngOnInit(): void {
    this.listarPersonas()
}
listarPersonas(){
  this._personaService.getAll().subscribe({
    next:(data: PersonaResponse[])=>{
      this.persona = data;
    },
    error:()=>{},
    complete:()=>{}
  });
}

crearPersona(template: TemplateRef<any>)
{
  this.personaSelected = new PersonaResponse();
  this.titleModal = "NUEVO Persona";
  this.accionModal = AccionMantConst.crear;
  this.openModal(template);
}
editarPersona(template: TemplateRef<any>, persona:PersonaResponse)
{
  this.personaSelected = persona;
  this.titleModal = "EDITAR Persona";
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
    this.listarPersonas();
  }

}
eliminarRegistro(id : number){
  let result = confirm("¿Está seguro de eliminar el registro?");
  if(result)
    {
      this._personaService.delete(id).subscribe({
        next:(data:number)=>{
          alert("Registro eliminado de forma correcta");
        },
        error:()=>{},
        complete:()=>{
          this.listarPersonas();
        }
      });
    }

}
// filtrar() {
//   let valueForm = this.myFormFilter.getRawValue();
//   this.request.filtros.push({ name: "codigo", value: valueForm.codigo });
//   this.request.filtros.push({ name: "nombre", value: valueForm.nombre });
//   this.request.filtros.push({ name: "idEstado", value: valueForm.idEstado });
//   this._Personaservice.genericFilter(this.request).subscribe({
//     next: (data: GenericFilterResponse<PersonaResponse>) => {
//       console.log(data);
//       this.Personas = data.lista;
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
