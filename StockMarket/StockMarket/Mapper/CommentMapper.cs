using StockMarket.DTO.Comment;
using StockMarket.Models;
using System.Runtime.CompilerServices;

namespace StockMarket.Mapper
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
            };
        }
    }
}
