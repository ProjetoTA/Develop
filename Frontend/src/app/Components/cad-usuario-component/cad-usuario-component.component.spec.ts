import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadUsuarioComponentComponent } from './cad-usuario-component.component';

describe('CadUsuarioComponentComponent', () => {
  let component: CadUsuarioComponentComponent;
  let fixture: ComponentFixture<CadUsuarioComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadUsuarioComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadUsuarioComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
