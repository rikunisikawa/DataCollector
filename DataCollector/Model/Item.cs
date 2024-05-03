namespace DataCollector.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    public class MasterItem
    {
        public int Id { get; set; }
        public string Name { get; set; }  // 項目名
        public string Type { get; set; }  // データタイプ（例：string, int）
    }
    public class DynamicDataEntry
    {
        public Dictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
    }

}
