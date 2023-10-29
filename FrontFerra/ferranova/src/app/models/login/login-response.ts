import { CargoResponse } from "@models/cargo-response.model";
import { EmpleadoResponse } from "@models/empleado-response.model";
import { PersonaResponse } from "@models/persona-response.model";
import { RolResponse } from "@models/rol-response.model";
import { UsuarioLoginResponse } from "@models/usuario-login-response.model";

type NewType = CargoResponse;

export class LoginResponse
{
     Success        : boolean = false;
     Mensaje        : string = "";
     token          : string = "";
     TokenExpira    : string = "";
     usuario        : UsuarioLoginResponse = new UsuarioLoginResponse();
     rol            : RolResponse = new RolResponse();
     empleado       : EmpleadoResponse = new EmpleadoResponse();
     persona        : PersonaResponse = new PersonaResponse();
     cargo          : CargoResponse = new CargoResponse();
}