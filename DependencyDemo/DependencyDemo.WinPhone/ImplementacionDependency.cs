[assembly:Xamarin.Forms.Dependency(typeof(DependencyDemo.WinPhone.ImplementacionDependency))]
namespace DependencyDemo.WinPhone
{
    public class ImplementacionDependency:IDependencyDemo
    {
        public string ObtenerMensaje()
        {
            return "Hola, Estoy en WinPhone";
        }
    }
}