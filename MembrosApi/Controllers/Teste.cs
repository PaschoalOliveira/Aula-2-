namespace MembrosApi.Controllers
{
    public class Teste
    {
        List<string>  harryPotter = new List<string>()
        {
            "Harry",
            "Hermione",
            "Rony"
        };

        List<string> querryAllPersons = from persons in harryPotter
                                        where persons == "Harry"
                                        select persons;
        
    }
}