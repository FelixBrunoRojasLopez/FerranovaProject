import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { LoginResponse } from '@models/login/login-response';
import { LoginRequest } from '../models/Login-Request';
import { urlConstants } from '@constants/url.constants';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http:HttpClient) { }
  Login(requet:LoginRequest):Observable<LoginResponse>{
  return this.http.post<LoginResponse>(urlConstants.auth,requet);
} 

}
