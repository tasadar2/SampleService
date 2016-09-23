using Topshelf;

namespace SampleService
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HostFactory.Run(svc =>
            {
                svc.Service<SampleService>(s =>
                {
                    s.ConstructUsing(name => new SampleService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                svc.RunAsLocalSystem();

                svc.SetDescription("SampleService");
                svc.SetDisplayName("SampleService");
                svc.SetServiceName("SampleService");
            });
        }
    }
}
