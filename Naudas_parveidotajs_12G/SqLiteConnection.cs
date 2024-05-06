using System;
using System.Data.SQLite;

namespace Naudas_parveidotajs_12G
{
    internal class SqLiteConnection
    {
        private string v;

        public SqLiteConnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SqLiteConnection(SQLiteConnection v)
        {
            throw new NotImplementedException();
        }
    }
}