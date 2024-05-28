using Mapster;
using MediaR.Domain.DTO;
using MediaR.Domain.IRepository;
using MediatR;

namespace MediaR.Domain.Core.Device.GetByIdDevice;

public class GetByIdDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<GetByIdDeviceCommand, DeviceReponse>
{
    public async Task<DeviceReponse> Handle(GetByIdDeviceCommand request, CancellationToken cancellationToken)
    {
        var device = await _deviceRepository.GetById(request.Iddevice);
        if (device == null) return new DeviceReponse();
        return device.Adapt<DeviceReponse>();
    }
}