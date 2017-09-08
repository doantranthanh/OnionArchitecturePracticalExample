using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace UITests
{
    internal class BookAppWebCustomization : CompositeCustomization
    {
        public BookAppWebCustomization() : base(new AutoMoqCustomization(), new MvcCustomization())
        {

        }
    }
}
