/*
 *  This will hopefully be a customized menuItem bound to a listview in the messages View. 
 * 
 */



using System;
using Xamarin.Forms;
namespace XamTut
{
    public class ProtoContact : MenuItem
    {
        public ProtoContact()
        {
        }

        public String Name { get; set; }
        public String Number { get; set; }

        public override String ToString(){
            return Name;
        }



    }
}
