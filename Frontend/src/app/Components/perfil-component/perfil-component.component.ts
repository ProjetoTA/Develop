import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-perfil-component',
  standalone: true,
  imports: [RouterOutlet,
    RouterLink,
    RouterLinkActive,],
  templateUrl: './perfil-component.component.html',
  styleUrl: './perfil-component.component.scss'
})
export class PerfilComponentComponent {

}
