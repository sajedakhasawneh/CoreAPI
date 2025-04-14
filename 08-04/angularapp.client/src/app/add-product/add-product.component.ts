import { Component } from '@angular/core';
import { URLService } from '../service/url.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent {

  constructor(private _url: URLService) { }
  ngOnInit() { }

  newProduct(data: any) {
    var formData: any = new FormData();
    formData.append("Name", data.Name); //same as  in the Dto (from here it send it to the Dto and From the Dto to the DataBase)
    formData.append("Description", data.Description);

    this._url.addProduct(data).subscribe(() => {
      alert("Product Added Successufully");
    })
  }

}
