import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/User';



@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private http:HttpClient) { }

  users:User[]=[];

  ngOnInit() {
    alert("başladı")
    this.getUsers().subscribe(data=>{
      this.users=data
    })
    
  }

  getUsers(){
    return this.http.get<User[]>("https://localhost:44337/api/values")
  }

}
