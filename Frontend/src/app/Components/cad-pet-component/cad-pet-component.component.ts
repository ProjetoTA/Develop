import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MenuRoutComponentComponent } from '../menu-rout-component/menu-rout-component.component';

@Component({
  selector: 'app-cad-pet-component',
  standalone: true,
  imports: [MenuRoutComponentComponent,],
  templateUrl: './cad-pet-component.component.html',
  styleUrl: './cad-pet-component.component.scss'
})
export class CadPetComponentComponent {

}
