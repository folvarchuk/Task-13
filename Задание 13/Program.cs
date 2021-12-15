using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:
        - адрес здания;
        - длина здания;
        - ширина здания;
        - высота здания.
    
    В классе Building нужно реализовать следующие методы:
        - конструктор с 4 параметрами;
        - свойства get/set для доступа к полям класса;
        - метод Print(), который выводит информацию о здании.
    
    Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
        - конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        - свойство get/set доступа к внутреннему полю класса;
        - метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
    
    Класс MultiBuilding сделать таким, что не может быть унаследован.*/
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Ленина, 1", 15000, 10000, 25000);
            MultiBuilding multiBuilding = new MultiBuilding("ул. Ленина, 1", 15000, 10000, 25000, 15);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.Write("Здание находится по адресу: {0}. Длина здания равна {1} мм, ширина здания равна {2} мм, его высота равна {3} мм. ", Address, Length, Width, Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floors { get; set; }
        public MultiBuilding(string address, double length, double width, double height, int floors)
            : base(address, length, width, height)
        {
            Floors = floors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("В здании {0} этажей.", Floors);
        }
    }
}
