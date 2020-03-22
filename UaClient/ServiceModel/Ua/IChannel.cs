// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading;
using System.Threading.Tasks;

namespace Workstation.ServiceModel.Ua.Channels
{
    public interface IChannel
    {
        /// <summary>
        /// Invoked during the transition of a channel into the opening state.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnOpeningAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked after the transition to the opening state due to the invocation of the OpenAsync operation.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnOpenAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked during the transition of a channel into the opened state.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnOpenedAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked during the transition of a channel into the closing state.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnClosingAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked after the transition to the closing state due to the invocation of the CloseAsync operation.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnCloseAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked during the transition of a channel into the closed state.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnClosedAsync(CancellationToken token = default);

        /// <summary>
        /// Invoked after the transition to the closing state due to the invocation of the AbortAsync operation.
        /// </summary>
        /// <param name="token">The <see cref="System.Threading.CancellationToken" /> that notifies when the task should be canceled.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task OnAbortAsync(CancellationToken token = default);

    }
}