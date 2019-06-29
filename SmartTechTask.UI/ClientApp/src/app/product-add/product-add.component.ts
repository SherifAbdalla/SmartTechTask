import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/Http'

@Component({
  selector: 'product-add',
  templateUrl: './product-add.component.html'
})
export class ProductAddComponent {
  public product: Product;
  http: HttpClient;
  constructor(http: HttpClient) {
    this.http = http;
  }
  Add(name: HTMLInputElement, price: HTMLInputElement, photo: HTMLInputElement) {
    this.product.Name = name.value;
    this.product.Price = Number.parseFloat(price.value);
    this.product.Photo = photo.value;
    this.http.put("http://localhost:8170/api/product/Add", this.product).subscribe();
  }
}
