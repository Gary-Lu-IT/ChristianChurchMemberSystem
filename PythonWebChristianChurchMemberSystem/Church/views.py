from django.http import HttpResponse
from django.shortcuts import render

# Create your views here.
def index(request):
    #return HttpResponse("歡迎光臨泛用基督教會會員管理系統")
    return render(request, 'index.html')#, {'title': '歡迎光臨泛用基督教會會員管理系統'})