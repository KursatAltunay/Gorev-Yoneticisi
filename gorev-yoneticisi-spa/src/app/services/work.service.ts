import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Work } from '../models/Work';

@Injectable({
  providedIn: 'root'
})
export class WorkService {

constructor(private httpClient:HttpClient) { }
path:string = "https://localhost:44337/api/";

  getWorksByUser(userID: number):Observable<Work[]>{
    //var userID = LocalStorageHandler.getUserID() 
    //return this.httpClient.get<Work[]>(this.path+"Works/?userId=" + userID)
    return this.httpClient.get<Work[]>(this.path+"Works/?userId=" + userID)
  }
}
