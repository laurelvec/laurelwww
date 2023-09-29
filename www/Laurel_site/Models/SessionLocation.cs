namespace Laurel_site.Models;

public class SessionLocation
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Uri { get; set; } = string.Empty;

    public SessionLocation()
    {
        Id = Guid.NewGuid().ToString();
    }
}
