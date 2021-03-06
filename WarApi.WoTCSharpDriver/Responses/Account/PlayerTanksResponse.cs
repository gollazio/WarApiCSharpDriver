﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarApi.Responses.Account
{
    public class PlayerTanksResponseData
    {
        [JsonProperty("tank_id")]
        public int TankId { get; set; }

        [JsonProperty("mark_of_mastery")]
        public int MarkOfMastery { get; set; }
        
        [JsonProperty("statistics")]
        public TankStatistic Statistic { get; set; }
    }

    public class PlayerTanksResponse : ResponseBase<IDictionary<string, IList<PlayerTanksResponseData>>>
    {
    }
}
