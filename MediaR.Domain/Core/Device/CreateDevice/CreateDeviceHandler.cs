using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceHandler : IRequestHandler<CreateDeviceRequest, int>
{
    private readonly IDevice _device;

    public CreateDeviceHandler(IDevice device) => _device = device;

    public async Task<int> Handle(CreateDeviceRequest request, CancellationToken cancellationToken)
    {
        _device.Insert(request.DeviceRequest.Adapt<DeviceModel>());
        return 1;
    }
}