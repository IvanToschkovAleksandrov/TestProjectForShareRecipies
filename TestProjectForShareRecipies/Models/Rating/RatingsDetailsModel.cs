﻿namespace TestProjectForShareRecipies.Models.Rating
{
    public class RatingsDetailsModel
    {
        public int Value { get; set; }
        public string? Comment { get; set; }
        public string Author { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
