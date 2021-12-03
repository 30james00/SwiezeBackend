using Application.Core;

namespace Application.Reviews
{
    public class ReviewParams : PagingParams
    {
        public int? NumberOfStars { get; set; }   
    }
}