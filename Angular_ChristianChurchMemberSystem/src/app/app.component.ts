import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = '泛用基督教會會員管理系統';
  userName = '使用者'; // 可根據登入狀態動態取得
  /** 教會會員管理下拉選單是否呈現*/
  MemberMenu = false;

  logout() {
    // 登出邏輯
  }
  /** 切換教會會員管理下拉選單是否呈現*/
  SwitchMemberMenu() {
    this.MemberMenu = !this.MemberMenu;
  }
}
