[assembly:Xamarin.Forms.Dependency(typeof(DependencyDemo.iOS.ImplementacionDependency))]
namespace DependencyDemo.iOS
{
    public class ImplementacionDependency:IDependencyDemo
    {
        public string ObtenerMensaje()
        {
            return "Hola, soy IOS";
        }
    }
}