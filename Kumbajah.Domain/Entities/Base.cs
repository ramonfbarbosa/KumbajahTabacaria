using System;
using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }
        internal List<string> _errors { get; set; }
        public IReadOnlyCollection<string> Errors => _errors;

        public abstract bool Validate();
    }
}
