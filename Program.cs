using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @HumanT
{
    
  
    class Program
    {   
        static void Main(string[] args)
        {
            string JsonFilePath = "text.json";
            listHuman TempList = new listHuman();
            Human firstHuman =  new Human();
            Human secondHuman =  new Human("Светлана","Карбишева" ,44, new AdressHuman("Ukraine", "cherson", "Stepana Banderu ",23));
            Human thirdHuman =  new Human("Алина","Григорова" ,21, new AdressHuman("Ukraine", "Kiev", "Skoropadskogo",3));
            Human fourthHuman =  new Human("Лиза","Чернявська" ,19 , new AdressHuman("Ukraine", "Kremenchuk", "Lesi Ukrainku ",17));
            TempList.AddHuman(firstHuman);
            TempList.AddHuman(secondHuman);
            TempList.AddHuman(thirdHuman);
            TempList.AddHuman(fourthHuman);

            int tempChoose = 1;
            Console.WriteLine("Текуший лист : ");
            TempList.printHumans();
            while(tempChoose != 0){
                Console.WriteLine("Виберите действие  : ");
                Console.WriteLine("0 - Завершити виконання");
                Console.WriteLine("1 - Распечатать весь Лист");
                Console.WriteLine("2 - Разпечатать элемент по имени");
                Console.WriteLine("3 - Изменить элемент по имени");
                Console.WriteLine("4 - write obj to JsonFile");
                Console.WriteLine("5 - all list to json");
                Console.WriteLine("6 - sort By age low to high");
                Console.WriteLine("7 - sort By age hight to low");
                Console.WriteLine("8 - Read List from Json");
                tempChoose = Int32.Parse(Console.ReadLine());
                switch(tempChoose){
                    case 0:
                        break;
                    case 1:
                        TempList.printHumans();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите имя: ");
                        TempList.printObjByName(Console.ReadLine());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите имя: ");
                        TempList.changeObjByName(Console.ReadLine());
                        TempList.printHumans();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Введите id: ");
                         List<Human> tempL = TempList.List;
                         Human tempH = tempL[Int32.Parse(Console.ReadLine())];
                         tempH.WriteToJson(JsonFilePath);
                        TempList.printHumans();
                        Console.ReadLine();
                        break;
                     case 5:
                        TempList.WriteToJson(JsonFilePath);
                        TempList.printHumans();
                        Console.ReadLine();
                        break;  
                    case 6:
                        TempList.sortByAgeLowToHigh();
                        TempList.printHumans();
                        Console.ReadLine();
                        break;  
                    case 7:
                        TempList.sortByAgeHightToLow();
                        TempList.printHumans();
                        Console.ReadLine();
                        break; 
                    case 8:
                        TempList.readFromJson(JsonFilePath);
                        TempList.printHumans();
                        Console.ReadLine();
                        break;  
                }
            }
            Console.ReadLine();


        }
    }
}
