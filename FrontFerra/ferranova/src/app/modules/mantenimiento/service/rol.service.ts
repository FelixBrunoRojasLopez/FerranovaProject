import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { urlConstants } from '@constants/url.constants';
import { CrudService } from '@modules/shared/services/crud.service';
import { RolResquest } from '@modules/auth/models/rol-request.model';
import { RolResponse } from '@models/rol-response.model';

@Injectable({
  providedIn: 'root'
})
export class RolService extends CrudService<RolResquest,RolResponse>{
  constructor(
    protected http: HttpClient,
  ) { 
    super(http, urlConstants.rol)
  }
}