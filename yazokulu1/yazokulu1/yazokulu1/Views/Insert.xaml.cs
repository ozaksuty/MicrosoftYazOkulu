using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using yazokulu1.Models;
using yazokulu1.SQLiteHelper;

namespace yazokulu1.Views
{
    public partial class Insert : ContentPage
    {
        SQLiteManager manager = new SQLiteManager();
        public Insert()
        {
            InitializeComponent();
        }

        private void onSave(object sender, EventArgs e)
        {
            Students model = new Students
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                School = txtSchool.Text,
                BirthDate = dpckrBirthDate.Date
            };

            var isSaved = manager.Insert(model);
            if (isSaved > 0)
            {
                DisplayAlert("BİLGİ", "Öğrenci Eklendi", "OK");
                Navigation.PopAsync();
            }
        }
    }
}
