namespace ProjectManagementCMS_Blazor.Models
{
    public class ProjectTask
    {
        [Key]
        public int ProjectTaskId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(4096)]
        public string Content { get; set; }

        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"ID: {ProjectTaskId}");
            txt.AppendLine($"Title: {Title}");
            txt.AppendLine($"Content: {Content}");

            return txt.ToString();
        }

    }
}
