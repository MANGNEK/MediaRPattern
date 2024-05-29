using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.CreateDevice;

public class CreateDeviceHandler(IDevice _deviceRepository) : IRequestHandler<CreateDeviceCommand, Result>
{
    public async Task<Result> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
    {
        _deviceRepository.Insert(request.DeviceRequest.Adapt<DeviceModel>());
        _deviceRepository.Save();
        return Result.Ok("Save Success");
    }
}