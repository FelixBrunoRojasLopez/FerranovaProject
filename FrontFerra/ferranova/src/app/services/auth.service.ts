import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginResponse } from '@models/login/login-response';
import { LoginRequest } from '@modules/auth/models/Login-Request';
import { CrudService } from '@modules/shared/services/crud.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService { //implements CrudService<LoginRequest,LoginResponse>{

  constructor(
    protected http:HttpClient
  ) {

   }
   roles(token : string){

    
    //TODO: COMO ENVIAMOS EL TOKEN EN LA PETICIÓN ==> return this.http.get("https://localhost:7063/api/Cargo");
  
   const httpheaders = new HttpHeaders({
     'Content-Type': 'application/json',
     'Authorization': `Bearer ${token}`
   })

    return this.http.get("https://localhost:7171/api/Cargo", {headers:httpheaders});


   }

   login(request:any){
    return this.http.post("https://localhost:7171/api/Auth", request)
   }

}
