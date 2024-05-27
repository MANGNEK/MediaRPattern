using MediaR.Domain.DTO;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceCommand(DeviceDTO device) : IRequest<int>
{
    public DeviceDTO DeviceRequest { get; set; } = device;
}