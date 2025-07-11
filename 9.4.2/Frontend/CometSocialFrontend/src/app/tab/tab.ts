import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-tab',
  imports: [],
  templateUrl: './tab.html',
  styleUrl: './tab.scss'
})
export class Tab {
  @Input() iconUrl: string = "";
  @Input() targetUrl: string = "";
  @Input() text: string = "";
}
