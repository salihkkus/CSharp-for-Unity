namespace TheObjectClass
{
    class Novel : Book
    {
        public int CurrentPage
        { get; set; }

        public Novel(int page = 0) : base()
        {
            CurrentPage = page;
        }

        public Novel(int page, string author, string title) : base(author, title)
        {
            CurrentPage = page;
        }

        public void Flip()
        {
            CurrentPage++;
        }

        public override string Stringify()
        {
            return "This is a Novel object!";
        }

        public override string ToString()
        {
            return "Surprise!";
        }
    }
}