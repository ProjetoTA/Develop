import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadPetComponentComponent } from './cad-pet-component.component';

describe('CadPetComponentComponent', () => {
  let component: CadPetComponentComponent;
  let fixture: ComponentFixture<CadPetComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CadPetComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadPetComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
