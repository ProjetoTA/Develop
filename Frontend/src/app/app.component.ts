import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuRoutComponentComponent } from './Components/menu-rout-component/menu-rout-component.component';
import { CadUsuarioComponentComponent } from './Components/cad-usuario-component/cad-usuario-component.component';
import { FeedComponentComponent } from './Components/feed-component/feed-component.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MenuRoutComponentComponent, CadUsuarioComponentComponent, FeedComponentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'PetProjeto';
}
