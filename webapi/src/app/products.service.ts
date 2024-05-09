// product.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from './products'; // Assuming you have a Product model

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = '/api/products'; // Assuming your API endpoint is /api/products

  constructor(private http: HttpClient) { }

  getProducts(ascending: boolean): Observable<Product[]> {
    return this.http.get<Product[]>(`${this.apiUrl}/${ascending}`);
  }
}
