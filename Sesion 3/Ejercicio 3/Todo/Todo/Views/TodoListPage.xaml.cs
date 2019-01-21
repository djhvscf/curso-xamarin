using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Todo
{
	public partial class TodoListPage : ContentPage
	{
		public TodoListPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			// Reset the 'resume' id, since we just want to re-start here
			((App)App.Current).ResumeAtTodoId = -1;
			listView.ItemsSource = await App.Database.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
            if (e.SelectedItem != null)
            {
                
            }
		}

        void OnThemeButtonClicked(object sender, EventArgs e)
        {
            //Utilice Navigation para mostrar el StylePage
            //???(new StylePage());
        }
    }
}
