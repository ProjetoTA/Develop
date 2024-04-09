import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagPixComponentComponent } from './pag-pix-component.component';

describe('PagPixComponentComponent', () => {
  let component: PagPixComponentComponent;
  let fixture: ComponentFixture<PagPixComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PagPixComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PagPixComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
