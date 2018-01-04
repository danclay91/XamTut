using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using XamTut.Models;

namespace XamTut
{
    public partial class Messages : ContentPage
    {
        ObservableCollection<ProtoContact> contactList = new ObservableCollection<ProtoContact>();
        public ObservableCollection<Contact> NewContactList { get; set; }

        int count = 0;
        public Messages()
        {
            InitializeComponent();
            BindingContext = this;
            NewContactList = new ObservableCollection<Contact>();
            NewContactList.Add(new Contact() { Name = "Andrew", Number = "4232906826" });
            Contact_List.ItemsSource = NewContactList;
            ///var addContactModal = new AddContactModal();

        }


        /* This adds a dummy contact to the contactList<ProtoContact>. Observable collection 
         * updates ListView
         */
        void Add_Contact(object sender, System.EventArgs e)
        {
            //Test Code
            /*User testUser = new User();
            testUser.ID = "123";
            testUser.Username = "Danny";
            testUser.Contacts = new string[] { "Andrew", "Dummy" };
            DisplayAlert("TESTING", JsonConvert.SerializeObject(testUser), "OK");
            */

            //contactList.Add(new ProtoContact(new ConversationPage("Andrew")){Name="Andrew", Number="4232906826"});
            //count++;
            NewContactList.Add(new Contact(){Name="New Guy", Number="911"});
        }



        /*  Event Handler for ListView. As 
         * 
         */

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null){
                var selection = e.SelectedItem as Contact;

                Navigation.PushAsync(new ConversationPage(selection.Name));
                Contact_List.SelectedItem = null;
            }    
        }



    }
}
