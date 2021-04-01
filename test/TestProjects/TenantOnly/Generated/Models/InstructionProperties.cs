// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace TenantOnly
{
    /// <summary> A billing instruction used during invoice generation. </summary>
    public partial class InstructionProperties
    {
        /// <summary> Initializes a new instance of InstructionProperties. </summary>
        /// <param name="amount"> The amount budgeted for this billing instruction. </param>
        /// <param name="startDate"> The date this billing instruction goes into effect. </param>
        /// <param name="endDate"> The date this billing instruction is no longer in effect. </param>
        internal InstructionProperties(float amount, DateTimeOffset startDate, DateTimeOffset endDate)
        {
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary> Initializes a new instance of InstructionProperties. </summary>
        /// <param name="amount"> The amount budgeted for this billing instruction. </param>
        /// <param name="startDate"> The date this billing instruction goes into effect. </param>
        /// <param name="endDate"> The date this billing instruction is no longer in effect. </param>
        /// <param name="creationDate"> The date this billing instruction was created. </param>
        internal InstructionProperties(float amount, DateTimeOffset startDate, DateTimeOffset endDate, DateTimeOffset? creationDate)
        {
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
        }

        /// <summary> The amount budgeted for this billing instruction. </summary>
        public float Amount { get; }
        /// <summary> The date this billing instruction goes into effect. </summary>
        public DateTimeOffset StartDate { get; }
        /// <summary> The date this billing instruction is no longer in effect. </summary>
        public DateTimeOffset EndDate { get; }
        /// <summary> The date this billing instruction was created. </summary>
        public DateTimeOffset? CreationDate { get; }
    }
}