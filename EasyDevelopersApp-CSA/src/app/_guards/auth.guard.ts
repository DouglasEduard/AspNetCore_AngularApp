import { AuthService } from './../_services/auth.service';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { CanActivate } from '@angular/router/src/utils/preactivation';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  path: ActivatedRouteSnapshot[];
  route: ActivatedRouteSnapshot;

  constructor(private authService: AuthService, private router: Router,
              private alertfy: AlertifyService) {}

  canActivate(): boolean {

    if (this.authService.LoggedIn()) {
        return true;
    }

    this.alertfy.error('User is not loggedin!');
    this.router.navigate(['/home']);
    return false;
  }
}
