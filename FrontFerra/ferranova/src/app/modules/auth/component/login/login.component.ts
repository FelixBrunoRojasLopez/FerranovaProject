import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { sessionConst } from '@functions/general.functions';
import { LoginResponse } from '@models/login/login-response';
import { LoginRequest } from '@modules/auth/models/Login-Request';
import { AuthService } from '@modules/auth/service/auth.service';

import { Observable } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  loginForm: FormGroup;
  loginRequest: LoginRequest = new LoginRequest();

  constructor(
    private fb          : FormBuilder,
    private _authService:AuthService,
    private _router     : Router
    //private loginService:AuthService
    )
  {
    this.loginForm = this.fb.group({
      username:[null, [Validators.required]],
      password:[null, [Validators.required]],
    })
  }

  username: string = "";
  password: string = "";
  
  Login(){
    console.log(this.loginForm.getRawValue());
    //este login request lo tengo que enviar al servicio web
    this.loginRequest = this.loginForm.getRawValue();

    this._authService.Login(this.loginRequest).subscribe({
      next: (data:LoginResponse) => {
        console.log(data);
        alert("login correcto");
        //redirigir al dashboard
        this._router.navigate(['dashboard'])
        //Almacenaremos el valor del token y algunos valores de nuestro usuario
        //Pära Sesion Storage
        if(data.Success){

         // sessionStorage.setItem("token", data.token)
         // sessionStorage.setItem("IdUsuario", data.usuario.idUsuarioAcceso.toString());
         // sessionStorage.setItem("userName", data.usuario.username );
         // sessionStorage.setItem("fullName",data.persona.nombre )
         // sessionStorage.setItem("rolId",data.rol.idRol.toString())
         sessionStorage.setItem(sessionConst.token,data.token);
        }
        else{
          return;
        }
       },
      error: (err) => { },
      complete: () => { },
    });
  }
}
