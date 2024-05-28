using Mapster;
using MediaR.Domain.IRepository;
using MediatR;

namespace MediaR.Domain.Core.Device.DeleteDevice;

public class DeleteDeviceCommandHandler(IDevice _deviceRepository) : IRequestHandler<DeleteDeviceCommand, string>
{
    public async Task<string> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
    {
        try
        {
            _deviceRepository.Delete(request.IdDevice);
            _deviceRepository.Save();
            return "Delete Ok !!!";
        }
        catch (Exception ex)
        {
            return "Delete Not OK !!!";
        }
    }
}