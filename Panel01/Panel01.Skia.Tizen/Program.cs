using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Panel01.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Panel01.App(), args);
            host.Run();
        }
    }
}
