# Generated by Django 2.2.3 on 2019-07-10 16:38

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Notice',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('title', models.TextField()),
                ('pub_date', models.DateTimeField(verbose_name='date published')),
                ('context', models.TextField()),
                ('like', models.IntegerField(default=0)),
                ('image', models.ImageField(default='https://image.flaticon.com/icons/svg/149/149852.svg', upload_to='images/')),
            ],
        ),
    ]
