using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Studying_Csharp
{
    public class TryDataAnnotations //: IValidatableObject
    {
        [Required(ErrorMessage = "缺少 Name")]
        //[Required]
        public string Name;

        [Range(30, 100)]
        public int Age;

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    int result = DateTime.Compare(this.StartDate, this.EndDate);
        //    if (result >= 0)
        //    {
        //        yield return new ValidationResult("start date must be less than the end date!",
        //                                          new[] { "ConfirmEmail" });
        //    }
        //}
    }
}
