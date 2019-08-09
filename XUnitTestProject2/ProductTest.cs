using ClassLibrary2;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class ProductTest
    {
        [Fact]
        public void Product_domain()
        {
            var id = 1;
            var catalog = new Product(id);
            Assert.Equal(id, catalog.Id);
        }

        [Fact]
        public void Product_domain2()
        {
            var title = "Something";
            var catalog = new Product(title);
            Assert.Equal(title, catalog.Title);
        }
    }
}
