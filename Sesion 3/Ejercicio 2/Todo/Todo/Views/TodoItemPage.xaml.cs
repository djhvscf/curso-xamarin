using System;
using Xamarin.Forms;

namespace Todo
{
	public partial class TodoItemPage : ContentPage
	{
		public TodoItemPage()
		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var todoItem = (TodoItem)BindingContext;
			await App.Database.SaveItemAsync(todoItem);
			// Utilice Navigation para volver a la lista de items.
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
            // Utilice Navigation para volver a la lista de items.
        }

        async void OnCancelClicked(object sender, EventArgs e)
		{
            // Utilice Navigation para volver a la lista de items.
        }
    }
}
