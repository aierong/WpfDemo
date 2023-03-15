using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;



namespace WpfApp.ViewModels
{
    public class StudentService
    {

        //public StudentService()
        //{
        //}



        public List<Student> GetStudentList ()
        {
            Student liang = new Student();
            liang.Age = "18";
            liang.Name = "梁丘";
            liang.Birthday = "1990-02-03";
            liang.Country = "中国";

            Student zuo = new Student();
            zuo.Age = "22";
            zuo.Name = "左丘";
            zuo.Birthday = "1992-02-03";
            zuo.Country = "中国";

            Student diwu = new Student();
            diwu.Age = "32";
            diwu.Name = "第五言";
            diwu.Birthday = "1982-11-03";
            diwu.Country = "中国";

            Student yang = new Student();
            yang.Age = "12";
            yang.Name = "羊舌微";
            yang.Birthday = "2002-11-13";
            yang.Country = "中国";

            List<Student> personList = new List<Student>();
            personList.Add( liang );
            personList.Add( zuo );
            personList.Add( diwu );
            personList.Add( yang );

            return personList;
        }

    }
}
