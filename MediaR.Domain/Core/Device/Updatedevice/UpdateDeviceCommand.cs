using MediaR.Domain.DTO;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.Updatedevice;

public class UpdateDeviceCommand(string id, DeviceDTO device) : IRequest<Result>
{
    public string Id { get; set; } = id;
    public DeviceDTO DeviceUpdate { get; set; } = device;
}