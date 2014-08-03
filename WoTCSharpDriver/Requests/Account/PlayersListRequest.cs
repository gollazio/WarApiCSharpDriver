﻿using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Account
{
    public class PlayersListRequest : AccountRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "list";
            }
        }

        [RequestParameter("search", true)]
        public string Search { get; set; }

        [RequestParameter("limit", false)]
        public int Limit { get; set; }

        public PlayersListRequest()
        {
            Limit = 100;
        }
    }
}
