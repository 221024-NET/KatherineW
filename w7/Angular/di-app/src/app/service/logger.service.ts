import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {

  constructor() { }

  callStack: string[] = [];

  addLog(message: string): void {
    //this.callStack = [message].concat(this.callStack);
    this.callStack.unshift(message);
    this.printHead();
  }

  clear(): void {
    this.printLog();
    this.callStack = [];
    console.log("DELETED LOG");
  }

  show(): void {
    this.printLog();
  }

  private printHead(): void {
    console.log("printHead()...");
    console.log(this.callStack[0] || null);
  }

  private printLog(): void {
    console.log("printLog()...");
    this.callStack.reverse().forEach((log) => console.log(log));
  }

}
