import { CanActivateFn } from '@angular/router';
import { sessionConst } from '@functions/general.functions';




export const authGuard: CanActivateFn = (route, state) => {
  let Token = sessionStorage.getItem(sessionConst.token);
   if(Token)
  {
    alert("guard ==> no iniciaste sesión")
    //DEBEMOS REDIRIGIR AL USUARIO HACIA LA PANTALLA DEL LOGIN
    return false;
  }



  return true;

};
