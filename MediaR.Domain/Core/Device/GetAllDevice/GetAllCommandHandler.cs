using Mapster;
using MediaR.Domain.DTO;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;

namespace MediaR.Domain.Core.Device.GetAllDevice;

public class GetAllCommandHandler(IDevice _deviceRepository) : IRequestHandler<GetAllDeviceConmand, List<DeviceReponse>>
{
    public async Task<List<DeviceReponse>> Handle(GetAllDeviceConmand request, CancellationToken cancellationToken)
    {
        var listDevice = await _deviceRepository.GetAllAsync();
        if (listDevice.Any() != true) return new List<DeviceReponse>();
        return listDevice.Adapt<List<DeviceReponse>>();
    }
}