import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AccionMantConst } from '@constants/general.constants';
import { alert_error, alert_success } from '@functions/general.functions';
import { VClienteResponse } from '@models/vcliente-response.model';
import { VClienteRequest } from '@modules/auth/models/vcliente-request.model';
import { ClienteService } from '@modules/mantenimiento/service/cliente.service';

@Component({
  selector: 'app-cliente-register',
  templateUrl: './cliente-register.component.html',
  styleUrls: ['./cliente-register.component.scss']
})
export class ClienteRegisterComponent implements OnInit{
  
  /**TODO: Declarando Variables de entrada */
  @Input() title    : string = "";
  @Input() cliente  : VClienteResponse = new VClienteResponse();
  @Input() accion   : number = 0;

/**TODO: Declarando Variables de salida */
  @Output() closeModalEmmit = new EventEmitter<boolean>();


    /**TODO: Declarando Variables internas */
  myForm1           : FormGroup;
  clienteEnvio      : VClienteRequest = new VClienteRequest();
  constructor(
    private     fb            : FormBuilder,
    private _clienteService   : ClienteService,

  )
  {
    this.myForm1 = this.fb.group({
    IdCliente    :[{value : 0, disabled: true },[Validators.required]],
    Nombre       :[[Validators.required]],
    Apellido     :[[Validators.required]],
    //Descripcion  :[[Validators.required]],
    NroDocumento :[[Validators.required]],
    Correo       :[[Validators.required]],
    Telefono     :[[Validators.required]],
    });
  }

  
  ngOnInit(): void {

    console.log("title ==>", this.title);
    console.log("cliente ==>", this.cliente);
 
    this.myForm1.patchValue(this.cliente);
    
  }
  guardar()
  {
    this.clienteEnvio = this.myForm1.getRawValue()
    switch(this.accion)
    {
      case AccionMantConst.crear:
        this.crearRegistro();
          break;
      case AccionMantConst.editar:
        this.editarRegistro();
          break;
      case AccionMantConst.eliminar: 
          break;
    }
  }
  crearRegistro(){
    this._clienteService.create(this.clienteEnvio).subscribe({
      next:(data: VClienteResponse)=>{
        alert_success("Creado existosamente","CREADO");
      },
      error:()=>{
        alert_error("Ocurrio un error","ERROR");
      },
      complete:()=>{
        this.cerrarModal(true);
      }
    })
  }
  editarRegistro(){
    this._clienteService.update(this.clienteEnvio).subscribe({
      next:(data:VClienteResponse)=>{
        alert_success("actualizado de forma correcta","ACTULIZADO");
      },
      error:()=>{
        alert_error("Ocurrio un error","ERROR");
      },
      complete:()=>{
        this.cerrarModal(true);
      }
    });

  }
  cerrarModal(res: boolean)
  {
    //true ==> hubo modificacion en base de datos ==> necesito volver a cargar la lista
    //false ==> no hubo modificacion en base de datos ==> no necesito volver a cargar la lista
    this.closeModalEmmit.emit(res);
  }
  
}

  