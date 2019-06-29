import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product-eidt',
  templateUrl: './product-eidt.component.html',
  styleUrls: ['./product-eidt.component.css']
})
export class ProductEidtComponent implements OnInit {

  @Input()
  Product:Product;
  constructor(private http:HttpClient) { }

  ngOnInit() {
  }

  Edit(name: HTMLInputElement, price: HTMLInputElement, photo: HTMLInputElement, id:HTMLInputElement) {
    this.Product.Name = name.value;
    this.Product.Price = Number.parseFloat(price.value);
    this.Product.Photo = photo.value;
    this.Product.Id = Number.parseInt(id.value);
    this.http.put("http://localhost:8170/api/product/Add", this.Product).subscribe();
  }
}
