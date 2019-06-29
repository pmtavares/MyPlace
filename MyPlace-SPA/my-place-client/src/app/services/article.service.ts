import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Article } from '../_models/Article';


@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getArticles() : Observable<Article[]>
  {
    return this.http.get<Article[]>(this.baseUrl+"articles");
  }
  getArticlesFiltered(id: number) : Observable<Article[]>
  {
    return this.http.get<Article[]>(this.baseUrl+"articles/category/"+id);
  }

}
