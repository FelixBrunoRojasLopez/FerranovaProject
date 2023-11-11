import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductoRegisterComponent } from './producto-register.component';

describe('ProductoRegisterComponent', () => {
  let component: ProductoRegisterComponent;
  let fixture: ComponentFixture<ProductoRegisterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProductoRegisterComponent]
    });
    fixture = TestBed.createComponent(ProductoRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
