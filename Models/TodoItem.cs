using System;

// Se agrega la referencia using //

using SQLite;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Todo_4216528.Models

{

    // Se cambia el valor de la clase de internal(interna) a public(publica) //
    public class TodoItem

    {

        // Se asigna la llave primaria a ID, y se declara que esta sea autoincrementable //

        [PrimaryKey, AutoIncrement]

        // Se declaran los items que se crearan y se les asigna su respectivo { get; set;  //}
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }


    }

}
