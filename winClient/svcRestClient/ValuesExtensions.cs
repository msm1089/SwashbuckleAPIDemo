﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace svcRest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;

    /// <summary>
    /// Extension methods for Values.
    /// </summary>
    public static partial class ValuesExtensions
    {
            /// <summary>
            /// Retrieves the list of values
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> Get(this IValues operations)
            {
                return Task.Factory.StartNew(s => ((IValues)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the list of values
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetAsync(this IValues operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Insert a new value in the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// New value to be inserted
            /// </param>
            public static void PostByvalue(this IValues operations, string value)
            {
                Task.Factory.StartNew(s => ((IValues)s).PostByvalueAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Insert a new value in the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// New value to be inserted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostByvalueAsync(this IValues operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostByvalueWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Retrieves one value from the list of values
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the item to be retrieved
            /// </param>
            public static string GetByid(this IValues operations, int id)
            {
                return Task.Factory.StartNew(s => ((IValues)s).GetByidAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves one value from the list of values
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the item to be retrieved
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetByidAsync(this IValues operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByidWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Change a single value in the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the value to be changed
            /// </param>
            /// <param name='value'>
            /// The new value
            /// </param>
            public static void PutByidvalue(this IValues operations, int id, string value)
            {
                Task.Factory.StartNew(s => ((IValues)s).PutByidvalueAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Change a single value in the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the value to be changed
            /// </param>
            /// <param name='value'>
            /// The new value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByidvalueAsync(this IValues operations, int id, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutByidvalueWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete an item from the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the item to be deleted
            /// </param>
            public static void DeleteByid(this IValues operations, int id)
            {
                Task.Factory.StartNew(s => ((IValues)s).DeleteByidAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an item from the list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the item to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByidAsync(this IValues operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteByidWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
