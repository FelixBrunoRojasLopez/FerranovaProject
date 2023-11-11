import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { authGuard } from '@guard/auth.guard';
import { NotfoundComponent } from '@pages/notfound/notfound.component';
import * as welcomeComponent from '@pages/welcome/welcome.component';

const routes: Routes = [
  //Enrutamiento Basico
  {
    path: '',component:welcomeComponent.WelcomeComponent
  },
  {
    path: '404',component: NotfoundComponent
  },
  
  //Carga Peresosa
  {
    path: 'auth', loadChildren:()=> import("@modules/auth/auth.module").
    then(x => x.AuthModule)
  },
  {
    path: 'dashboard',
    canActivate:[authGuard],
    loadChildren:()=>import('@modules/template/template.module').then(x => x.TemplateModule)
  },
  {
    path: 'pages', loadChildren:()=> import("@modules/template/template.module").
    then(x => x.TemplateModule)
  },
  
  // {
  //   path: '**', redirectTo : '404'
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes,{useHash: true}),],
  exports: [RouterModule]
})
export class AppRoutingModule { }
