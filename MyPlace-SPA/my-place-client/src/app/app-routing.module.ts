import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { UserFormComponent } from './components/user-form/user-form.component';
import { ArticleFormComponent } from './components/article-form/article-form.component';
import { ArticleSearchComponent } from './components/article-search/article-search.component';

const routes: Routes = [
  {path: "home", component: HomeComponent},
  {path: "users/new", component: UserFormComponent},
  {path: "articles/new", component: ArticleFormComponent},
  {path: "articles/category", component: ArticleSearchComponent},  
  {path: "**", redirectTo: "home"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
