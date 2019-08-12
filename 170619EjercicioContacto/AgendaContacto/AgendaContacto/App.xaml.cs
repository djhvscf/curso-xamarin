using AgendaContacto.DataAccess;
using AgendaContacto.DataAccess.Repositorios;
using AgendaContacto.DataAccess.Servicios;
using AgendaContacto.ViewModel;
using AgendaContacto.Views;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace AgendaContacto
{
    public partial class App : Application
    {
        public static IContainer Container;
        static readonly ContainerBuilder builder = new ContainerBuilder();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
            DependencyResolver.ResolveUsing(type => Container.IsRegistered(type) ? Container.Resolve(type) : null);
        }

        public static void RegisterType<T>() where T : class
        {
            builder.RegisterType<T>();
        }

        public static void RegisterType<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>().As<TInterface>();
        }

        public static void BuildContainer()
        {
            RegisterSharedTypes();
            Container = builder.Build();
        }

        private static void RegisterSharedTypes()
        {
            builder.RegisterType<ContactoRepository>().As<IContactoRepository>();
            builder.RegisterType<ContactoService>().As<IContactoService>();
            builder.RegisterType<DatabaseHelper>().As<IDatabaseHelper>();

            var assembly = typeof(BaseViewModel).GetTypeInfo().Assembly;
            var viewModelTypes = assembly.GetLoadableTypes()
                .Where(x => x.IsAssignableTo<BaseViewModel>() && x != typeof(BaseViewModel));
            foreach (var type in viewModelTypes)
            {
                builder.RegisterType(type);
            }
        }
    }
}
