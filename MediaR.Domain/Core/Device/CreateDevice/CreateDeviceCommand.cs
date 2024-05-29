using MediaR.Domain.DTO;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceCommand(DeviceDTO device) : IRequest<Result>
{
    public DeviceDTO DeviceRequest { get; set; } = device;
}