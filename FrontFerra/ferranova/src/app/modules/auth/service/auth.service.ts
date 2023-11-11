
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { LoginResponse } from '@models/login/login-response';
import { LoginRequest } from '../models/Login-Request';
import { urlConstants } from '@constants/url.constants';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http:HttpClient) { }
  Login(request:LoginRequest):Observable<LoginResponse>{
  return this.http.post<LoginResponse>(urlConstants.auth,request);
} 



}
