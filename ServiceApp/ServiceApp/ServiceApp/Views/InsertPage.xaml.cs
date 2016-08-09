using ServiceApp.Data;
using ServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ServiceApp.Views
{
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private async void onInsert(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                About = txtAbout.Text,
                BirthDate = pckrBirthDate.Date
            };

            ServiceManager manager = new ServiceManager();
            var result = await manager.Add(model);
            if (result.Result)
            {
                DisplayAlert("Success", result.Message, "OK!");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Error", result.Message, "OK!");
            }
        }
    }
}
