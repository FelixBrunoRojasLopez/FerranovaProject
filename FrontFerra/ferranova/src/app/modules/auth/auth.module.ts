import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './component/login/login.component';
import { SharedModule } from '@modules/shared/shared.module';



@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    SharedModule
    // FormsModule,
    // ReactiveFormsModule,
    // HttpClientModule // ==> sin este no podemos consumir ningun servicio web
  ],
  
})
export class AuthModule { }
