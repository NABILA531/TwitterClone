namespace TwitterClone.Domain.Entities
{
    internal class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private DateTime _createdAt;

        private string _content;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid ID
        {  
            get { return _id; }
        }
        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
