// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtParamOrdering.Models
{
    /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Only tags may be updated. </summary>
    public partial class AvailabilitySetUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of AvailabilitySetUpdate. </summary>
        public AvailabilitySetUpdate()
        {
        }

        /// <summary> Update Domain count. </summary>
        public int? PlatformUpdateDomainCount { get; set; }
        /// <summary> Fault Domain count. </summary>
        public int? PlatformFaultDomainCount { get; set; }
    }
}