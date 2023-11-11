import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashBoardRegisterComponent } from './dash-board-register.component';

describe('DashBoardRegisterComponent', () => {
  let component: DashBoardRegisterComponent;
  let fixture: ComponentFixture<DashBoardRegisterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DashBoardRegisterComponent]
    });
    fixture = TestBed.createComponent(DashBoardRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
