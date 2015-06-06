using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class PatientItem
    {
        
        partial void FIO_Compute(ref string result)
        {
            // Присвоение результату значения нужного поля
            result = FirstName + " " + Name.ToUpper()[0] + "." + MidName.ToUpper()[0] + ".";

        }

        partial void Age_Compute(ref int result)
        {
            // Присвоение результату значения нужного поля
            DateTime nowDate = DateTime.Today;
            int age = nowDate.Year - BirthDate.Year;
            if (BirthDate > nowDate.AddYears(-age)) age--;
            result = age;

        }
    }
}
