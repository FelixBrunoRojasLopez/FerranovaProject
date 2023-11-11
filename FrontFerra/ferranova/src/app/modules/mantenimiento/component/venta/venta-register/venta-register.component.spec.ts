import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VentaRegisterComponent } from './venta-register.component';

describe('VentaRegisterComponent', () => {
  let component: VentaRegisterComponent;
  let fixture: ComponentFixture<VentaRegisterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VentaRegisterComponent]
    });
    fixture = TestBed.createComponent(VentaRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
