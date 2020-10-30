using Common;
using System.Collections.Generic;

namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        IReadOnlyCollection<Person> GetPeople();
    }
}
