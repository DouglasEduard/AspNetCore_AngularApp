import { AuthGuard } from './_guards/auth.guard';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { HomeComponent } from './home/home.component';
import { Component } from '@angular/core';
import {Routes} from '@angular/router';
import { TalentsComponent } from './talents/talents.component';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'talents', component: TalentsComponent},
            {path: 'messages', component: MessagesComponent},
            {path: 'lists', component: ListsComponent}
        ]
    },
    {path: '**', redirectTo: '', pathMatch: 'full' }
];
