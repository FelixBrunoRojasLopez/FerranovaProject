import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashBoardListComponent } from './dash-board-list.component';

describe('DashBoardListComponent', () => {
  let component: DashBoardListComponent;
  let fixture: ComponentFixture<DashBoardListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DashBoardListComponent]
    });
    fixture = TestBed.createComponent(DashBoardListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
