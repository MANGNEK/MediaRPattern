using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaR.Domain.Models;

public class DeviceModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    public string NameDevice { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Total { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}