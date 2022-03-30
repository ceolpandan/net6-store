import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {

  busyRequestCount = 0;

  constructor(private spinnerService: NgxSpinnerService) { }

  busy(){
    this.busyRequestCount += 1;
    this.spinnerService.show(undefined, {
      type: 'la-ball-fall',
      bdColor: 'rgba(255,255,255,0.7)',
      color: '#333333'
    });
  }

  idle(){
    this.busyRequestCount -= 1;
    if(this.busyRequestCount <= 0){
      this.busyRequestCount = 0;
      this.spinnerService.hide();
    }
  }
}
