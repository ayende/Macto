namespace HibernatingRhinos.Macto.Models
{
    public class AttachmentReference
    {
        public string AttachmentId { get; set; }

        public static implicit operator AttachmentReference(string id)
        {
            return new AttachmentReference() { AttachmentId = id };
        }
    }
}