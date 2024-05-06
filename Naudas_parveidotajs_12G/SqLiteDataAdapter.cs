using System;
using System.Data;

namespace Naudas_parveidotajs_12G
{
    internal class SqLiteDataAdapter
    {
        private SqLiteCommand sqlite_cmd;

        public SqLiteDataAdapter(SqLiteCommand sqlite_cmd)
        {
            this.sqlite_cmd = sqlite_cmd;
        }

        internal void Fill(DataTable sTable)
        {
            throw new NotImplementedException();
        }
    }
}