using ClassLibrary2;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Product_domain()
        {
            var id = 1;
            var title = "Test1";

            var product = new Product(id, title);
            Assert.Equal(title, product.Title);
            Assert.Equal(id, product.Id);
        }
    }
}
