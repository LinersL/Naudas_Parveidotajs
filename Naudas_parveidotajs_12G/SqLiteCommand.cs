using System;

namespace Naudas_parveidotajs_12G
{
    internal class SqLiteCommand
    {
        private string query;
        private SqLiteConnection connection;

        public SqLiteCommand(string query, SqLiteConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }

        public string CommandText { get; internal set; }
        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}