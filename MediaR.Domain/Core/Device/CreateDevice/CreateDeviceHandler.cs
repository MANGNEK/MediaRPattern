using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceHandler : IRequestHandler<CreateDeviceCommand, int>
{
    private readonly IDevice _device;

    public CreateDeviceHandler(IDevice device) => _device = device;

    public async Task<int> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
    {
        _device.Insert(request.DeviceRequest.Adapt<DeviceModel>());
        _device.Save();
        return 1;
    }
}