
import { NgbModal, NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { Component } from '@angular/core';
import { PostComponent } from '../post/post.component';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';
import { PerfilComponentComponent } from '../perfil-component/perfil-component.component';
import { NewPostComponentComponent } from '../new-post-component/new-post-component.component';


@Component({
  selector: 'app-feed-component',
  standalone: true,
  imports: [NgbModalModule, PostComponent, MenuRoutComponentComponent,PerfilComponentComponent, NewPostComponentComponent],
  templateUrl: './feed-component.component.html',
  styleUrl: './feed-component.component.scss'
})
export class FeedComponentComponent {

constructor(private modalService: NgbModal) { } // Injete o serviço NgbModal no construtor{


   // Método para abrir a modal
   openModal(content: any) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title' }).result.then((result) => {
      // Aqui você pode adicionar qualquer lógica que deseja executar quando a modal é fechada.
    });
  }
}
