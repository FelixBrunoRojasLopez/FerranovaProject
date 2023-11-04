import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { urlConstants } from '@constants/url.constants';
import { CargoResponse } from '@models/cargo-response.model';
import { CargoRequest } from '@modules/auth/models/cargo-request.model';
import { CrudService } from '@modules/shared/services/crud.service';
import { GenericFilterRequest } from '@modules/auth/models/generic-filter-request.model';

@Injectable({
  providedIn: 'root'
})
export class CargoService extends CrudService<CargoRequest,CargoResponse>{
  genericFilter(request: GenericFilterRequest) {
    throw new Error('Method not implemented.');
  }
  constructor(
    protected http: HttpClient,
  ) { 
    super(http, urlConstants.cargo)
  }

  // constructor(
  //   private _http:HttpClient
  // ) { }
// getAll():Observable<CargoResponse[]>{
  // let auth_token = sessionStorage.getItem("token");
  // const jwtHeaders = new HttpHeaders({
  //   'Content-Type': 'application/json',
  //   'Authorization': `Bearer ${auth_token}`
  // })
//   return this._http.get<CargoResponse[]>(urlConstants.cargo);
// }
// create(request:CargoRequest): Observable<CargoResponse>{
//  return this._http.post<CargoResponse>(urlConstants.cargo, request);
// }
// update(request:CargoRequest): Observable<CargoResponse>{
//   return this._http.put<CargoResponse>(urlConstants.cargo, request);
// }
// delete(id: number): Observable<number>{
//   return this._http.delete<number>(`${urlConstants.cargo}${id}`);
// }

}


