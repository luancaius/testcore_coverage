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
            var catalog = new Catalog(id);
            Assert.Equal(id, catalog.Id);
        }

        [Fact]
        public void Catalog_domain2()
        {
            var title = "Something";
            var catalog = new Catalog(title);
            Assert.Equal(title, catalog.Title);
        }
    }
}
