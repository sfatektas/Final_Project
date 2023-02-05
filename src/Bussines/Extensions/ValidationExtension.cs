using MSS_NewsWeb.Common.Interfaces;
using FluentValidation.Results;

namespace MSS_NewsWeb.Bussines.Extensions
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
