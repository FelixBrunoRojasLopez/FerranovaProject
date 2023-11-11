import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialVentaRegisterComponent } from './historial-venta-register.component';

describe('HistorialVentaRegisterComponent', () => {
  let component: HistorialVentaRegisterComponent;
  let fixture: ComponentFixture<HistorialVentaRegisterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HistorialVentaRegisterComponent]
    });
    fixture = TestBed.createComponent(HistorialVentaRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
