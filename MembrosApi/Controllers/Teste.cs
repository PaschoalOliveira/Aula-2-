using System.Collections.Generic;
using System.Linq;

namespace MembrosApi.Controllers
{
    public class Teste
    {
        private static List<string>  harryPotter = new List<string>
        {
            "Harry",
            "Hermione",
            "Rony"
        };
        
        IEnumerable<string> querryAllPersons = from persons in harryPotter
                                        where persons == "Harry"
                                        select persons;
    }
}
