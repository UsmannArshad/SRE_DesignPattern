using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface DatabaseExecuter
    {
        void ExecuteDataBase(string query);
    }
    class DatabaseExecuterImpl:DatabaseExecuter
    {
        public void ExecuteDataBase(string query)
        {
            Console.WriteLine("Executing the query: "+query);
        }
    }
    class DataBaseExecuterProxy:DatabaseExecuter
    {
        bool isadmin;
        DatabaseExecuterImpl dbi = null;
        public DataBaseExecuterProxy(string username,string password)
        {
            if(username=="admin"&&password=="123")
            {
                isadmin = true;
            }
            dbi = new DatabaseExecuterImpl();
        }

        public void ExecuteDataBase(string query)
        {
            if(isadmin==true)
            {
                dbi.ExecuteDataBase(query);
            }
            else
            {
                if(query.Contains("Delete"))
                {
                    Console.WriteLine("Delete not allowed for non-admin users");
                }
                else
                {
                    dbi.ExecuteDataBase(query);
                }
            }
        }
    }
}
