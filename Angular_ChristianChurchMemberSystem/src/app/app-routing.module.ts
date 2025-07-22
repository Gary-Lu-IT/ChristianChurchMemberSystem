import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  //{ path: 'member/basic', component: MemberBasicComponent },
  //{ path: 'member/account', component: MemberAccountComponent },
  //{ path: 'member/family', component: MemberFamilyComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
