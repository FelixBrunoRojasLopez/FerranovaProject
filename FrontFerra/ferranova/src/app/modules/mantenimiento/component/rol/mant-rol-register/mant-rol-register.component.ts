import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup ,Validators } from '@angular/forms';
import { AccionMantConst } from '@constants/general.constants';
import { alert_error, alert_success, convertToBoolean } from '@functions/general.functions';

import { RolResponse } from '@models/rol-response.model';
import { RolResquest } from '@modules/auth/models/rol-request.model';
import { RolService } from '@modules/mantenimiento/service/rol.service';

@Component({
  selector: 'app-mant-rol-register',
  templateUrl: './mant-rol-register.component.html',
  styleUrls: ['./mant-rol-register.component.scss']
})
export class MantRolRegisterComponent implements OnInit{
  
  /**TODO: Declarando Variables de entrada */
  @Input() title    : string = "";
  @Input() rol      : RolResponse = new RolResponse();
  @Input() accion   : number = 0;

/**TODO: Declarando Variables de salida */
@Output() closeModalEmmit = new EventEmitter<boolean>();


    /**TODO: Declarando Variables internas */
  myForm1       : FormGroup;
  rolEnvio      : RolResquest = new RolResquest();
  constructor(
    private fb            : FormBuilder,
    private _rolService   : RolService,

  )
  {
    this.myForm1 = this.fb.group({
    idRol             :[{value : 0, disabled: true },[Validators.required]],
    codigo            :[[Validators.required]],
    descripcion       :[[Validators.required]], 
    funcion           :[[Validators.required]], 
    idEstado          :[[Validators.required]],
    });
  }

  
  ngOnInit(): void {

    console.log("title ==>", this.title);
    console.log("rol ==>", this.rol);
 
    this.myForm1.patchValue(this.rol);
    
  }
  guardar()
  {
    this.rolEnvio = this.myForm1.getRawValue()
    this.rolEnvio.idEstado = convertToBoolean(this.rolEnvio.idEstado.toString());
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
    this._rolService.create(this.rolEnvio).subscribe({
      next:(data: RolResponse)=>{
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
    this._rolService.update(this.rolEnvio).subscribe({
      next:(data:RolResponse)=>{
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