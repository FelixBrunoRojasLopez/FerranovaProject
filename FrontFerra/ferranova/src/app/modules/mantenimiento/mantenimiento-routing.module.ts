import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MantCargoListComponent } from './component/cargo/mant-cargo-list/mant-cargo-list.component';
import { MantPersonaListComponent } from './component/persona/mant-persona-list/mant-persona-list.component';

const routes: Routes = [
  {
    path: 'cargo', component:MantCargoListComponent
  },
  {
    path: 'persona', component:MantPersonaListComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MantenimientoRoutingModule { }
