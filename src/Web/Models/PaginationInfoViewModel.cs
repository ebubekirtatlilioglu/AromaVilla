namespace Web.Models
{
    public class PaginationInfoViewModel
    {
        public int PageId { get; set; } // anlık ksayfa
        public int TotalItems { get; set; }
        public int ItemsOnPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalItems / (double)Constants.ITEMS_PER_PAGE); // toplam sayfa sayısı
        public bool HasPrevious => PageId > 1; // öncesi var mı
        public bool HasNext => PageId < TotalPages; // sonrası var mı
        public int RangeStart => (PageId - 1) * Constants.ITEMS_PER_PAGE + 1; // sayfanın ilk ürünün sırası
        public int RangeEnd => RangeStart + ItemsOnPage - 1; // sayfanın son ürün sırası

        public int[] PageNumbers => Pagination(PageId, TotalPages);

        private int[] Pagination(int current, int last)
        {
            int delta = 1;
            int left = current - delta;
            int right = current + delta + 1;
            var range = new List<int>();
            var rangeWithDots = new List<int>();
            int? l = null;

            for (var i = 1; i <= last; i++)
            {
                if (i == 1 || i == last || i >= left && i < right)
                {
                    range.Add(i);
                }
            }

            foreach (var i in range)
            {
                if (l != null)
                {
                    if (i - l == 2)
                    {
                        rangeWithDots.Add(l.Value + 1);
                    }
                    else if (i - l != 1)
                    {
                        rangeWithDots.Add(-1);
                    }
                }
                rangeWithDots.Add(i);
                l = i;
            }

            return rangeWithDots.ToArray();
        }
    }
}
