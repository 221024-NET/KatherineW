import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit{

  private _title: string = "";
  public clickCount: number = 0;

  @Input()
  public set title(title: string) { this._title = title}
  public get title() { return this._title} // Error from forgetting the get

  @Output() onChanged = new EventEmitter<number>();

  constructor(){}
  ngOnInit(): void{}

  countChange(count: number) {
    count++;
    this.clickCount = count;
    this.onChanged.emit(this.clickCount);
  }

}
