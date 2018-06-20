using Topshelf;

namespace AspNetSelfHostService
{
    class Program
    {
        static void Main(string[] args)
        {
            StartTopshelf();
        }

        static void StartTopshelf()
        {
            HostFactory.Run(x =>
            {
                x.Service<WebServer>(s =>
                {
                    s.ConstructUsing(name => new WebServer());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("This is a Windows Service using Topshelf");
                x.SetDisplayName("Self Host Web API Service");
                x.SetServiceName("AspNetSelfHostService");
            });
        }
    }
}
