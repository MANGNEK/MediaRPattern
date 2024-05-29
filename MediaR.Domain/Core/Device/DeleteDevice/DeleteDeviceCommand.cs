using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.DeleteDevice;

public class DeleteDeviceCommand(string id) : IRequest<Result>
{
    public string IdDevice { get; set; } = id;
}