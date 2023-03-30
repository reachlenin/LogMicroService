using MongoDB.Bson.Serialization.Attributes;

namespace LogMicroService.Models
{
    [Serializable,BsonIgnoreExtraElements]
    public class Log
    {
       
        [BsonElement("LoggedOn"),BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime  LogDate{ get; set; }
        [BsonElement("ApplicatioName"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? ApplicationName { get; set; }
        [BsonElement("ApiMethod"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? ApiMethod { get; set; }
        [BsonElement("MethodType"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? MethodType { get; set; }
        [BsonElement("ContentData"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? ContentData { get; set; }
        [BsonElement("LogReferenceId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? LogReferenceId { get; set; }
        [BsonElement("BranchCode"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? BranchCode { get; set; }
        [BsonElement("UserId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? UserId { get; set; } 
    }
}
