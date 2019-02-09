using System;
using System.Collections.Generic;
using ListDemo.Models;
using Xamarin.Forms;

namespace ListDemo
{
    public partial class Demo : ContentPage
    {
        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call?", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {

        }

        //void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        // var contact = e.Item as Contact;
        // DisplayAlert("Selected", contact.Name, "OK");
        // }

        /* void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
         {
             var contact = e.SelectedItem as Contact;
             DisplayAlert("Tapped", contact.Name, "OK");
         }
         */

        public Demo()
        {
            InitializeComponent();



            listView.ItemsSource = new List<ContactGroup>{

                new ContactGroup("D", "D") {
                    new Contact { Name = "Dustin", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                },

                new ContactGroup("B", "B") {
                    new Contact { Name = "Brad", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Blue lives Matte!" }
                }

            };

        }
    }
}

