import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { VentaResponse } from '@models/venta-response.model';
import { VentaRequest } from '@modules/auth/models/venta-request.model';
import { CrudService } from '@modules/shared/services/crud.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VentaService extends CrudService<VentaRequest,VentaResponse> {
 constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.venta);
  }
  registrar(request : VentaRequest):Observable<VentaResponse>{
    return this.http.post<VentaResponse>(`${this.url_service}Registrar`, request)
  }
  historial(buscarPor: string, numeroVenta:string, fechaInicio: string,fechaFin: string):Observable<VentaResponse>{
    return this.http.get<VentaResponse>(`${this.url_service}Historial?buscarPor=${buscarPor}&numeroVenta=${numeroVenta}&fechaInicio=${fechaInicio}&fechaFin=${fechaFin}`)
  }
  reporte(fechaInicio: string,fechaFin: string):Observable<VentaResponse>{
    return this.http.get<VentaResponse>(`${this.url_service}Historial?fechaInicio=${fechaInicio}&fechaFin=${fechaFin}`)
  }
  
}
