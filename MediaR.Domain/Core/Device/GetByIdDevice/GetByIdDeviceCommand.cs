using MediaR.Domain.DTO;
using MediatR;

namespace MediaR.Domain.Core.Device.GetByIdDevice;

public class GetByIdDeviceCommand(string id) : IRequest<DeviceReponse>
{
    public string Iddevice { get; set; } = id;
}