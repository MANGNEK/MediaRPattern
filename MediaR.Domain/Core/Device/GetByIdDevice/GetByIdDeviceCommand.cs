using MediaR.Domain.DTO;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.GetByIdDevice;

public class GetByIdDeviceCommand(string id) : IRequest<Result>
{
    public string Iddevice { get; set; } = id;
}