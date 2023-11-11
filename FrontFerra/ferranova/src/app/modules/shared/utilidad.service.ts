import { Injectable } from '@angular/core';
import { MatSnackBar} from '@angular/material/snack-bar'



export class UtilidadService {

  constructor(
    private _snackBar:MatSnackBar
  ) { }
  mostrarAlerta(mensaje:string, tipo:string){
    this._snackBar.open(mensaje,tipo,{
      horizontalPosition: "end",
      verticalPosition  : "top",
      duration:3000,
    })
  }
  guardarSesionUsuario(usuarioSession:any){
    sessionStorage.setItem("usuario",JSON.stringify(usuarioSession))
  }
  obtenerSesionUsuario(){
    const dataCadena = sessionStorage.getItem("usuario");
    const usuario = JSON.parse(dataCadena!);
  }
  eliminarSesionUsuario(){
    sessionStorage.removeItem("usuario");
  }
}
