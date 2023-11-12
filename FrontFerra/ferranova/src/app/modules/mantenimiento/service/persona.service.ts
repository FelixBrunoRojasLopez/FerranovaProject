import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { urlConstants } from '@constants/url.constants';
import { PersonaResponse } from '@models/persona-response.model';
import { PersonaRequest } from '@modules/auth/models/persona-request.model';
import { CrudService } from '@modules/shared/services/crud.service';

@Injectable({
  providedIn: 'root'
})
export class PersonaService extends CrudService<PersonaRequest, PersonaResponse> {

  constructor(
    protected http: HttpClient,
  ) {
    super(http, urlConstants.persona);
  }
}