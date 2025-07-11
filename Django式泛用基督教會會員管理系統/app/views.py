from django.shortcuts import render
#from .models import Announcement

def index(request):
    #announcements = Announcement.objects.order_by('-posted_at')[:5]
    return render(request, 'index.html', {
        'announcements': None
    })
