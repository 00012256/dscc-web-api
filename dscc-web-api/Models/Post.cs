﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace dscc_web_api.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }

        public int AuthorId { get; set; }

        [JsonIgnore]
        public Author Author { get; set; }
    }
}
