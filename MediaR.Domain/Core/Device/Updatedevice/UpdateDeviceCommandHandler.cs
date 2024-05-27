using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaR.Domain.Core.Device.Updatedevice;

public class UpdateDeviceCommandHandler : IRequestHandler<UpdateDeviceCommand, string>
{
    private readonly IDevice _device;

    public UpdateDeviceCommandHandler(IDevice device) => _device = device;

    public async Task<string> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
    {
        try
        {
            _device.Update(request.Id, request.DeviceUpdate.Adapt<DeviceModel>());
            _device.Save();
            return "Update Succsec !!";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}