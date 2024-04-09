import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuRoutComponentComponent } from './menu-rout-component.component';

describe('MenuRoutComponentComponent', () => {
  let component: MenuRoutComponentComponent;
  let fixture: ComponentFixture<MenuRoutComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MenuRoutComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MenuRoutComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
