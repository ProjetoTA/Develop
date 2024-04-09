import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagCartaoComponentComponent } from './pag-cartao-component.component';

describe('PagCartaoComponentComponent', () => {
  let component: PagCartaoComponentComponent;
  let fixture: ComponentFixture<PagCartaoComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PagCartaoComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PagCartaoComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
