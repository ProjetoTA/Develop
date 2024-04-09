import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadProdutoComponentComponent } from './cad-produto-component.component';

describe('CadProdutoComponentComponent', () => {
  let component: CadProdutoComponentComponent;
  let fixture: ComponentFixture<CadProdutoComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadProdutoComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadProdutoComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
