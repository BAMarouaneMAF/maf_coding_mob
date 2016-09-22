using System;

namespace FooBarQixKata
{
    public class FooBarQix
    {
        public string Convert(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "Foo,Bar";
            }
            if (value % 3 == 0)
            {
                return "Foo";
            }
            if (value % 5 == 0)
            {
                return "Bar";
            }
            throw new ArgumentException();
        }
    }
}
