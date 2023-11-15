import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { VProductoResponse } from '@models/vproducto-response.model';
import { VProductoRequest } from '@modules/auth/models/vproducto-request.model';
import { CrudService } from '@modules/shared/services/crud.service';

@Injectable({
  providedIn: 'root'
})
export class ProductoService extends CrudService<VProductoRequest,VProductoResponse> {

  constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.producto);
  }

}
