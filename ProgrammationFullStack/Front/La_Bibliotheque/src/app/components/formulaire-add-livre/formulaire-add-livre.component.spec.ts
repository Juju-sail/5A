import {ComponentFixture, TestBed} from '@angular/core/testing';

import {FormulaireAddLivreComponent} from './formulaire-add-livre.component';

describe('FormulaireAddLivreComponent', () => {
  let component: FormulaireAddLivreComponent;
  let fixture: ComponentFixture<FormulaireAddLivreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FormulaireAddLivreComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(FormulaireAddLivreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
