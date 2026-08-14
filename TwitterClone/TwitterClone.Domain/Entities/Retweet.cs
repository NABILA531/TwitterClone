namespace TwitterClone.Domain.Entities
{
    internal class Retweet
    {
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _retweeted;

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime Retweeted
        {
            get { return _retweeted; }
        }
    }
}
