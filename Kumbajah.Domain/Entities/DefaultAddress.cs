using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class DefaultAddress : AbstractAddress
    {
        public virtual IEnumerable<User> Users { get; }

        public DefaultAddress() { }

        public DefaultAddress(IEnumerable<User> users)
        {
            Users = users;
        }
    }
}
