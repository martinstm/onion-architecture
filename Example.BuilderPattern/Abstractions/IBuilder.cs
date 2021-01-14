using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BuilderPattern
{
    public interface IBuilder<T> where T: class
    {
        T Build();
    }
}
