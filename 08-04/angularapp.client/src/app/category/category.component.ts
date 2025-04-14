import { Component } from '@angular/core';
import { URLService } from '../service/url.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {
  categoryContainer: any;
  constructor(private _url: URLService) {}

  ngOnInit() {
    this.getAllCategories();
  }

  getAllCategories() {
    this._url.getCategory().subscribe((data) => {
      this.categoryContainer = data;
    })
  }

  addCategory() {

  }
}
