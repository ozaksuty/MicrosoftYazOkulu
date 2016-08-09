using ServiceApp.Data;
using ServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ServiceApp.Views
{
    public partial class ListPage : ContentPage
    {
        readonly IList<StudentModel> students = new ObservableCollection<StudentModel>();
        readonly ServiceManager manager = new ServiceManager();
        public ListPage()
        {
            BindingContext = students;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            this.IsBusy = true;
            try
            {
                students.Clear();
                var collection = await manager.GetAll();
                foreach (StudentModel item in collection)
                    students.Add(item);
            }
            finally
            {
                this.IsBusy = false;
            }
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OnAddNewStudent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedStudent = (StudentModel)menuItem.CommandParameter;
            var mobileResult = await manager.Delete(selectedStudent);
            if (mobileResult.Result)
            {
                DisplayAlert("Success", mobileResult.Message, "OK");
                students.Remove(selectedStudent);
            }
            else
            {
                DisplayAlert("Error", mobileResult.Message, "OK");
            }
        }
    }
}