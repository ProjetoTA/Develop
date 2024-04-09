import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagBoletoComponentComponent } from './pag-boleto-component.component';

describe('PagBoletoComponentComponent', () => {
  let component: PagBoletoComponentComponent;
  let fixture: ComponentFixture<PagBoletoComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PagBoletoComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PagBoletoComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
