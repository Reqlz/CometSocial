import { Component } from '@angular/core';
import { Header } from '../header/header';
import { Tab } from '../tab/tab';

@Component({
  selector: 'app-home',
  imports: [Header, Tab],
  templateUrl: './home.html',
  styleUrl: './home.scss'
})
export class Home {

}
