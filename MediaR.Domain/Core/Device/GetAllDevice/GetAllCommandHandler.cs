using Mapster;
using MediaR.Domain.DTO;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediaR.Domain.Response;
using MediatR;
using MongoDB.Driver;

namespace MediaR.Domain.Core.Device.GetAllDevice;

public class GetAllCommandHandler(IDevice _deviceRepository) : IRequestHandler<GetAllDeviceConmand, Result>
{
    public async Task<Result> Handle(GetAllDeviceConmand request, CancellationToken cancellationToken)
    {
        var listDevice = await _deviceRepository.GetAllAsync();
        if (listDevice.Any() != true) return Result.Fail("Get list device fail !!!");
        return Result.Ok(listDevice);
    }
}