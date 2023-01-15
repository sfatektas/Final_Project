using denemeBlazor.Common.Interfaces;
using FluentValidation.Results;

namespace denemeBlazor.Bussines.Extensions
{
    public static class ValidationExtension
    {
        public static List<ValidationError> GetValidationErrors(this ValidationResult result)
        {
            List<ValidationError> ValidationErrors = new List<ValidationError>();
            foreach (var error in result.Errors)
            {
                ValidationErrors.Add(new(error.ErrorCode , error.ErrorMessage));
            }
            return ValidationErrors;
        }
    }
}
