using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
	public class App : Application
	{
		static TodoItemDatabase database;

		public App()
		{
			var navigationPage = new TodoNavigationPage(new TodoListPage());

            MainPage = navigationPage;
		}

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
                    database = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
				}
				return database;
			}
		}

		public int ResumeAtTodoId { get; set; }
	}
}

