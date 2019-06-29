import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductEidtComponent } from './product-eidt.component';

describe('ProductEidtComponent', () => {
  let component: ProductEidtComponent;
  let fixture: ComponentFixture<ProductEidtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductEidtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductEidtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
