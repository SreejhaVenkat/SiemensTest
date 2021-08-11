using System;

namespace SiemensTest
{
    internal abstract  class PlatFormTypeBase
    {
        

        internal virtual string Type { get; }
        internal  string GetMessage()
        {
            return "Hi, I am from " + Type;
        }
    }
}