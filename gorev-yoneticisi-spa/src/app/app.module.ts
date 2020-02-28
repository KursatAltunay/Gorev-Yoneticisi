import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { AppComponent } from './app.component';
import { FlatpickrModule } from 'angularx-flatpickr';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { UserComponent } from './user/user.component';
import { CalendarComponent } from './calendar/calendar.component';
import { FormsModule } from '@angular/forms';
import { WorkComponent } from './work/work.component';

@NgModule({
   declarations: [
      AppComponent,
      UserComponent,
      CalendarComponent,
      WorkComponent
   ],
   imports: [
      FormsModule,
      CommonModule,
      NgbModalModule,
      FlatpickrModule.forRoot(),
      BrowserModule,
      HttpClientModule,
      CalendarModule.forRoot({
         provide: DateAdapter,
         useFactory: adapterFactory
       })
   ],   
   providers: [],
   bootstrap: [
      AppComponent
   ]
   
})
export class AppModule { }
