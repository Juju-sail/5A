import {Directive, ElementRef, Input, Renderer2} from '@angular/core';

@Directive({
  selector: '[appDirectivePaireBleu]'
})
export class DirectivePaireBleuDirective {

  @Input('appDirectivePaireBleu')
  set index(index: string){

    if(parseInt(index)%2 == 0){
     this._renderer.setStyle(this._el.nativeElement, 'color', 'blue')
   }else {
     this._renderer.setStyle(this._el.nativeElement, 'color', 'red')
   }
  }

  constructor(private _el: ElementRef,private _renderer: Renderer2) {

  }

}
