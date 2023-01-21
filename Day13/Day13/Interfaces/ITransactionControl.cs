using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13.Interfaces
{
    public interface ITransactionControl
    {
        IDbTransaction CurrentTransaction { get; }

        /// <summary>
        /// Starts a transaction on the connection provided
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits the current transaction
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Rolls back the current transaction
        /// </summary>
        void RollbackTransaction();
    }
}
