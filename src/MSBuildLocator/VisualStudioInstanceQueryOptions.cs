// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Build.Locator
{
    /// <summary>
    ///     Options to consider when querying for Visual Studio instances.
    /// </summary>
    public class VisualStudioInstanceQueryOptions
    {
        /// <summary>
        ///     Default query options (all instances).
        /// </summary>
        public static VisualStudioInstanceQueryOptions Default => new VisualStudioInstanceQueryOptions
        {
            DiscoveryTypes =
#if FEATURE_VISUALSTUDIOSETUP
                DiscoveryType.DeveloperConsole | DiscoveryType.VisualStudioSetup
#endif
#if NETSTANDARD2_0
                DiscoveryType.DotNetSdk
#endif
        };

        /// <summary>
        ///     Discovery types for instances included in the query.
        /// </summary>
        public DiscoveryType DiscoveryTypes { get; set; }

        /// <summary>
        /// A working directory to use when querying for instances.
        /// </summary>
        public string WorkingDir { get; set; } = Environment.CurrentDirectory;
    }
}