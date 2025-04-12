import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class URLService {

  constructor(private _http: HttpClient) { }

  getCategory(): Observable<any>{
    return this._http.get("https://localhost:7272/api/Category");
  }

  getProduct(): Observable<any> {
    return this._http.get("https://localhost:7272/api/Category");
  }
}
