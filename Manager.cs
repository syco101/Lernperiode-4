using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeBot_9000
{
    class Managerr
    {
        static void Main(string[] args)
        {


            Botmanager manager = new BotManager();
             manager.RunBot().GetAwaiter().GetResult();



        }




    }


    
    }

