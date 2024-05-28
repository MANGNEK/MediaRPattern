using MediatR;

namespace MediaR.Domain.Core.Device.DeleteDevice;

public class DeleteDeviceCommand(string id) : IRequest<string>
{
    public string IdDevice { get; set; } = id;
}