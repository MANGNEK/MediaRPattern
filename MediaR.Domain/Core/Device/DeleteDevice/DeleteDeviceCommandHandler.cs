using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Response;
using MediatR;

namespace MediaR.Domain.Core.Device.DeleteDevice;

public class DeleteDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<DeleteDeviceCommand, Result>
{
    public async Task<Result> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
    {
        _deviceRepository.Delete(request.IdDevice);
        _deviceRepository.Save();
        return Result.Ok("Delete Success !!");
    }
}