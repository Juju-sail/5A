import {ComponentFixture, TestBed} from '@angular/core/testing';

import {RandomCounterComponent} from './random-counter.component';

describe('RandomCounterComponent', () => {
  let component: RandomCounterComponent;
  let fixture: ComponentFixture<RandomCounterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RandomCounterComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(RandomCounterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
