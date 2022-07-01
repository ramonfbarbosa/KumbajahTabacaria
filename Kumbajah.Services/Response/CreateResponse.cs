using System;
using System.Collections.Generic;

namespace KumbajahTabacaria.Response
{
    public class CreateResponse<T> where T : class
    {
        public bool Success { get; }
        public int ResourceId { get; }
        public IReadOnlyList<string> Errors { get; }

        private CreateResponse(int resourceId, List<string> errors)
        {
            Success = errors.Count == 0;
            ResourceId = resourceId;
            Errors = errors.AsReadOnly();
        }

        public static CreateResponse<TEnt> Valid<TEnt>(int objId) where TEnt : class =>
            new(objId, new List<string>());

        public static CreateResponse<TEnt> Invalid<TEnt>(int objId, List<string> errors) where TEnt : class =>
            errors.Count != 0
                ? new CreateResponse<TEnt>(objId, errors)
                : throw new ArgumentException($"{nameof(errors)} não deveria estar vazio");
    }
}
