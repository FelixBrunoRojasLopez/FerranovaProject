import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

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
