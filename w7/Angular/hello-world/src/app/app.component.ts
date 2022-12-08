import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Hello World';
  firstname = 'John';
  lastname = 'Smith';
  demoText = "";
  radioChoice = " ";
  radioResponse = " ";

  demo(){
    console.log("Demo Done.");
    this.demoText = "Demo Done."
  }

  RadioForm() {
    this.radioResponse = "It's " + this.radioChoice.toLowerCase() + "? That's pretty neat."
    console.log(this.radioChoice);
  }
}
