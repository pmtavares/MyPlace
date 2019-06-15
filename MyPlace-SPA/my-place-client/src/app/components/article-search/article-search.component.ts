import { Component, OnInit } from '@angular/core';
import { ArticleService } from 'src/app/services/article.service';
import { Article } from 'src/app/_models/Article';

@Component({
  selector: 'app-article-search',
  templateUrl: './article-search.component.html',
  styleUrls: ['./article-search.component.css']
})
export class ArticleSearchComponent implements OnInit {
  articles: Article[];

  constructor(private articleService: ArticleService) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles()
  {
    this.articleService.getArticles()
      .subscribe((articles: Article[]) =>{
        this.articles = articles
        console.log(this.articles);
        
      }, errors =>{
        console.log(errors);
      } );
  }

}
