using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceHandler(IDevice _deviceRepository) : IRequestHandler<CreateDeviceCommand, int>
{
    public async Task<int> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
    {
        _deviceRepository.Insert(request.DeviceRequest.Adapt<DeviceModel>());
        _deviceRepository.Save();
        return 1;
    }
}