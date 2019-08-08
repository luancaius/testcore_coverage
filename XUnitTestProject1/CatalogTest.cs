using ClassLibrary1.Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class CatalogTest
    {
        [Fact]
        public void Catalog_domain()
        {
            var id = 1;
            var title = "Test1";

            var catalog = new Catalog(id, title, null);
            Assert.Equal(title, catalog.Title);
            Assert.Equal(id, catalog.Id);
            Assert.Equal(new List<CatalogItem>(), catalog.Items);
        }

        [Fact]
        public void CatalogItem_domain()
        {
            var id = 1;
            var title = "Test1";

            var catalogItem = new CatalogItem(id, title);
            Assert.Equal(title, catalogItem.Title);
            Assert.Equal(id, catalogItem.Id);
        }
    }
}
