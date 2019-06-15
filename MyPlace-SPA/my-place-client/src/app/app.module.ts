import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';


import { UserFormComponent } from './components/user-form/user-form.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HomeComponent } from './components/home/home.component';
import { ArticleFormComponent } from './components/article-form/article-form.component';
import { ArticleSearchComponent } from './components/article-search/article-search.component';
import { ArticleService } from './services/article.service';

@NgModule({
  declarations: [
    AppComponent,
    UserFormComponent,
    NavbarComponent,
    HomeComponent,
    ArticleFormComponent,
    ArticleSearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    ArticleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
