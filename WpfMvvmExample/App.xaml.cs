namespace WpfMvvmExample
{
  using Autofac;
  using System;
  using System.Reflection;
  using System.Windows;

  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private void Application_Startup(object sender, StartupEventArgs e)
    {
      ContainerBuilder builder = new Autofac.ContainerBuilder();
      builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
        .InNamespace("WpfMvvmExample.ViewModel")
        .SingleInstance();
        
      var container = builder.Build();

      var locator = new Locator(property => container.Resolve(Type.GetType($"WpfMvvmExample.ViewModel.{property}")));

      this.Resources["Locator"] = locator;
    }
  }
}
