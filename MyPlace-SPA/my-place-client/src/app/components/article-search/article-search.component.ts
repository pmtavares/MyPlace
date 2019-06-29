import { Component, OnInit } from '@angular/core';
import { ArticleService } from 'src/app/services/article.service';
import { Article } from 'src/app/_models/Article';
import { Category } from 'src/app/_models/Category';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-article-search',
  templateUrl: './article-search.component.html',
  styleUrls: ['./article-search.component.css']
})
export class ArticleSearchComponent implements OnInit {
  articles: Article[];
  categories: Category[];
  category: any;
  articlesShown: Article[] = [];

  constructor(private articleService: ArticleService, private categorieService: CategoryService) { }

  ngOnInit() {
    this.getArticles();
    this.getCategories();
  }

  getArticles()
  {
    this.articleService.getArticles()
      .subscribe((articles: Article[]) =>{
        this.articles = articles       
      }, errors =>{
        console.log(errors);
      } );
  }

  getCategories()
  {
    this.categorieService.getCategories()
      .subscribe((categories: Category[]) =>{
        this.categories = categories;        
      }, error =>{
        console.log(error);
      })
  }

  onCategoryChange()
  {

    /*this.articleService.getArticlesFiltered(this.category)
    .subscribe((articles: Article[]) =>{
      this.articles = articles       
    }, errors =>{
      console.log(errors);
    } ); */
    if(this.category !=null){      
      var selectedArticles = this.articles.filter(x=>x.category.id == this.category);
      this.articlesShown = selectedArticles;         
    }

  }

}
