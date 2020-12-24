using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Brumano.Uno.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new Brumano.Uno.App(), args);
			host.Run();
		}
	}
}
