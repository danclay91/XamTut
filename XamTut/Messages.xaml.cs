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
            contactList.Add(new ProtoContact { Name = "Katlyn", Number = "as;lkja;sdlkfj" });
            Contact_Container.ItemsSource = contactList;
        }


        /* This adds a dummy contact to the contactList<ProtoContact>. Observable collection 
         * updates ListView
         */
        void Add_Contact(object sender, System.EventArgs e)
        {
            contactList.Add(new ProtoContact{Name="Andrew", Number="4232906826"});
            count++;
        }

    }
}
