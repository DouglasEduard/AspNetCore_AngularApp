import { Component, OnInit, Input } from '@angular/core';
import { Talent } from 'src/app/_Models/Talent';

@Component({
  selector: 'app-talent-card',
  templateUrl: './talent-card.component.html',
  styleUrls: ['./talent-card.component.css']
})
export class TalentCardComponent implements OnInit {

  @Input() user: Talent;
  
  constructor() { }

  ngOnInit() {
  }

}
