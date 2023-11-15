import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModalModule } from 'ngx-bootstrap/modal';

import { MantenimientoRoutingModule } from './mantenimiento-routing.module';
import { MantCargoListComponent } from './component/cargo/mant-cargo-list/mant-cargo-list.component';
import { MantCargoRegisterComponent } from './component/cargo/mant-cargo-register/mant-cargo-register.component';
import { MantPersonaListComponent } from './component/persona/mant-persona-list/mant-persona-list.component';
import { MantPersonaRegisterComponent } from './component/persona/mant-persona-register/mant-persona-register.component';
import { SharedModule } from '@modules/shared/shared.module';
import { MantRolRegisterComponent } from './component/rol/mant-rol-register/mant-rol-register.component';
import { MantRolListComponent } from './component/rol/mant-rol-list/mant-rol-list.component';
import { VentaRegisterComponent } from './component/venta/venta-register/venta-register.component';
import { ReporteRegisterComponent } from './component/reporte/reporte-register/reporte-register.component';
import { HistorialVentaRegisterComponent } from './component/historial-venta/historial-venta-register/historial-venta-register.component';
import { DashBoardRegisterComponent } from './component/dash-board/dash-board-register/dash-board-register.component';
import { DashBoardListComponent } from './component/dash-board/dash-board-list/dash-board-list.component';
import { HistorialVentaListComponent } from './component/historial-venta/historial-venta-list/historial-venta-list.component';
import { ProductoRegisterComponent } from './component/producto/producto-register/producto-register.component';
import { ProductoListComponent } from './component/producto/producto-list/producto-list.component';
import { ReporteListComponent } from './component/reporte/reporte-list/reporte-list.component';
import { VentaListComponent } from './component/venta/venta-list/venta-list.component';
import { ClienteListComponent } from './component/cliente/cliente-list/cliente-list.component';
import { ClienteRegisterComponent } from './component/cliente/cliente-register/cliente-register.component';



@NgModule({
  declarations: [
    MantCargoListComponent,
    MantCargoRegisterComponent,
    MantPersonaListComponent,
    MantPersonaRegisterComponent,
    MantRolRegisterComponent,
    MantRolListComponent,
    VentaRegisterComponent,
    ReporteRegisterComponent,
    HistorialVentaRegisterComponent,
    DashBoardRegisterComponent,
    DashBoardListComponent,
    HistorialVentaListComponent,
    ProductoRegisterComponent,
    ProductoListComponent,
    ReporteListComponent,
    VentaListComponent,
    ClienteListComponent,
    ClienteRegisterComponent,
    

  ],
  imports: [
    CommonModule,
    MantenimientoRoutingModule,
    SharedModule,
  ],
 
})
export class MantenimientoModule { }
