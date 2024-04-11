import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadSucessoComponenteComponent } from './cad-sucesso-componente.component';

describe('CadSucessoComponenteComponent', () => {
  let component: CadSucessoComponenteComponent;
  let fixture: ComponentFixture<CadSucessoComponenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadSucessoComponenteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadSucessoComponenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
