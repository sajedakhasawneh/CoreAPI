import { Component } from '@angular/core';
import { URLService } from '../service/url.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  productContainer: any;


  constructor(private _url: URLService) { }

  ngOnInit() {
    this.getAllProducts();

  }

  getAllProducts() {
    this._url.getProduct().subscribe((data) => {
      this.productContainer = data; 
    })
  }
}
