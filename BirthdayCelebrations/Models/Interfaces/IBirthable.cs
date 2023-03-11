using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IBirthable
    {
        List<string> Birthdates { get;}
        string Birthdate { get;}

        void AddBirthdate();
    }
}
