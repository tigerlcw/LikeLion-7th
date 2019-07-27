from django.urls import path
from . import views

urlpatterns = [
    path('', views.board, name="board"),
    path('detail/<int:board_id>/', views.detail, name="detail"),
    path('new/', views.new, name='new'),
    
    path('detail/<int:board_id>/update', views.update, name='update'),
    path('detail/<int:board_id>/delete', views.delete, name='delete'),
    # path('detail/<int:board_id>/like-toggle',views.board_like_toggle,name='like-toggle'),
]