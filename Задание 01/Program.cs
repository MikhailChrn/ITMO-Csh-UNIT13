using System;

namespace Задание_01
{
    //Задан класс Building, который описывает здание. Класс содержит следующие элементы:
    //-адрес здания;
    //-длина здания;
    //-ширина здания;
    //-высота здания.
    
    //В классе Building нужно реализовать следующие методы:
    //-конструктор с 4 параметрами;
    //-свойства get/set для доступа к полям класса;
    //-метод Print(), который выводит информацию о здании.

    //-Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:
    //конструктор с 5 параметрами – реализует вызов конструктора базового класса;
    //свойство get/set доступа к внутреннему полю класса;
    //метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
    //Класс MultiBuilding сделать таким, что не может быть унаследован.

    public class Building // Базовый класс Building, содержит информацию о здании  
    {
        //Поля класса - объявленные как protected - видимы в производных классах, и невидимы из экземпляра класса
        protected string adress;
        protected int lengh;
        protected int width;
        protected int heigh;
        
        public Building(string _adressB, int _lenghtB, int _widthB, int _heightB)
        //Конструктор родительского класса с 4 параметрами
        {
            this.AdressB = _adressB;
            this.LenghtB = _lenghtB;
            this.WidthB = _widthB;
            this.HeightB = _heightB;
            adress = AdressB;
            lengh = LenghtB;
            width = WidthB;
            heigh = HeightB;
        }

        //Свойства доступа к полям родительского класса
        public string AdressB
        {
            get { return adress; }
            set { adress = value; }
        }
        public int LenghtB
        {
            get { return lengh; }
            set { lengh = value; }
        }
        public int WidthB
        {
            get { return width; }
            set { width = value; }
        }
        public int HeightB
        {
            get { return heigh; }
            set { heigh = value; }
        }
        
        public void Print() //Родительский метод Print() - вывести значения полей на экран
        {
            Console.WriteLine(adress);
            Console.WriteLine(lengh);
            Console.WriteLine(width);
            Console.WriteLine(heigh);
        }
    }
        
    sealed public class MultiBuilding: Building //Наследуемый класс многоэтажные здания (наследует возможности класса Building)
    {

        private byte nof; //Внутреннее поле наследуемого  класса - количество этажей
          
        public MultiBuilding(string _adressB, int _lenghtB, int _widthB, int _heightB, byte _numberOfFloor)
            //Конструктор с 5 параметрами
            :base(_adressB, _lenghtB, _widthB, _heightB)
        {
            this.NumberOfFloor = _numberOfFloor; //обращение к внутреннему поля наследуемого класса
            nof = NumberOfFloor;
        }

        public byte NumberOfFloor //Свойство для доступа к полю наследуемого класса
        {
            get { return nof; }
            set { nof = value; }
        }

        public new void Print() //Печать полей наследуемого класса 
        {
            Console.WriteLine("Многоэтажное здание");
            base.Print(); // вызвать метод Print() родительского класса
            Console.WriteLine(nof); // выводит 5-й параметр наследуемого класса

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем экземпляр родительского класса Building
            Building B1 = new Building("Samara 1", 10000, 10000, 4000);
            Building B2 = new Building("Samara 3", 5000, 5000, 2500);

            //Объявляем экземпляр неаследуемого класса MultiBuilding
            MultiBuilding MB1 = new MultiBuilding("Samara 2", 30000, 30000, 50000, 20);
            MultiBuilding MB2 = new MultiBuilding("Samara 4", 10000, 10000, 30000, 10);

            //Вызов методов экземпляров классов Building и MultiBuilding
            B1.Print(); B2.Print();
            Console.WriteLine();
            MB1.Print(); MB2.Print();
            Console.ReadKey();

        }
    }

}
