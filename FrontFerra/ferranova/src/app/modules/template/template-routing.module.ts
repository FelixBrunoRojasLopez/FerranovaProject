import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TemplateComponent } from './component/template/template.component';
import { DashBoardComponent } from '../mantenimiento/component/dash-board/dash-board.component';
import { LoginComponent } from '@modules/auth/component/login/login.component';
import { ProductoComponent } from '../mantenimiento/component/producto/producto.component';
import { VentaComponent } from '../mantenimiento/component/venta/venta.component';
import { HistorialVentaComponent } from '../mantenimiento/component/historial-venta/historial-venta.component';
import { ReporteComponent } from '../mantenimiento/component/reporte/reporte.component';

const routes: Routes = [
  {
    path : '',component: TemplateComponent,
    children:[
      {
        path: 'mantenimiento', loadChildren:()=>import('@modules/mantenimiento/mantenimiento.module').then(x=>x.MantenimientoModule)
      },
      {
        path: 'reportes', loadChildren:()=>import('@modules/mantenimiento/mantenimiento.module').then(x=>x.MantenimientoModule)
      },
      
    ]
  },
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TemplateRoutingModule { }
