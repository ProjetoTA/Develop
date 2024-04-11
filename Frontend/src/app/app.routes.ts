import { Routes } from '@angular/router';
import { CadUsuarioComponentComponent } from './Components/cad-usuario-component/cad-usuario-component.component';
import { FeedComponentComponent } from './Components/feed-component/feed-component.component';
import { LoginComponentComponent } from './Components/login-component/login-component.component';
import { PerfilComponentComponent } from './Components/perfil-component/perfil-component.component';
import { CadProdutoComponentComponent } from './Components/cad-produto-component/cad-produto-component.component';
import { CadPetComponentComponent } from './Components/cad-pet-component/cad-pet-component.component';
import { CadSucessoComponenteComponent } from './Components/cad-sucesso-componente/cad-sucesso-componente.component';

export const routes: Routes = [
     { path: 'cadUsu', component:CadUsuarioComponentComponent },
     { path: 'feed', component: FeedComponentComponent },
     { path: '', component: LoginComponentComponent },
     { path: 'perfil', component:PerfilComponentComponent  },
     { path: 'CadProd', component: CadProdutoComponentComponent },
     { path: 'Cadpet', component: CadPetComponentComponent },
     { path: 'CadSucess', component: CadSucessoComponenteComponent}
];
