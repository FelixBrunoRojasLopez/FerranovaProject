import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup ,Validators } from '@angular/forms';
import { AccionMantConst } from '@constants/general.constants';
import { convertToBoolean } from '@functions/general.functions';

import { CargoResponse } from '@models/cargo-response.model';
import { CargoRequest } from '@modules/auth/models/cargo-request.model';
import { CargoService } from '@modules/mantenimiento/service/cargo.service';

@Component({
  selector: 'app-mant-cargo-register',
  templateUrl: './mant-cargo-register.component.html',
  styleUrls: ['./mant-cargo-register.component.scss']
})
export class MantCargoRegisterComponent implements OnInit{
  
  /**TODO: Declarando Variables de entrada */
  @Input() title  : string = "";
  @Input() cargo  : CargoResponse = new CargoResponse();
  @Input() accion : number = 0;

/**TODO: Declarando Variables de salida */
@Output() closeModalEmmit = new EventEmitter<boolean>();


    /**TODO: Declarando Variables internas */
  myForm      : FormGroup;
  cargoEnvio  : CargoRequest = new CargoRequest();
  constructor(
    private fb: FormBuilder,
    private _cargoService: CargoService,

  )
  {
    this.myForm = this.fb.group({
    idCargo           :[{value : 0, disabled: true },[Validators.required]],
    codigo            :[[Validators.required]],
    descripcionCargo  :[[Validators.required]], 
    idEstado          :[[Validators.required]],
    });
  }

  
  ngOnInit(): void {

    console.log("title ==>", this.title);
    console.log("cargo ==>", this.cargo);
 
    this.myForm.patchValue(this.cargo);
    
  }
  guardar()
  {
    this.cargoEnvio = this.myForm.getRawValue()
    this.cargoEnvio.idEstado = convertToBoolean(this.cargoEnvio.idEstado.toString());
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
    this._cargoService.create(this.cargoEnvio).subscribe({
      next:(data: CargoResponse)=>{
        alert("Creado existosamente");
      },
      error:()=>{
        alert("Ocurrio un error");
      },
      complete:()=>{
        this.cerrarModal(true);
      }
    })
  }
  editarRegistro(){
    this._cargoService.update(this.cargoEnvio).subscribe({
      next:(data:CargoResponse)=>{
        alert("actualizado de forma correcta");
      },
      error:()=>{
        alert("Ocurrio un erro");
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
