import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalhesCompraComponentComponent } from './detalhes-compra-component.component';

describe('DetalhesCompraComponentComponent', () => {
  let component: DetalhesCompraComponentComponent;
  let fixture: ComponentFixture<DetalhesCompraComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DetalhesCompraComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DetalhesCompraComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
