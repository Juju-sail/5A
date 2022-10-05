import {Directive, ElementRef, Input, Renderer2} from '@angular/core';

@Directive({
  selector: '[appCouleurEtoiles]'
})
export class CouleurEtoilesDirective {

  @Input()
  set index(index: string) {

    if (parseInt(index) > 2) {
      this._renderer.setStyle(this._el.nativeElement, 'color', 'yellow')
    } else {
      if (parseInt(index) < 1 && parseInt(index) > 0) {
        this._renderer.setStyle(this._el.nativeElement, 'color', 'red')
      } else {
        this._renderer.setStyle(this._el.nativeElement, 'color', 'black')
      }
    }

  }

  constructor(private _el: ElementRef, private _renderer: Renderer2) {

  }

}
