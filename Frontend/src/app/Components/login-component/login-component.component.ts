import { Route, RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { routes } from './../../app.routes';
import { Component } from '@angular/core';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';

@Component({
  selector: 'app-login-component',
  standalone: true,
  imports: [RouterOutlet,
  RouterLink,
  RouterLinkActive,
  MenuRoutComponentComponent],
  templateUrl: './login-component.component.html',
  styleUrl: './login-component.component.scss'
})
export class LoginComponentComponent {

}
