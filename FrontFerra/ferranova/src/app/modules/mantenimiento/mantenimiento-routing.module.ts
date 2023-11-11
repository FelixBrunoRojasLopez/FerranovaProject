import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MantCargoListComponent } from './component/cargo/mant-cargo-list/mant-cargo-list.component';
import { MantPersonaListComponent } from './component/persona/mant-persona-list/mant-persona-list.component';
import { MantRolListComponent } from './component/rol/mant-rol-list/mant-rol-list.component';
import { DashBoardListComponent } from './component/dash-board/dash-board-list/dash-board-list.component';
import { ProductoListComponent } from './component/producto/producto-list/producto-list.component';
import { VentaListComponent } from './component/venta/venta-list/venta-list.component';
import { HistorialVentaListComponent } from './component/historial-venta/historial-venta-list/historial-venta-list.component';
import { ReporteListComponent } from './component/reporte/reporte-list/reporte-list.component';






const routes: Routes = [
  {
    path: 'cargo', component:MantCargoListComponent
  },
  {
    path: 'persona', component:MantPersonaListComponent
  },
  {
    path: 'rol', component:MantRolListComponent
  },
  {
    path: 'dashboard',component:DashBoardListComponent
  },

  {
    path: 'producto',component:ProductoListComponent
  },
  {
    path: 'venta',component:VentaListComponent
  },
  {
    path: 'historial_venta',component:HistorialVentaListComponent
  },
  {
    path: 'reporte',component:ReporteListComponent
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MantenimientoRoutingModule { }
