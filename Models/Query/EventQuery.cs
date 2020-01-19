using System;
using Newtonsoft.Json;

namespace com.WillisWare.EventViewer.Models.Query
{
    public sealed class EventQuery
    {
        [JsonProperty(PropertyName = "contains")]
        public string Contains { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public DateTime EndDate { get; set; } = DateTime.UtcNow;

        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; } = 1;

        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; } = 0;

        [JsonProperty(PropertyName = "startDate")]
        public DateTime StartDate { get; set; }
    }
}
