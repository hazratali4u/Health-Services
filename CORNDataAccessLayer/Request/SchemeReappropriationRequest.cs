namespace CORNDataAccessLayer.Request
{
    public class SchemeReappropriationRequest
    {
        public SchemeReappropriation SchemeReappropriationObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
    }
}
