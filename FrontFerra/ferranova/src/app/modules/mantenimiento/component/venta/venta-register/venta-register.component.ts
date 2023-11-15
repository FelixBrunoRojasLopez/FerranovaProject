import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AccionMantConst } from '@constants/general.constants';
import { alert_error, alert_success } from '@functions/general.functions';
import { VClienteResponse } from '@models/vcliente-response.model';
import { VentaResponse } from '@models/venta-response.model';
import { VProductoResponse } from '@models/vproducto-response.model';
import { VentaRequest } from '@modules/auth/models/venta-request.model';
import { VentaService } from '@modules/mantenimiento/service/venta.service';

@Component({
  selector: 'app-venta-register',
  templateUrl: './venta-register.component.html',
  styleUrls: ['./venta-register.component.scss']
})
export class VentaRegisterComponent implements OnInit {
  @Input() title    : string = "";
  @Input() venta: VentaResponse = new VentaResponse();
  @Input() accion   : number = 0;
  @Output() closeModalEmmit = new EventEmitter<boolean>();

  myForm: FormGroup;
  productoSelected: VProductoResponse[] = [];
  ventaEnvio      : VentaRequest = new VentaRequest();
  constructor(
    private fb: FormBuilder,
    private _ventaService: VentaService,

  ) {
    this.myForm = this.fb.group({
      idVenta           : [{ value: 0, disabled: true }, [Validators.required]],
      numeroDocumento   : [null, [Validators.required]],
      //idMetodoPago      : [null, [Validators.required]],
      tipoPago          : [null, [Validators.required]],
      //fechaRegistro     : [null, [Validators.required]],
      total             : [null, [Validators.required]],
      detalleVenta      : [null, [Validators.required]],
    });
  }

  ngOnInit(): void {

    console.log("title ==>", this.title);
    console.log("venta ==>", this.venta);
 
    this.myForm.patchValue(this.venta);
    
  }
  guardar()
  {
    this.ventaEnvio = this.myForm.getRawValue()
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
    this._ventaService.create(this.ventaEnvio).subscribe({
      next:(data: VentaResponse)=>{
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
    this._ventaService.update(this.ventaEnvio).subscribe({
      next:(data:VentaResponse)=>{
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