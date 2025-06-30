﻿namespace DbLibrary.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public DateTime PublicationDate { get; set; }
    }

    public class ReviewDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
    }
}
