using System;
using System.Collections.Generic;

namespace Exception
{

    public class Item
    {
        private int _code;
        private string _name;
        private string _color;
        private double _price;

        public int Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Color { get => _color; set => _color = value; }
        public double Price { get => _price; set => _price = value; }

        public Item(int code, string name, string color, double price)
        {
            Code = code;
            _name = name;
            _color = color;
            _price = price;
        }
    }
}