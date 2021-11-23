using System;
using System.Collections.Generic;
using System.Text;
using Markdown.Interfaces;
using Markdown.Model;

namespace Markdown
{
    internal class TokenAnalyzer
    {
        public void FindOpenOrCloseBoldToken(List<IToken> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                BoldToken tmp = new BoldToken();
                if (tokens[i].GetType() == typeof(BoldToken))
                {

                }
            }
        }

        public void FindOpenOrCloseItalicToken(List<IToken> tokens)
        {

        }

        public void FindOpenOrCloseHeaderToken(List<IToken> tokens)
        {

        }
    }
}
