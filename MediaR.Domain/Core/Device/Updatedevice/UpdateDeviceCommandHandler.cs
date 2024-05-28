using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;

namespace MediaR.Domain.Core.Device.Updatedevice;

public class UpdateDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<UpdateDeviceCommand, string>
{
    public async Task<string> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var device = request.DeviceUpdate.Adapt<DeviceModel>();
            device.Id = request.Id;
            _deviceRepository.Update(request.Id, device);
            _deviceRepository.Save();
            return "Update Succsec !!";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}