namespace TwitterClone.Domain.Entities
{
    internal class User
    {
        private Guid _id;
        private string _firstname;
        private string  _lastname;
        private string _email;
        private DateTime _createdAt;

        public User()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }
        public User() { 
            _id = Guid.NewGuid();
        } 
        public Guid Id
        {
            get { return _id; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
    }
}
