import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { LoginResponse } from '@models/login/login-response';
import { CrudService } from '@modules/shared/services/crud.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DashBoardService {
  private url = urlConstants;
constructor(private http:HttpClient){

}
resumen():Observable<LoginResponse>{
  return this.http.get<LoginResponse>(`${this.url.dashboard}Resumen`)
}
}
