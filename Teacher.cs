using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT
{
    enum Subject {None ,Math, Fisics ,History, Biology, English}
    class Teacher:Human{
        private Subject _subject;
        
        private int _salary;


        public Teacher(){
            this._subject = Subject.None;
            this._salary = 6500;
        }
        public Teacher(Human human,Subject subject, int salary ){
            this._salary = salary;
            this._subject = subject;
        }
        public  void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public  string dataToStr(){
            string str;
            str = base.dataToStr()+ "\n"+"Subject: " + _subject.ToString() +"\n" + "Salary" + _salary +"\n" + "Person Data:" ;
            return str;
        }
        public  Subject  SubjectsT{
            get{return _subject;}
            set{_subject = value;}
        }
        public  int  salary{
            get{return _salary;}
            set{_salary = value; }
        }
    }
}