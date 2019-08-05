import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { HomeComponent } from './home/home.component';
import { Component } from '@angular/core';
import {Routes} from '@angular/router';
import { TalentsComponent } from './talents/talents.component';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent },
    {path: 'talents', component: TalentsComponent },
    {path: 'messages', component: MessagesComponent },
    {path: 'lists', component: ListsComponent },
    {path: '**', redirectTo: 'home', pathMatch: 'full' }
];
