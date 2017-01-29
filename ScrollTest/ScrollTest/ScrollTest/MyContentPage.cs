using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollTest
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {        

            Picker picker = new Picker
            {
                Title = "Seleccione Cereal",
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            picker.Items.Add("Girasol");
            picker.Items.Add("Soja");            
            picker.Items.Add("Trigo");
            picker.Items.Add("Maíz");
            picker.Items.Add("Sorgo");
            picker.Items.Add("Cebada");            

            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    Children = {                        
                        picker,
                        new Entry(){
                           Placeholder = "First Name"
                        },
                        new Entry(){
                           Placeholder = "Middle Name"
                        },
                        new Entry(){
                           Placeholder = "Last Name"
                        },
                        new Entry(){
                           Placeholder = "Address Line 1"
                        },
                        new Entry(){
                           Placeholder = "Address Line 2"
                        },
                        new Entry(){
                           Placeholder = "City"
                        },
                        new Entry(){
                           Placeholder = "State Code (Example : OD)"
                        },
                        new Entry(){
                           Placeholder = "Country Code (Example : IN)"
                        },
                        new Entry(){
                           Placeholder = "Zip code"
                        },
                        new Entry(){
                           Placeholder = "Phone number"
                        },
                        new Entry(){
                           Placeholder = "Consumer Number"
                        },
                        new Entry(){
                           Placeholder = "Agent Name"
                        },
                        new Entry(){
                           Placeholder = "Agent Code"
                        },
                        new Entry()
                        {
                            Placeholder = "Agent Address  Line 1"
                        },
                        new Entry()
                        {
                            Placeholder = "Agent Address  Line 2"
                        }
                     }
                }
            };
        }
    }
}
