import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryComponent } from './category/category.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddProductComponent } from './add-product/add-product.component';
import { EditProductComponent } from './edit-product/edit-product.component';
import { ProductComponent } from './product/product.component';

const routes: Routes = [
  { path: "viewCategory", component: CategoryComponent },
  { path: "addCategory", component: AddCategoryComponent },
  { path: "viewProduct", component: ProductComponent },
  { path: "addProduct", component: AddProductComponent },
  { path: "editproduct/:id", component: EditProductComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
