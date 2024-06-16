namespace CommentManagement.Domain.CommentAgg
{
    public class Comment
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public int Type { get; private set; }
        public int ParentId { get; private set; }


        public Comment(string name, string email, string message, int type, int parentId)
        {
            Name = name;
            Email = email;
            Message = message;
            Type = type;
            ParentId = parentId;
        }
    }
}
