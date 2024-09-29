using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCrudApp.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }
    }
}
