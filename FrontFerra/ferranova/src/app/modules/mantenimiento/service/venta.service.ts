import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { VentaResponse } from '@models/venta-response.model';
import { VentaRequest } from '@modules/auth/models/venta-request.model';
import { Venta } from '@modules/shared/interfaces/venta';
import { CrudService } from '@modules/shared/services/crud.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VentaService extends CrudService<VentaRequest,VentaResponse> {

constructor(
  protected http: HttpClient,
) { 
  super(http, urlConstants.venta)
}

  getAllSale():Observable<VentaResponse>{

    return this._http.get<VentaResponse>(this.url_service);
     
  }

  saveSale(venta : VentaRequest):Observable<VentaResponse> {
    return this._http.post<VentaResponse>(this.url_service, venta);
  }
}


// extends CrudService<VentaRequest,VentaResponse> {
//  constructor(
//     protected http: HttpClient,
//   ) {
//     super(http, urlConstants.venta);
//   }