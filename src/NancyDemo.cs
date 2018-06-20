using Nancy;

namespace AspNetSelfHostService
{
    public class NancyDemo : NancyModule
    {
        public NancyDemo()
        {
            Get["/nancy/demo"] = parameters => new string[] { "Hello from Nancy :)" };
        }
    }
}
