using EjemploPersona.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjemploPersona
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormularioPersona : ContentPage
	{
		public FormularioPersona ()
		{
			InitializeComponent ();
            BindingContext = new PersonaViewModel();
		}
	}
}