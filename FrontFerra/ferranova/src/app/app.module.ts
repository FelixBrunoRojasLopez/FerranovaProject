import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { WelcomeComponent } from './pages/welcome/welcome.component';
import { NotfoundComponent } from './pages/notfound/notfound.component';
import { AuthInterceptor } from '@services/auth.interceptor';
import { DashBoardComponent } from './modules/mantenimiento/component/dash-board/dash-board.component';
import { SharedModule } from '@modules/shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    NotfoundComponent,
    //DashBoardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //TODO: Para Usar Double Binding / Uso de Formularios
    FormsModule,
    HttpClientModule,
    SharedModule,
    BrowserAnimationsModule
  ],
  providers: [
    { provide : HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
