using System;
using System.Collections.Generic;

namespace KumbajahTabacaria.Response
{
    public class CreateOrderResponse<T> where T : class
    {
        public bool Success { get; }
        public int ResourceId { get; }
        public IReadOnlyList<string> Errors { get; }

        private CreateOrderResponse(int resourceId, List<string> errors)
        {
            Success = errors.Count == 0;
            ResourceId = resourceId;
            Errors = errors.AsReadOnly();
        }

        public static CreateOrderResponse<TEnt> Valid<TEnt>(int customerId) where TEnt : class =>
            new CreateOrderResponse<TEnt>(customerId, new List<string>());

        public static CreateOrderResponse<TEnt> Invalid<TEnt>(int customerId, List<string> errors) where TEnt : class =>
            errors.Count != 0
                ? new CreateOrderResponse<TEnt>(customerId, errors)
                : throw new ArgumentException($"{nameof(errors)} não deveria estar vazio");
    }
}
