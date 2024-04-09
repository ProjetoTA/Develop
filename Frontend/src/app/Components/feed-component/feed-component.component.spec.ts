import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeedComponentComponent } from './feed-component.component';

describe('FeedComponentComponent', () => {
  let component: FeedComponentComponent;
  let fixture: ComponentFixture<FeedComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FeedComponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeedComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
