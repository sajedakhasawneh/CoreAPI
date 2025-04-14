import { Component } from '@angular/core';
import { URLService } from '../service/url.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {
  categoryContainer: any;
  constructor(private _url: URLService) { }
  ngOnint() {}

  addCategory(data:any) {
    this._url.addCategory(data).subscribe((data) => {
      this.categoryContainer = data;
    })
  }
}
