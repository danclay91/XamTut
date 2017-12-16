using System;
using System.Collections.Generic;
using Xamarin.Forms;
/*  this will be the modal called when the user wants to add a contact
 * 
 * 
 */
namespace XamTut
{
    public partial class AddContactModal : ContentView
    {
        String Name, Number;
        public AddContactModal()
        {
            InitializeComponent();
        }

        void Name_Entry_Completed(object sender, System.EventArgs e)
        {
            Name = (sender as Entry).Text;
        }

        void Number_Entry_Completed(object sender, System.EventArgs e)
        {
            Name = (sender as Entry).Text;
        }

        void Submit_Clicked(object sender, System.EventArgs e)
        {
           // Parent.
        }
    }
}
