﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.SignalR.Hubs
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoRejoiningGroupsModule : HubPipelineModule
    {
        public override Func<HubDescriptor, IRequest, IEnumerable<string>, IEnumerable<string>> BuildRejoiningGroups(Func<HubDescriptor, IRequest, IEnumerable<string>, IEnumerable<string>> rejoiningGroups)
        {
            return (hubDescriptor, request, groups) => groups;
        }
    }
}
