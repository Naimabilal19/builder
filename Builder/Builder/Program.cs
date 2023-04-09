using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car_All
    {
        public string name { set; get; }
        public string corpus { set; get; }
        public string engine { set; get; }
        public string koleso { set; get; }
        public string KPP { set; get; }

        public Car_All() { }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nCorpus: {corpus}\nEngene: {engine}\nKoleso: {koleso}\nKPP: {KPP}\n");
        }

        public override string ToString()
        {
            return $"Name: {name}\nCorpus: {corpus}\nEngene: {engine}\nKoleso: {koleso}\nKPP: {KPP}\n";
        }
    }
    public interface BuilderCar
    {
        void name();
        void corpus();
        void engine();
        void koleso();
        void KPP();
        Car_All GetCar();

    }
    public class Daewoo : BuilderCar
    {
        private Car_All car_All = new Car_All();

        public void name()
        {
            car_All.name = "Daewoo Lanos";
        }
        public void corpus()
        {
            car_All.corpus = "Sedan";
        }
        public void engine()
        {
            car_All.engine = "1.5";
        }
        public void koleso()
        {
            car_All.koleso = "1.4";
        }
        public void KPP()
        {
            car_All.KPP = "5 manual";
        }
        public Car_All GetCar()
        {
            return car_All;
        }

    }
    public class UAZ : BuilderCar
    {
        private Car_All car_All = new Car_All();

        public void name()
        {

            car_All.name = "UAZ";
        }
        public void corpus()
        {
            car_All.corpus = "Грузовик";
        }
        public void engine()
        {
            car_All.engine = "2.5";
        }
        public void koleso()
        {
            car_All.koleso = "2R";
        }
        public void KPP()
        {
            car_All.KPP = "5 ступенчатая";
        }
        public Car_All GetCar()
        {
            return car_All;
        }
    }
    public class Ford : BuilderCar
    {
        private Car_All car_All = new Car_All();

        public void name()
        {

            car_All.name = "Ford";
        }
        public void corpus()
        {
            car_All.corpus = "Седан";
        }
        public void engine()
        {
            car_All.engine = "1.9";
        }
        public void koleso()
        {
            car_All.koleso = "1.8R";
        }
        public void KPP()
        {
            car_All.KPP = "6 ступенчатая";
        }
        public Car_All GetCar()
        {
            return car_All;
        }
    }
    public class Shop_Director
    {
        private BuilderCar Builder_Car;

        public void Car()
        {
            Builder_Car = new Daewoo();
            Builder_Car = new UAZ();
            Builder_Car = new Ford();
        }
        public void CarBuild()
        {
            Builder_Car.name();
            Builder_Car.corpus();
            Builder_Car.engine();
            Builder_Car.koleso();
            Builder_Car.KPP();
        }
        public BuilderCar GetCar()
        {
            return Builder_Car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Shop_Director();
            director.Car();
            director.CarBuild();
            var build = director.GetCar();
            Car_All car = build.GetCar();
            Console.WriteLine(car);
        }
    }
}
