using System;
using System.Collections.Generic;
using ListDemo.Models;
using Xamarin.Forms;

namespace ListDemo
{
    public partial class PullRefersh : ContentPage
    {
        List<Contact> GetContacts()
        {
            return new List<Contact> {
                new Contact { Name = "Dustin", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Brad", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Blue lives Matte!" }
                };
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            // SAME => listView.IsRefreshing = false;
            listView.EndRefresh();

        }

        public PullRefersh()
        {
            InitializeComponent();

            listView.ItemsSource = GetContacts();
        }
    }
}
