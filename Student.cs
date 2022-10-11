using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT{
    
    class Student{
        private Human _humanData;
        private int _admissionYear;
        private List<Subject> _subjectSet;
        private List<List<string>> _grades;

        public Student(){
            this._humanData = new Human();
            this._admissionYear = 2021;
        }
         public Student(Human human, int admissionYear){
            this._humanData = human;
            this._admissionYear = admissionYear;
        }

         public  void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public  string dataToStr(){
            string str;
            str = "Subject: " + _admissionYear.ToString() +"\n"  + "Person Data:" + _humanData.dataToStr();
            return str;
        }

          public  Human  HumanData{
            get{return _humanData;}
            set{_humanData = value; }
        }
        public string Name{
            get{return _humanData.Name;}
            set{_humanData.Name = value;}
        }
          public int Age{
            get{return _humanData.Age;}
            set{_humanData.Age = value;}
        }
        public int AdmissionYear {
            get{return this._admissionYear;}
            set{this._admissionYear = value;}
        }
        public List<Subject> Subjects{
            get{return this._subjectSet;}
            set{this._subjectSet = value;}
        }
        public List<List<string>> Grades{
            get{return this._grades;}
            set{this._grades = value;}
        }
        
    }
}
