import { Routes } from '@angular/router';
import { CadUsuarioComponentComponent } from './Components/cad-usuario-component/cad-usuario-component.component';
import { FeedComponentComponent } from './Components/feed-component/feed-component.component';
import { LoginComponentComponent } from './Components/login-component/login-component.component';
import { PerfilComponentComponent } from './Components/perfil-component/perfil-component.component';
import { CadPetComponentComponent } from './Components/cad-pet-component/cad-pet-component.component';
import { EditPerfilComponentComponent } from './Components/edit-perfil-component/edit-perfil-component.component';

export const routes: Routes = [
     { path: 'cadUsu', component:CadUsuarioComponentComponent },
     { path: 'feed', component: EditPerfilComponentComponent },
     { path: '', component: LoginComponentComponent },
     { path: 'perfil', component:PerfilComponentComponent  },
     { path: 'Cadpet', component: CadPetComponentComponent },
     { path: 'editPerfil', component: EditPerfilComponentComponent}
];
