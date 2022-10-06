using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace @HumanT
{
    class listTeacher
    {
        private List<Teacher> _listTeachers;

        public listTeacher()
        {
            _listTeachers = new List<Teacher>();
        }
        public void addNewTeacher(Teacher teacher)
        {
             _listTeachers.Add(teacher);
        }
        public void AddTeacher(Teacher a){
             _listTeachers.Add(a);
        }
        public void printTeachers()
        {
            for (int i = 0; i <  _listTeachers.Count(); i++){
                 _listTeachers[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name){
            for(int i = 0 ;i < _listTeachers.Count();i++){
                if( _listTeachers[i].HumanData.Name == name){
                    _listTeachers[i].printInfo();
                }

            }
        }
        /*
            public void changeObjByName(string name){
            for(int i = 0 ;i < _listTeachers.Count();i++){
                if(_listTeachers[i].HumanData.Name == name){
                    _listTeachers[i].changeInfo();
                }

            }
        }
        */

        public string showListStr()
        {
            string listData = "";
            for (int i = 0; i < _listTeachers.Count(); i++)
                listData += _listTeachers[i].dataToStr();
            return listData;
        }
          public void WriteToJson(string fileLink,List<Human> list){
  
            string JsonData = JsonConvert.SerializeObject(list);
            File.WriteAllText(fileLink, JsonData);
            
        }

        public List<Teacher> List{
            get{return _listTeachers;}
            set{this._listTeachers= value;}
        }
        }
        
    }

