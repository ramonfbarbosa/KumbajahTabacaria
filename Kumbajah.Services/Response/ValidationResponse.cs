using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;

namespace KumbajahTabacaria.Response
{
    public class ValidationResponse<T> where T : class
    {
        public ValidationResult Result { get; }
        public bool Success => Result.IsValid;
        public IReadOnlyCollection<string> Errors { get; }
        public T Entity { get; }

        private ValidationResponse(ValidationResult result, T entity)
        {
            Result = result;
            Errors = result.Errors
                .Select(x => x.ErrorMessage)
                .ToList()
                .AsReadOnly();
            Entity = entity;
        }

        public static ValidationResponse<T> Valid(ValidationResult result, T entity) =>
            result.IsValid
                ? new ValidationResponse<T>(result, entity)
                : throw new ArgumentException("Validation result should be valid!");

        public static ValidationResponse<T> Invalid(ValidationResult result) =>
            result.IsValid
                ? throw new ArgumentException("Validation result should be invalid!")
                : new ValidationResponse<T>(result, null);

    }
}
