import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReporteListComponent } from './reporte-list.component';

describe('ReporteListComponent', () => {
  let component: ReporteListComponent;
  let fixture: ComponentFixture<ReporteListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReporteListComponent]
    });
    fixture = TestBed.createComponent(ReporteListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
