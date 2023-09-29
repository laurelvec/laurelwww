

namespace Laurel_site.Models;

public class Session
{
    public string Id { get; set; }
    public DateTime SessionDtg { get; set; }   
    public SessionLocation Location { get; set; }
    public string ContactId  { get; set; }

    public Session()
    {
        Id = Guid.NewGuid().ToString();
    }
}
