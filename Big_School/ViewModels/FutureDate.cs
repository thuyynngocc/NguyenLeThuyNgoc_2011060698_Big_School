﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Big_School.ViewModels
{
    public class FutureDate:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dataTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dataTime);
            return isValid && dataTime > DateTime.Now;
        }
    }
}