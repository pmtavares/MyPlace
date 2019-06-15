import { Category } from './Category';
import { User } from './User';

export interface Article
{
    id: number,
    title: string,
    description: string,
    content: string,
    dateAdded: Date,
    lastUpdated: Date,
    dateDeleted: Date,
    likes: number,
    views: number,
    user: User,
    category: Category

}