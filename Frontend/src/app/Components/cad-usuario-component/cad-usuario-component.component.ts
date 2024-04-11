import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';

@Component({
  selector: 'app-cad-usuario-component',
  standalone: true,
  imports: [
    RouterOutlet,
    RouterLink,
    RouterLinkActive,
    MenuRoutComponentComponent,
  ],
  templateUrl: './cad-usuario-component.component.html',
  styleUrl: './cad-usuario-component.component.scss'
})
export class CadUsuarioComponentComponent {

}
