using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContacto
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class PreserveAttribute : Attribute
    {
        public bool AllMembers { get; set; }
        public bool Conditional { get; set; }
    }
}
