import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public Products: Product[];
  constructor(http: HttpClient, private router:Router) {
    http.put<Product[]>('http://localhost:8170/api/product/GetAll', null).subscribe(result => {
      this.Products = result;
      for (var i = 0; i < this.Products.length; i++) {
        var uints = new Uint8Array(this.Products[i].Photo);
        var base64 = btoa(String.fromCharCode.apply(null, uints));
        this.Products[i].ImageUrl = 'data:image/jpeg;base64,' + base64;
      }
    }, error => { console.error(error); });
  }
  Eidt(product:Product)
  {
      this.router.navigate(['eidt', product]);
  }
}



