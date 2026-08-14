namespace TwitterClone.Domain.Entities
{
    internal class User
    {
        private Guid _id;
        private string _firstname;
        private string  _lastname;
        private string _email;

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
