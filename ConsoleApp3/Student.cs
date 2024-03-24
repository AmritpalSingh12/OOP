using BusinessAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
        private string _firtname;
        private string _lastname;
        private int _age;
        private int _studentrollnumber;



        public Student()
        {
            //default contructor 
            _firtname = string.Empty;
            _lastname = string.Empty;
            _age = -1;

        }


        public Student(string fistname, string lastname, int age, int rollnumber)
        {
            _firtname= fistname;
            _lastname= lastname;
            _age = age;
            _studentrollnumber = rollnumber;
        }

        public Student(int name, string phonenumber, int room, int building)
        {

        }

        public void SetStudentinfo(string firtname , string lastname, int age)
        {
            this._firtname = firtname;
            this._lastname = lastname;
            this._age = age;
            Random r = new Random();
            this._studentrollnumber = r.Next(1, 20);
        }

        public string GetFirtname() 
        {
            if (this._firtname != null && this._firtname != string.Empty)
            {
                return this._firtname;
            }
            else
            {
                return "Please set the firt name";
            }
        }
        public string GetLastname()
        {
            if (this._lastname != null && this._lastname != string.Empty)
            {
                return this._lastname;
            }
            else
            {
                return "Please set the last name";
            }
        }

        public int GetAge() 
        {
            int age = 12;
            double number = 1.22;

            if (this._age > 0)
            {
                return this._age;
            }
            else
            {
                return 0;
            }
        }

        public void GetStudentId()
        {
            StudentBAL obj = new StudentBAL();
        }


    }

   

}
