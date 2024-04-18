import { NgbModal, NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { Component } from '@angular/core';
import { MenuRoutComponentComponent } from "../menu-rout-component/menu-rout-component.component";


@Component({
    selector: 'app-feed-component',
    standalone: true,
    templateUrl: './feed-component.component.html',
    styleUrl: './feed-component.component.scss',
    imports: [NgbModalModule, MenuRoutComponentComponent, MenuRoutComponentComponent]
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
