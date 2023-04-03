using Microsoft.Data.SqlClient;

namespace SqlBulkTools
{
    /// <summary>
    /// 
    /// </summary>
    public class BulkCopySettings
    {
        /// <summary>
        /// Number of seconds for the operation to complete before it times out.
        /// </summary>
        public int BulkCopyTimeout { get; set; } = 600;
        /// <summary>
        /// Enables or disables a SqlBulkCopy object to stream data from an IDataReader object
        /// </summary>
        public bool EnableStreaming { get; set; }

        /// <summary>
        /// You can use the SqlBulkCopyOptions enumeration when you construct a SqlBulkCopy instance to change how the WriteToServer methods for that instance behave.
        /// </summary>
        public SqlBulkCopyOptions SqlBulkCopyOptions { get; set; } = SqlBulkCopyOptions.Default;

        /// <summary>
        /// Number of rows in each batch. At the end of each batch, the rows in the batch are sent to the server.
        /// </summary>
        public int BatchSize { get; set; } = 5000;

        /// <summary>
        /// 
        /// </summary>
        public BulkCopyNotification BulkCopyNotification { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class BulkCopyNotification
    {
        /// <summary>
        /// Occurs every time the number of rows defined by NotifyAfter has processed
        /// </summary>
        public SqlRowsCopiedEventHandler SqlRowsCopied { get; set; }
        /// <summary>
        /// Defines the number of rows to be processed before generating a notification event.
        /// </summary>
        public int NotifyAfter { get; set; }
    }
}
