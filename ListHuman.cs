using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace @HumanT
{
    class listHuman
    {
        private List<Human> listHumans;

        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void addNewHuman(Human human)
        {
            listHumans.Add(human);
        }
        public void AddHuman(Human a){
            listHumans.Add(a);
        }
        public void printHumans()
        {
            for (int i = 0; i < listHumans.Count(); i++){
                listHumans[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name){
            for(int i = 0 ;i < listHumans.Count();i++){
                if(listHumans[i].Name == name){
                    listHumans[i].printInfo();
                }

            }
        }
            public void changeObjByName(string name){
            for(int i = 0 ;i < listHumans.Count();i++){
                if(listHumans[i].Name == name){
                    listHumans[i].changeInfo();
                }

            }
        }

        public string showListStr()
        {
            string listData = "";
            for (int i = 0; i < listHumans.Count(); i++)
                listData += listHumans[i].dataToStr();
            return listData;
        }
          public void WriteToJson(string fileLink,List<Human> list){
  
            string JsonData = JsonConvert.SerializeObject(list);
            File.WriteAllText(fileLink, JsonData);
            
        }

        public List<Human> List{
            get{return listHumans;}
            set{this.listHumans= value;}
        }
        }
        
    }

