using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
