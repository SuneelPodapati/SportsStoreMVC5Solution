using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStoreMVC5WebApp.Infrastructure
{
    public class GPager
    {
        public GPager(int totalItems, int? currentPage, int itemsPerPage)
        {
            var totalPages = (int)Math.Ceiling((decimal)totalItems / itemsPerPage);
            var page = currentPage != null ? (int)currentPage : 1;
            var startPage = page - 2;
            var endPage = page + 1;

            if (startPage <= 0)
            {
                endPage -= (startPage - 2);
                startPage = 1;
            }
            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage > 4)
                {
                    startPage = endPage - 3;
                }
            }

            TotalItems = totalItems;
            ItemsPerPage = itemsPerPage;
            TotalPages = totalPages;
            CurrentPage = page;
            StartPage = startPage;
            EndPage = endPage;
        }

        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }

    }
}