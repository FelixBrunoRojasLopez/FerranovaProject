import {  Component } from '@angular/core';
// import { AuthService } from '@services/auth.service';
// import { CargoRequest } from '@modules/auth/models/cargo-request.model';
// import { CargoService } from '@services/cargo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent
{
  [x: string]: any;// export class AppComponent implements OnInit, AfterViewInit{
  

//   usuario = "admi ";
//   password = "123456";
//   nombreUsuario = "NOMBRE USUARIO";
//   title = 'ferranova';
  
//    //declaramos la variable token
//    token: string = "";
//    cargoRequest: CargoRequest = new CargoRequest();
//    cargos: CargoRequest[] = [];
 
//   constructor(
//     private _authService : AuthService,
//     private _cargoService : CargoService
//   ){

//   }
//   ngOnInit(): void {
//     console.log('Event on init.');
//   }
 
//   ngAfterViewInit(): void {
//     //throw new Error('Method not implemented.');
//   }

//   iniciarSesion() {

//     let loginRequest: any = {};
//     console.log("usuario ==> ", this.usuario);
//     console.log("password ==> ", this.password);

//     loginRequest.userName = this.usuario;
//     loginRequest.password = this.password;

//     this._authService.login(loginRequest).subscribe(
//       {
//         next: (data: any) => {
//           console.log("IMPRIMIENDO RESULTADO LOGIN", data);
//           this.token = data.token;
//           this.listarRoles();
//         },
//         error: () => { },
//         complete: () => {

//         }
//       }
//     );
//   }

//   /**
//    * TODO: COMO PARAMETRO SE DEBE ENVIAR EL TOKEN OBTENIDO AL MOMENTO DE INICIAR SESIÓN
//    */
//   listarRoles() {
//     this.cargos = [];
//     this._authService.roles(this.token).subscribe(
//       {
//         next: (data: any) => {
//           console.log("IMPRIMIENDO ROLES: ", data);
//           this.cargos = data;
//         },
//         error: () => {
//           console.log("NO SE PUDO OBTENER LA LISTA DE ROLES ");
//         },
//         complete: () => { }
//       }
//     );
//   }

//   crearCargo() {

//     if (this.cargoRequest.id == 0) {
//       this._cargoService.create(this.token, this.cargoRequest).subscribe({
//         next: () => {
//           alert("CREADO");
//           this.listarRoles();

//         },
//         error: () => {
//           alert("ocurrio un error");
//         },
//         complete: () => { }
//       });
//     }
//     else {
//       this._cargoService.update(this.token, this.cargoRequest).subscribe({
//         next: () => {
//           alert("ACTUALIZADO");
//           this.listarRoles();

//         },
//         error: () => {
//           alert("ocurrio un error");
//         },
//         complete: () => { }
//       });
//     }
//   }

//   rellenarValores(cargo: CargoRequest) {

//     this.cargoRequest = cargo;

//   }

//   eliminarRegistro(id: number) {

//     let eliminar = confirm("¿Esta seguro de eliminar?");
//     if (eliminar) {
//       this._cargoService.delete(this.token, id).subscribe({
//         next: () => {
//           alert("ELIMINADO");
//           this.listarRoles();

//         },
//         error: () => {
//           alert("ocurrio un error");
//         },
//         complete: () => { }
//       });
//     }
//   }

}