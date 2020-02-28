import { Component, OnInit } from '@angular/core';
import { Work } from '../models/Work';
import { WorkService } from '../services/work.service';

@Component({
  selector: 'app-work',
  templateUrl: './work.component.html',
  styleUrls: ['./work.component.css'],
  providers: [WorkService]
})
export class WorkComponent implements OnInit {

  constructor(private workService: WorkService) { }

  works: Work[]
  ngOnInit() {
    this.workService.getWorksByUser(1).subscribe(data => {
      this.works = data;
    })
  }

}
