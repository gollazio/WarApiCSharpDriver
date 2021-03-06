﻿using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Encyclopedia
{
    public class EncyclopediaRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "encyclopedia";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
