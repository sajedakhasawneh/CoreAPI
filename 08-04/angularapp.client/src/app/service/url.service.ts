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

  addCategory(data:any) {
    return this._http.post("https://localhost:7272/api/Category", data);
  }

  updateCategory(data:any, id:number) {
    return this._http.put(`https://localhost:7272/api/Category/${id}`, data);
  }

  getProduct(): Observable<any> {
    return this._http.get("https://localhost:7272/api/Products");
  }

  getProductByID(id: number): Observable<any> {
    return this._http.get(`https://localhost:7272/api/Products/${id}`);
  }


  addProduct(data: any) {
    return this._http.post("https://localhost:7272/api/Products", data);
  }

  editProduct(data: any, id: number) {
    return this._http.put(`https://localhost:7272/api/Products/${id}`,data);
  }

}
