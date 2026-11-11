using System;
using System.Collections.Generic;
using System.Text;

namespace Adressbook
{
    public class LanguageItem
    {
        public string Code { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
