import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Talent } from '../_Models/Talent';


const httpOptions = {
  headers: new HttpHeaders({
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
}

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getUsers(): Observable<Talent[]> {
      return this.http.get<Talent[]>(this.baseUrl + 'talents', httpOptions);
  }

  getUser(id): Observable<Talent> {
    return this.http.get<Talent>(this.baseUrl + 'talents/' + id, httpOptions);
  }
}
