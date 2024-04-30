import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';

@Component({
  selector: 'app-perfil-component',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive, MenuRoutComponentComponent],
  templateUrl: './perfil-component.component.html',
  styleUrl: './perfil-component.component.scss'
})
export class PerfilComponentComponent {

}
