// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading;
using System.Threading.Tasks;

namespace Workstation.ServiceModel.Ua.Channels
{
    public interface ITransportChannel : IChannel
    {
        EndpointDescription RemoteEndpoint { get; }
        uint LocalMaxChunkCount { get; }
        uint LocalMaxMessageSize { get; }
        uint LocalReceiveBufferSize { get; }
        uint LocalSendBufferSize { get; }
        uint RemoteMaxChunkCount { get; }
        uint RemoteMaxMessageSize { get; }
        uint RemoteReceiveBufferSize { get; }
        uint RemoteSendBufferSize { get; }

        /// <summary>
        /// SendAsync sends a sequence of bytes to the remote endpoint.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="count">The count.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>A task.</returns>
        Task SendAsync(byte[] buffer, int offset, int count, CancellationToken token = default);

        /// <summary>
        /// ReceiveAsync receives a sequence of bytes from the remote endpoint.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="count">The count.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>A task.</returns>
        Task<int> ReceiveAsync(byte[] buffer, int offset, int count, CancellationToken token = default);
    }
}