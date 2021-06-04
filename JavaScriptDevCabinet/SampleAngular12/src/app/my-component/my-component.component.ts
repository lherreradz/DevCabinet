import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-component',
  templateUrl: './my-component.component.html',
  styleUrls: ['./my-component.component.css']
})
export class MyComponentComponent implements OnInit {

  age: number;
  names: Array<string>

  constructor() { 
    this.age = 20;
    this.names = ['Jhon', 'Pepe', 'Michael']
  }  

  ngOnInit(): void {
    console.log('My component leaded!')
  }

  increaseAge(){
    this.age = this.age + 1;
    console.log('Age increase!')
  }
  
  decreaseAge(){
    this.age--;
    console.log('Age decrease!')
  }

}
