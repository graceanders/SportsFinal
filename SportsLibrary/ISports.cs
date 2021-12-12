using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public interface ISports : IAboutable
    {
        string SportName { get;  set; }
        string SportDescription { get; set; }
    }

    public interface IAboutable
    {
        string About();
    }
}
