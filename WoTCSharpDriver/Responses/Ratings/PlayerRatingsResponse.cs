﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WoTCSharpDriver.Responses.Ratings
{
    [DataContract]
    public class PlayerRatingsResponse : ResponseBase<IList<PlayerRatingsData>>
    {
    }
}