using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //Birden çok yapıda ortak fonksiyonlar gerektiğinde temiz kod için interfacede-
        //fonksiyonları barındırırız.

        //If a lot of structure require same functions,we can use interface for clean code.
        void ApplyForMask(Person person);

        List<Person> GetList();

         bool CheckPerson(Person person);
       
    }
}
