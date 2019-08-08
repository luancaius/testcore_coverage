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

            var product = new Product(id, title);
            var catalog = new Catalog(id, title, null, product);
            Assert.NotNull(catalog.MainProduct);
        }
    }
}
