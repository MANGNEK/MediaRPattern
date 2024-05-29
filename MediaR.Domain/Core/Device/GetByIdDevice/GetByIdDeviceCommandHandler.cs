using Mapster;
using MediaR.Domain.DTO;
using MediaR.Domain.IRepository;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.GetByIdDevice;

public class GetByIdDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<GetByIdDeviceCommand, Result>
{
    public async Task<Result> Handle(GetByIdDeviceCommand request, CancellationToken cancellationToken)
    {
        var device = await _deviceRepository.GetById(request.Iddevice);
        if (device == null) return Result.Fail("Can not get device");
        return Result.Ok(device);
    }
}