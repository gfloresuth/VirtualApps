using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualAppEngine
{
    interface VACommand
    {
        void execute(VAScope scope);
        void reportError(string title, string description, int value);
    }
}
