using AgendaContacto.DataAccess.Servicios;
using AgendaContacto.ViewModel;
using Xunit;

namespace AgendaContacto.Tests
{
    public class ContactoViewModelTests
    {
        [Fact]
        public void CargarContactosCommandIsNotNullTest()
        {
            var contactoMockService = new ContactoMockService();
            var contactoViewModel = new ContactoViewModel(contactoMockService);
            Assert.NotNull(contactoViewModel.CargarContactosCommand);
        }

        [Fact]
        public void ContactosPropertyIsNullWhenViewModelInstantiatedTest()
        {
            var contactoMockService = new ContactoMockService();
            var contactoViewModel = new ContactoViewModel(contactoMockService);
            Assert.NotNull(contactoViewModel.Contactos);
        }

        [Fact]
        public void IsBusyPropertyShouldRaisePropertyChanged()
        {
            bool invoked = false;
            var contactoMockService = new ContactoMockService();
            var contactoViewModel = new ContactoViewModel(contactoMockService);
            contactoViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals(nameof(contactoViewModel.IsBusy)))
                {
                    invoked = true;
                }
            };

            contactoViewModel.CargarContactosCommand.Execute(null);

            Assert.True(invoked);
        }
    }
}
