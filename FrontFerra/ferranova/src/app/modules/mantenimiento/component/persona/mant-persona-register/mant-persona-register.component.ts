import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AccionMantConst } from '@constants/general.constants';
import { convertToBoolean, alert_success, alert_error } from '@functions/general.functions';
import { PersonaResponse } from '@models/persona-response.model';
import { PersonaRequest } from '@modules/auth/models/persona-request.model';
import { PersonaService } from '@modules/mantenimiento/service/persona.service';

@Component({
  selector: 'app-mant-persona-register',
  templateUrl: './mant-persona-register.component.html',
  styleUrls: ['./mant-persona-register.component.scss']
})
export class MantPersonaRegisterComponent implements OnInit{
  
  /**TODO: Declarando Variables de entrada */
  @Input() title    : string = "";
  @Input() persona  : PersonaResponse = new PersonaResponse();
  @Input() accion   : number = 0;

/**TODO: Declarando Variables de salida */
@Output() closeModalEmmit = new EventEmitter<boolean>();


    /**TODO: Declarando Variables internas */
  myForm      : FormGroup;
  personaEnvio  : PersonaRequest = new PersonaRequest();
  constructor(
    private fb: FormBuilder,
    private _personaService: PersonaService,

  )
  {
    this.myForm = this.fb.group({
    idPersona       : [[Validators.required]],
    nombre          : [[Validators.required]],
    apellido        : [[Validators.required]],
    direccion       : [[Validators.required]],
    telefono        : [[Validators.required]],
    correo          : [[Validators.required]],
    idTipoDocumento : [[Validators.required]],
    nroDocumento    : [[Validators.required]],
    nombreCompleto  : [[Validators.required]],

    });
  }

  
  ngOnInit(): void {

    console.log("title ==>", this.title);
    console.log("persona ==>", this.persona);
 
    this.myForm.patchValue(this.persona);
    
  }
  guardar()
  {
    this.personaEnvio = this.myForm.getRawValue()
    //this.personaEnvio.idEstado = convertToBoolean(this.personaEnvio.idEstado.toString());
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
    this._personaService.create(this.personaEnvio).subscribe({
      next:(data: PersonaResponse)=>{
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
    this._personaService.update(this.personaEnvio).subscribe({
      next:(data:PersonaResponse)=>{
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
