using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BIgSchool.ViewModels
{
    public class ValidTime: ValidationAttribute
    {
        public override bool IsValid(object value) // hoàn thành đến trang 52
        {
            DateTime dateTime;
            var isvalid = DateTime.TryParseExact(Convert.ToString(value),
                                                 "HH:mm",
                                                 CultureInfo.CurrentCulture,
                                                 DateTimeStyles.None,
                                                 out dateTime);
            return isvalid;


        }
    }
}