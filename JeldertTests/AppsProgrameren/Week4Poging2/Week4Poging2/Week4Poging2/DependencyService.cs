using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Poging2
{
    public interface DependencyService
    {
        SQLiteConnection CreateConnection();
    }
}
