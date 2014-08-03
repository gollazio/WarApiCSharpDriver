﻿using WarApi.Utilities.Attributes;
using WarApi.ConstantVlaues;

namespace WarApi.Requests.Clan
{
    public class ClansListRequest : ClansRequestBase
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

        [RequestParameter("order_by", false)]
        public ClansSortOrder OrderBy { get; set; }
    }
}
