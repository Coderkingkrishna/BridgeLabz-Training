using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public static class ValidationHelper
{
    public static bool Validate(object obj)
    {
        var context = new ValidationContext(obj);
        var results = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(obj, context, results, true);

        if (!isValid)
        {
            foreach (var error in results)
                Console.WriteLine(error.ErrorMessage);
        }

        return isValid;
    }
}
