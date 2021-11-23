import { Component, OnInit } from '@angular/core';
import { NgForm }   from '@angular/forms';

@Component({
  selector: 'app-userpost',
  templateUrl: './userpost.component.html',
  styleUrls: ['./userpost.component.css']
})
export class UserpostComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  

 onSubmit(x:any): void {
   console.log("getting data from the user question");
  //  let formData = new FormData();
  //  formData.append('title', postObj.title);
  //  formData.append('description', postObj.description);
  //  if (this.selectedFile)
  //  {
  //    formData.append('sampleFile', this.selectedFile);
  //  }
  //  let tagging = 'x';
  //  for (let tag of this.tags) {
  //    if (postObj[tag.name])
  //    {
  //      tagging += ' ' + tag.value;
  //    }
  //  }
  //  formData.append('tags', tagging);

  //  this.post_obj.onCreatePost(formData).subscribe(
  //    (res) => {
  //      console.log(res);
  //      this.notificationService.showNotification('Successfully posted', 'OK', 'success')
  //      this.close = true;
  //    },
  //    (err)=>{
  //      console.log(err);
  //    }
  //  )

 }
}
