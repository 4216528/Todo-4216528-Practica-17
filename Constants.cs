using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Todo_4216528

{

    internal class Constants

    {

        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =

            // Abre la base de datos en modo de lectura y escritura //

            SQLite.SQLiteOpenFlags.ReadWrite |

            // Se crea la base de datos si esta no existe //

            SQLite.SQLiteOpenFlags.Create |

            // Se avilita el acceso de multiprocesos a la base de datos //

            SQLite.SQLiteOpenFlags.SharedCache;

            public static string DatabasePath =>Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    }
}
