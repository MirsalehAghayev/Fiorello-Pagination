﻿namespace Fiorello.Areas.Admin.ViewModels.Blog
{
    public class BlogDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? MainPhotoName { get; set; }
        public IFormFile? MainPhoto { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
