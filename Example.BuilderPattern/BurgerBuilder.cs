using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BuilderPattern
{
    public class BurgerBuilder : IBuilder<Burger>
    {
        private Burger _burguer = new Burger();

        public Burger Build() => _burguer;

        public BurgerBuilder WithPatties(int num)
        {
            _burguer.NumPatties = num;
            return this;
        }

        public BurgerBuilder WithCheese()
        {
            _burguer.Cheese = true;
            return this;
        }
        public BurgerBuilder WithBacon()
        {
            _burguer.Bacon = true;
            return this;
        }
    }
}
