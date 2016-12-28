﻿using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using MirrorSharp.Internal.Results;

namespace MirrorSharp.Internal.Handlers {
    internal interface ICommandHandler {
        char CommandId { get; }
        [NotNull] Task ExecuteAsync(ArraySegment<byte> data, [NotNull] WorkSession session, [NotNull] ICommandResultSender sender, CancellationToken cancellationToken);
    }
}
