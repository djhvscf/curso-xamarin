using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
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