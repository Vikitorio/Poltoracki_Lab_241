using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT
{
    enum Subject {None ,Math, Fisics ,History, Biology, English}
    class Teacher{
        private Human _humanData;
        private Subject _subject;
        
        private int _salary;


        public Teacher(){
            this._subject = Subject.None;
            this._salary = 6500;
            this._humanData = new Human();
        }
        public Teacher(Human human,Subject subject, int salary ){
            this._humanData = human;
            this._salary = salary;
            this._subject = subject;
        }
        public  void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public  string dataToStr(){
            string str;
            str = "Subject: " + _subject.ToString() +"\n" + "Salary" + _salary +"\n" + "Person Data:" + _humanData.dataToStr();
            return str;
        }
        public string Name{
            get{return _humanData.Name;}
            set{_humanData.Name = value;}
        }
          public int Age{
            get{return _humanData.Age;}
            set{_humanData.Age = value;}
        }
        public  Subject  SubjectsT{
            get{return _subject;}
            set{_subject = value;}
        }
        public  Human  HumanData{
            get{return _humanData;}
            set{_humanData = value; }
        }
        public  int  salary{
            get{return _salary;}
            set{_salary = value; }
        }
    }
}