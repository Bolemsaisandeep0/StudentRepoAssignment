import { Component,Inject } from '@angular/core';
import { GridDataResult, PageChangeEvent } from "@progress/kendo-angular-grid";
import { CompositeFilterDescriptor } from "@progress/kendo-data-query";
import { filterBy, process } from "@progress/kendo-data-query";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';
import { HttpHeaders } from '@angular/common/http';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public pageSize = 5;
  public skip = 0;

  public students: Student[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post<StudentVm>(baseUrl + 'data', null).subscribe((result: StudentVm) => {
      this.students = result.students;
    }, error => console.error(error));
  }
  
}

export class StudentVm {
  public students: Student[]=[]
}
export class Student {
  public name: string = "";
  public age: string = "";
  public hobbies:[] = [];
}
