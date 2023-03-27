namespace ARKanyFryzjerstwa.Models
{
    public class CacheItem<T> where T : class
    {
        private DateTime _modificationTime;
        public T Item { get; set; }
        public DateTime ModificationTime => _modificationTime;

        public CacheItem(T item) : this(item, DateTime.Now)
        {}
        public CacheItem(T item, DateTime modificationTime)
        {
            Item = item;
            _modificationTime = modificationTime;
        }

        public void UpDateModificationTime(DateTime? time = null)
        {
            _modificationTime = time ?? DateTime.Now;
        }
    }
}
