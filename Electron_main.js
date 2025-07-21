const { app, BrowserWindow } = require('electron');
const path = require('path');
const url = require('url');

function createWindow() {
  const win = new BrowserWindow({
    width: 1024,
    height: 768,
    webPreferences: {
      nodeIntegration: false,
      contextIsolation: true,
    },
  });

  win.loadURL(
    url.format({
      pathname: path.join(__dirname, 'dist/my-angular-app/index.html'),
      protocol: 'file:',
      slashes: true,
    })
  );
}