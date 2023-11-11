import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { LoginResponse } from '@models/login/login-response';
import { MenuResponse } from '@models/menu-response.model';
import { MenuRequest } from '@modules/auth/models/menu-request.model';
import { CrudService } from '@modules/shared/services/crud.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MenuService extends CrudService<MenuRequest,MenuResponse>{

  constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.rol);
  }
  lista(idUsuario: number):Observable<LoginResponse>{
    return this.http.get<LoginResponse>(`${this.url_service}Lista?idUsuario=${idUsuario}`)
  }
}
