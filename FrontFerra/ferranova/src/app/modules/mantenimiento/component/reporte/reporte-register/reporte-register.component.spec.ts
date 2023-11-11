import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReporteRegisterComponent } from './reporte-register.component';

describe('ReporteRegisterComponent', () => {
  let component: ReporteRegisterComponent;
  let fixture: ComponentFixture<ReporteRegisterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReporteRegisterComponent]
    });
    fixture = TestBed.createComponent(ReporteRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
