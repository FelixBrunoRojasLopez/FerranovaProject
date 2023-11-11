import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MantCargoListComponent } from './component/cargo/mant-cargo-list/mant-cargo-list.component';
import { MantPersonaListComponent } from './component/persona/mant-persona-list/mant-persona-list.component';
import { MantRolListComponent } from './component/rol/mant-rol-list/mant-rol-list.component';
import { DashBoardComponent } from './component/dash-board/dash-board.component';
import { ProductoComponent } from './component/producto/producto.component';
import { VentaComponent } from './component/venta/venta.component';
import { HistorialVentaComponent } from './component/historial-venta/historial-venta.component';
import { ReporteComponent } from './component/reporte/reporte.component';






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
    path: 'dashboard',component:DashBoardComponent
  },
  // {
  //   path: 'usuario',component:UsuarioComponent
  // },
  {
    path: 'producto',component:ProductoComponent
  },
  {
    path: 'venta',component:VentaComponent
  },
  {
    path: 'historial_venta',component:HistorialVentaComponent
  },
  {
    path: 'reporte',component:ReporteComponent
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MantenimientoRoutingModule { }
