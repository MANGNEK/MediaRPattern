using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.Updatedevice;

public class UpdateDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<UpdateDeviceCommand, Result>
{
    public async Task<Result> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
    {
            var device = request.DeviceUpdate.Adapt<DeviceModel>();
            device.Id = request.Id;
            _deviceRepository.Update(request.Id, device);
            _deviceRepository.Save();
            return Result.Ok();
    }
}