using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Validation_Assignment.Models;

namespace Validation_Assignment.Custom_Validations
{
        public class ValidDateOfJoin : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                DateTime doj = Convert.ToDateTime(value);
                return doj.Date <= DateTime.Today;
            }
        }
}