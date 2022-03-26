using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BIgSchool.ViewModels
{
    public class FutureDate:ValidationAttribute
    {
        public override bool IsValid(object value) // hoàn thành đến trang 52
        {
            DateTime dateTime;
            var isvalid = DateTime.TryParseExact(Convert.ToString(value),
                 "dd/M/yyyy",
                 CultureInfo.CurrentCulture, //CurrentCulturelà đại diện .NET của ngôn ngữ người dùng mặc định của hệ thống. Điều này kiểm soát định dạng số và ngày mặc định và tương tự. //Lớp CultureInfo cung cấp thông tin về văn hóa cụ thể, chẳng hạn như ngôn ngữ, ngôn ngữ con, quốc gia  khu vực, lịch và các quy ước liên quan đến một nền văn hóa cụ thể.
                 DateTimeStyles.None,
                 out dateTime);
            return (isvalid && dateTime > DateTime.Now);


        }
    }
}