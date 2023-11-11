import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { ProductoResponse } from '@models/producto-response.model';
import { ProductoRequest } from '@modules/auth/models/producto-request.model';
import { CrudService } from '@modules/shared/services/crud.service';

@Injectable({
  providedIn: 'root'
})
export class ProductoService extends CrudService<ProductoRequest,ProductoResponse> {

  constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.producto);
  }

}
