using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT
{
    class Human
    {
        private string _name;
        private string _surname;
        private int _age;
        private AdressHuman _adress ;

        public Human()
        {
            this._name = "Виктор";
            this._surname = "Михальчевсикий";
            this._age = 18;
            this._adress = new AdressHuman();
        }
        public Human(string name, string surname, int age, AdressHuman adress)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._adress = adress;
        }

        public void changeInfo(){
            Console.WriteLine("Введите новое имя: ");
            this._name = Console.ReadLine();
            Console.WriteLine("Введите новую фамилию: ");
             this._surname = Console.ReadLine();
            Console.WriteLine("Введите новий возраст: ");
             this._age = Int32.Parse(Console.ReadLine());
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public string dataToStr()
        {
            string str;
            str = "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +_adress.adressToString();
            return str;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}