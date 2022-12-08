import { Component, OnInit } from '@angular/core';
import { Character } from '../classes/character';

@Component({
  selector: 'app-structural-directive',
  templateUrl: './structural-directive.component.html',
  styleUrls: ['./structural-directive.component.css']
})
export class StructuralDirectiveComponent implements OnInit{
  isLogin: boolean = true;
  isLogout: boolean = true;
  list = ["One", "Two", "Three", "Four", "Five"];
  status: string = "New";

  characters: Character[] = [
    {
      actor_name: 'Peter Dinklage',
      character_name: 'Tyrion Lannister',
      gender: 'Male',
      status: 'Alive'
    },
    {
      actor_name: 'Sean Bean',
      character_name: 'Ned Stark',
      gender: 'Male',
      status: 'Dead'
    },
    {
      actor_name: 'Emilia Clark',
      character_name: 'Khaleesi',
      gender: 'Female',
      status: 'Alive'
    },
    {
      actor_name: 'Michelle Fairley',
      character_name: 'Catelyn Stark',
      gender: 'Female',
      status: 'Dead'
    }    
  ];


  constructor() {}
  ngOnInit(): void {}

}
