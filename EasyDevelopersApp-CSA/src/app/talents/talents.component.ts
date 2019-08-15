import { AlertifyService } from './../_services/alertify.service';
import { UserService } from './../_services/user.service';
import { Component, OnInit } from '@angular/core';
import { Talent } from '../_Models/Talent';

@Component({
  selector: 'app-talents',
  templateUrl: './talents.component.html',
  styleUrls: ['./talents.component.css']
})

export class TalentsComponent implements OnInit {

  users: Talent[];

  constructor(private userService: UserService, private alertifyService: AlertifyService) { }

  ngOnInit() {
    this.loadUsers();
  }

  loadUsers() {
    this.userService.getUsers().subscribe((users: Talent[]) => {
      this.users = users;
    },
    error => {
      this.alertifyService.error(error)
    });
  }
}
