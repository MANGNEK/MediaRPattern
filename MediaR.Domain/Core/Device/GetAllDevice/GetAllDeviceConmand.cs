using MediaR.Domain.DTO;
using MediaR.Domain.Models;
using MediaR.Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaR.Domain.Core.Device.GetAllDevice;

public class GetAllDeviceConmand() : IRequest<Result>
{
}