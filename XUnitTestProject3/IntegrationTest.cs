using ClassLibrary1.Domain;
using ClassLibrary2;
using System;
using Xunit;

namespace XUnitTestProject3
{
    public class IntegrationTest
    {
        [Fact]
        public void CatalogAndProduct_Test()
        {
            var id = 1;
            var title = "Test1";

            var catalog = new Catalog(id, title);
            Assert.Equal(title, catalog.Title);
            Assert.Equal(id, catalog.Id);
        }

        [Fact]
        public void CatalogAndProduct_Test2()
        {
            var id = 1;
            var title = "Test1";

            var catalog = new Product(id, title);
            Assert.Equal(title, catalog.Title);
            Assert.Equal(id, catalog.Id);
        }
    }
}
