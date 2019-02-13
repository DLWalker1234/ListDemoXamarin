using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListDemo.Models;
using Xamarin.Forms;

namespace ListDemo
{
    public partial class Demo : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call?", contact.Name, "OK");
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

            _contacts = new ObservableCollection<Contact> {
                    new Contact { Name = "Dustin", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Brad", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Blue lives Matte!" }
                };

            listView.ItemsSource = _contacts;

            }

        }
    }


