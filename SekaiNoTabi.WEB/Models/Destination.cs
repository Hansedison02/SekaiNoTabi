using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Destination
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string? Name { get; set; }

    [BsonElement("Location")]
    public string? Location { get; set; }

    [BsonElement("Description")]
    public string? Description { get; set; }

    [BsonElement("ImageUrl")]
    public string? ImageUrl { get; set; }
}