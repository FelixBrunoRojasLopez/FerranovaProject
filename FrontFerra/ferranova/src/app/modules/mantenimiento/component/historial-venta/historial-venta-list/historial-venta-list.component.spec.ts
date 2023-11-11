import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialVentaListComponent } from './historial-venta-list.component';

describe('HistorialVentaListComponent', () => {
  let component: HistorialVentaListComponent;
  let fixture: ComponentFixture<HistorialVentaListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HistorialVentaListComponent]
    });
    fixture = TestBed.createComponent(HistorialVentaListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
