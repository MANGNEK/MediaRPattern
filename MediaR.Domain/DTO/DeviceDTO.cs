namespace MediaR.Domain.DTO;

public class DeviceDTO
{
    public string NameDevice { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Total { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class DeviceReponse
{
    public string Id { get; set; } = string.Empty;
    public string NameDevice { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Total { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}