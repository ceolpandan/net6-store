import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { IBrand } from '../shared/models/brands';
import { IPagination } from '../shared/models/pagination';
import { IType } from '../shared/models/productType';
import { ShopParams } from '../shared/models/shopParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:7281/api/'

  constructor(private http: HttpClient) { }

  getProducts(shopParams: ShopParams){
    let params = new HttpParams();

    if(shopParams.brandId !==0){
      params = params.append('brandId', shopParams.brandId.toString());
    }

    if(shopParams.typeId !==0){
      params = params.append('typeId', shopParams.typeId.toString());
    }

    if(shopParams.search.length > 0){
      params = params.append('search', shopParams.search);
    }

    params = params.append('sort', shopParams.sort);
    
    params = params.append('pageIndex', shopParams.pageNumber.toString());

    params = params.append('pageSize', shopParams.pageSize.toString());

    return this.http.get<IPagination>(this.baseUrl + "products", {observe: 'response', params})
      .pipe(
        map(response => {
          return response.body;
        })
      );
  }

  getBrands(){
    return this.http.get<IBrand[]>(this.baseUrl + "products/brands");
  }

  getProductTypes(){
    return this.http.get<IType[]>(this.baseUrl + "products/types");
  }
}