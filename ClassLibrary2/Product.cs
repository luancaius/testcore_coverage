﻿using System;

namespace ClassLibrary2
{
    public class Product
    {
        public Product(int id)
        {
            Id = id;
        }

        public Product(string title)
        {
            Title = title;
        }

        public Product(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; }
        public string Title { get; }
    }
}
