import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { VClienteResponse } from '@models/vcliente-response.model';
import { VClienteRequest } from '@modules/auth/models/vcliente-request.model';
import { CrudService } from '@modules/shared/services/crud.service';

@Injectable({
  providedIn: 'root'
})
export class ClienteService extends CrudService<VClienteRequest, VClienteResponse> {

  constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.cliente);
  }
}