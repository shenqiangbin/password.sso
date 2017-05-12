using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace password.UI
{
    public static class TokenMgr
    {
        private static List<TokenItem> tokens = new List<TokenItem>();

        public static void Add(TokenItem item)
        {
            tokens.Add(item);
        }
    }
}