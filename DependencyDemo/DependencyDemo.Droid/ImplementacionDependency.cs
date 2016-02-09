[assembly: Xamarin.Forms.Dependency(typeof(DependencyDemo.Droid.ImplementacionDependency))]
namespace DependencyDemo.Droid
{
    public class ImplementacionDependency:IDependencyDemo
    {
        public string ObtenerMensaje()
        {
            return "Hola, Soy android";
        }
    }
}