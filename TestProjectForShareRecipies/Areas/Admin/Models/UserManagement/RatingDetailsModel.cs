namespace TestProjectForShareRecipies.Areas.Admin.Models.UserManagement
{
    public class RatingDetailsModel
    {
        public double Value { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
