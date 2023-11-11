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
import { UsuarioComponent } from './component/usuario/usuario.component';
import { VentaRegisterComponent } from './component/venta/venta-register/venta-register.component';
import { ReporteRegisterComponent } from './component/reporte/reporte-register/reporte-register.component';
import { HistorialVentaRegisterComponent } from './component/historial-venta/historial-venta-register/historial-venta-register.component';
import { DashBoardRegisterComponent } from './component/dash-board/dash-board-register/dash-board-register.component';



@NgModule({
  declarations: [
    MantCargoListComponent,
    MantCargoRegisterComponent,
    MantPersonaListComponent,
    MantPersonaRegisterComponent,
    MantRolRegisterComponent,
    MantRolListComponent,
    UsuarioComponent,
    VentaRegisterComponent,
    ReporteRegisterComponent,
    HistorialVentaRegisterComponent,
    DashBoardRegisterComponent,

  ],
  imports: [
    CommonModule,
    MantenimientoRoutingModule,
    SharedModule,
  ]
})
export class MantenimientoModule { }
