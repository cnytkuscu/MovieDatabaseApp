using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabaseApp.Interfaces
{
    public interface ILoginService
    {
         bool LoginToSystem(string Id, string Pw);
    }
}
