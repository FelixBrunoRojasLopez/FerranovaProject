import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { alert_success, sessionConst } from '@functions/general.functions';
import { LoginResponse } from '@models/login/login-response';
import { LoginRequest } from '@modules/auth/models/Login-Request';
import { AuthService } from '@modules/auth/service/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  loginForm: FormGroup;
  loginRequest: LoginRequest = new LoginRequest();


  constructor(
    private fb                : FormBuilder,
    private _authService      : AuthService,
    private _router           : Router,
   
    )
  {
    this.loginForm = this.fb.group({
      username:[[],[Validators.required]],
      password:[[],[Validators.required]],
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
        alert_success("Login Correcto", "Iniciaste Sesion");
        //redirigir al dashboard
        this._router.navigate(['dashboard'])
        //Almacenaremos el valor del token y algunos valores de nuestro usuario
        //Pära Sesion Storage
        if(data.Success){

          sessionStorage.setItem(sessionConst.token,data.token);
        }
        else{
          return;
        }
       },
      error: (err) => {
        
       },
      complete: () => { },
    });
  }
}
