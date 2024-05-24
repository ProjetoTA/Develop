import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { MenuRoutComponentComponent } from './Components/menu-rout-component/menu-rout-component.component';
import { CadUsuarioComponentComponent } from './Components/cad-usuario-component/cad-usuario-component.component';
import { FeedComponentComponent } from './Components/feed-component/feed-component.component';
import { PerfilComponentComponent } from './Components/perfil-component/perfil-component.component';
import { LoginComponentComponent } from './Components/login-component/login-component.component';
import { EditPerfilComponentComponent } from './Components/edit-perfil-component/edit-perfil-component.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
  MenuRoutComponentComponent,
  CadUsuarioComponentComponent,
  FeedComponentComponent,
  EditPerfilComponentComponent,
  PerfilComponentComponent,
  LoginComponentComponent,
  RouterOutlet,
  RouterLink,
  RouterLinkActive,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'PetProjeto';
}
