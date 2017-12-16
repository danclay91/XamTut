using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace XamTut
{
    public partial class Messages : ContentPage
    {
        ObservableCollection<ProtoContact> contactList = new ObservableCollection<ProtoContact>();

        int count = 0;
        public Messages()
        {
            InitializeComponent();
            contactList.Add(new ProtoContact(new ConversationPage("Andrew") ){ Name = "Andrew", Number = "4232906826" });
            Contact_List.ItemsSource = contactList;
            var addContactModal = new AddContactModal();

        }


        /* This adds a dummy contact to the contactList<ProtoContact>. Observable collection 
         * updates ListView
         */
        void Add_Contact(object sender, System.EventArgs e)
        {
            contactList.Add(new ProtoContact(new ConversationPage("Andrew")){Name="Andrew", Number="4232906826"});
            count++;
        }

        /*  Event Handler for ListView. As 
         * 
         */

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null){
                var selection = e.SelectedItem as ProtoContact;
                Navigation.PushAsync(selection.conversation);
                Contact_List.SelectedItem = null;
            }    
        }



    }
}
