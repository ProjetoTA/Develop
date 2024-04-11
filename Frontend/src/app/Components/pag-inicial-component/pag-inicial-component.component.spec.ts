import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagInicialComponentComponent } from './pag-inicial-component.component';

describe('PagInicialComponentComponent', () => {
  let component: PagInicialComponentComponent;
  let fixture: ComponentFixture<PagInicialComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PagInicialComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PagInicialComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
