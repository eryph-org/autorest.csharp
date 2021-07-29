// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing the SubFake data model. </summary>
    public partial class SubFakeData : TrackedResource
    {
        /// <summary> Initializes a new instance of SubFakeData. </summary>
        /// <param name="location"> The location. </param>
        public SubFakeData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SubFakeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal SubFakeData(ResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, SubFakeProperties properties) : base(id, name, type, location, tags)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        public SubFakeProperties Properties { get; set; }
    }
}