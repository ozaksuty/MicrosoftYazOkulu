using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using yazokulu1.Models;
using yazokulu1.SQLiteHelper;

namespace yazokulu1.Views
{
    public partial class DataBind : ContentPage
    {
        readonly IList<Students> model =
            new ObservableCollection<Students>();
        SQLiteManager manager = new SQLiteManager();
        public DataBind()
        {
            Padding = new Thickness(0, 
                Device.OnPlatform(20, 0, 0), 0, 0);
            InitializeComponent();

            var students = manager.GetAll().ToList();

            lstStudents.ItemsSource = students;
        }

        private async void onSelected(object sender,
            SelectedItemChangedEventArgs e)
        {
            Students selectedStudent = (Students)e.SelectedItem;
            bool isOk = await DisplayAlert(selectedStudent.Name,
                selectedStudent.Surname, "Sil", "Silme");
            if (isOk)
            {
                DisplayAlert(selectedStudent.Name, "Silindi!", "OK");
            }
        }

        private void onRefresh(object sender, EventArgs e)
        {
            model.Add(new Students
            {
                Id = 2,
                Name = "Ersin",
                Surname = "Yıldız",
                School = "İYTE"
            });
            lstStudents.IsRefreshing = false;
        }

        private void onInsertClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Insert());
        }
    }
}
