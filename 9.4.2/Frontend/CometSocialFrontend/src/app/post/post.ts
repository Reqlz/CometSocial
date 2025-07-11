import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-post',
  imports: [],
  templateUrl: './post.html',
  styleUrl: './post.scss'
})
export class Post {
  @Input() imageUrl: string = "";
  @Input() description: string = "";
  @Input() title: string = "";
  @Input() interactionNumber: number = 0;
  @Input() comentTargetUrl: string = "";
  @Input() comentNumber: number = 0;
}
