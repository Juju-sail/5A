import {Component} from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private router: Router) {
  }

  public navigateToLivres() {
    this.router.navigate(['/livres'])
  }

  public navigateToHome() {
    this.router.navigate([''])
  }

  public navigateToForm() {
    this.router.navigate(['/form'])
  }
}
