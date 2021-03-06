// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Data.Common;
using System.Diagnostics;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore.Diagnostics
{
    /// <summary>
    ///     <see cref="DiagnosticSource" /> event payload for <see cref="RelationalEventId.DataReaderDisposing" />.
    /// </summary>
    public class DataReaderDisposingData
    {
        /// <summary>
        ///     Constructs a <see cref="DiagnosticSource" /> event payload for <see cref="RelationalEventId.DataReaderDisposing" />.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="DbCommand" /> that created the reader.
        /// </param>
        /// <param name="dataReader">
        ///     The <see cref="DbDataReader" /> that is being disposed.
        /// </param>
        /// <param name="commandId">
        ///     A correlation ID that identifies the <see cref="DbCommand" /> instance being used.
        /// </param>
        /// <param name="connectionId">
        ///     A correlation ID that identifies the <see cref="DbConnection" /> instance being used.
        /// </param>
        /// <param name="recordsAffected">
        ///     Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.
        /// </param>
        /// <param name="startTime">
        ///     The start time of this event.
        /// </param>
        /// <param name="duration">
        ///     The duration this event.
        /// </param>
        public DataReaderDisposingData(
            [NotNull] DbCommand command,
            [NotNull] DbDataReader dataReader,
            Guid commandId,
            Guid connectionId,
            int recordsAffected,
            DateTimeOffset startTime,
            TimeSpan duration)
        {
            Command = command;
            DataReader = dataReader;
            CommandId = commandId;
            ConnectionId = connectionId;
            RecordsAffected = recordsAffected;
            StartTime = startTime;
            Duration = duration;
        }

        /// <summary>
        ///     The <see cref="DbCommand" /> that created the reader.
        /// </summary>
        public virtual DbCommand Command { get; }

        /// <summary>
        ///     The <see cref="DbDataReader" /> that is being disposed.
        /// </summary>
        public virtual DbDataReader DataReader { get; }

        /// <summary>
        ///     A correlation ID that identifies the <see cref="DbCommand" /> instance being used.
        /// </summary>
        public virtual Guid CommandId { get; }

        /// <summary>
        ///     A correlation ID that identifies the <see cref="DbConnection" /> instance being used.
        /// </summary>
        public virtual Guid ConnectionId { get; }

        /// <summary>
        ///     Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.
        /// </summary>
        public virtual int RecordsAffected { get; }

        /// <summary>
        ///     The start time of this event.
        /// </summary>
        public virtual DateTimeOffset StartTime { get; }

        /// <summary>
        ///     The duration this event.
        /// </summary>
        public virtual TimeSpan Duration { get; }
    }
}
