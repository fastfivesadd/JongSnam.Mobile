﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JongSnam.Mobile.Validations
{
    public class IsNullOrEmptyRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = value as string;
            return !string.IsNullOrWhiteSpace(str);   
        }
    }
}
