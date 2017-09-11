using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace ApplicationServicesTests
{
    internal class ApplicationServiceFixture : Fixture
    {
        public ApplicationServiceFixture()
        {
            this.Customize(new AutoMoqCustomization());
        }
    }
}
