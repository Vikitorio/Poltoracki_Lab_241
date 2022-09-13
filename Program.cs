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
                tempChoose = Int32.Parse(Console.ReadLine());
                switch(tempChoose){
                    case 1:
                        TempList.printHumans();
                        break;
                    case 2:
                        TempList.printObjByName(Console.ReadLine());
                        break;
                    case 3:
                        TempList.changeObjByName(Console.ReadLine());
                        TempList.printHumans();
                        break;
                }
            }
            Console.ReadLine();


        }
    }
}
