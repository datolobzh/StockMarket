using System.ComponentModel.DataAnnotations;

namespace StockMarket.DTO.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Title can not be over 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "content must be 5 characters")]
        [MaxLength(280, ErrorMessage = "content can not be over 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
