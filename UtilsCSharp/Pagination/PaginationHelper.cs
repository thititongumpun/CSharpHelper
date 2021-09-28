using System;

namespace UtilsCSharp.Pagination
{
    public class PaginationHelper<T> where T : class, new()
    {
        public PaginationHelper(int totalCount, T data, int currentPage, int pageSize)
        {
            TotalCount = totalCount;
            Data = data;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling((double)TotalCount / (double)PageSize);
            HasPreviousPage = CurrentPage > 1;
            HasNextPage = CurrentPage < TotalPages;
        }
        
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public T Data { get; set; }
    }
}