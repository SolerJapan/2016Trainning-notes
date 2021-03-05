using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace productForm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static DBAccess dbAccess = new DBAccess();

        public static DBAccess DBAccess
        {
            get { return dbAccess; }
        }

    }
}
