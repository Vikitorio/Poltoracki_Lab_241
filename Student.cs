using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @HumanT{
    
    class Student:Human{
        private int _admissionYear;
        private List<Subject> _subjectSet;
        private List<List<string>> _grades;

        public Student(){
            this._admissionYear = 2021;
        }
         public Student(int admissionYear){
            this._admissionYear = admissionYear;
        }

        public  string dataToStr(){
            
            string str;
            str = base.dataToStr()+ "\n" + "Subject: " + _admissionYear.ToString() +"\n"  + "Person Data:";
            return str;
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
