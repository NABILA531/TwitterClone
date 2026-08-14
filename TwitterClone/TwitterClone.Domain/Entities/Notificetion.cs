namespace TwitterClone.Domain.Entities
{
    internal class Notificetion
    {

        private Guid _id;
        private Guid _userId;
        private string _message;
        private DateTime _createdAt;
        private bool _isRead;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }
    }
}
