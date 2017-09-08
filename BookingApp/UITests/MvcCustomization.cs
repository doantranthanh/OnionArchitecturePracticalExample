using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Moq;
using Ploeh.AutoFixture;

namespace UITests
{
    internal class MvcCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<ControllerContext>(c => c.Without(x => x.DisplayMode));
        }
    }
}
