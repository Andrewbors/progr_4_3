using System;

namespace ClassLibrary
{
    public class Currency
    {
        protected String Name;
        protected double ExRate;

        public Currency() { }

        public Currency(String Name)
        {
            this.Name = Name;
        }

        public Currency(String Name, double ExRate)
        {
            this.Name = Name;
            this.ExRate = ExRate;
        }

        public String getName() { return Name; }
        public double getExRate() { return ExRate; }

        public void setName(String name) { Name = name; }
        public void setExRate(double exRate) { ExRate = exRate; }

    }
}
