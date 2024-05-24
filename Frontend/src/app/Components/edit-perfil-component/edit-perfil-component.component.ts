import { Component } from '@angular/core';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-edit-perfil-component',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive, MenuRoutComponentComponent],
  templateUrl: './edit-perfil-component.component.html',
  styleUrl: './edit-perfil-component.component.scss'
})

export class EditPerfilComponentComponent {
  isEditModalOpen = false;
  user = { name: '', email: '' };

  constructor() { }

  ngOnInit(): void {
  }

  openEditModal() {
    console.log('Opening modal...');
    this.isEditModalOpen = true;
    setTimeout(() => {
      document.querySelector('.modal')?.classList.add('show');
    }, 0);
  }

  closeEditModal() {
    console.log('Closing modal...');
    this.isEditModalOpen = false;
    setTimeout(() => {
      document.querySelector('.modal')?.classList.remove('show');
    }, 300);
  }

  toggleModal() {
    this.isEditModalOpen = !this.isEditModalOpen;
    if (this.isEditModalOpen) {
      setTimeout(() => {
        document.querySelector('.modal')?.classList.add('show');
      }, 0);
    } else {
      setTimeout(() => {
        document.querySelector('.modal')?.classList.remove('show');
      }, 300);
    }
  }

}
