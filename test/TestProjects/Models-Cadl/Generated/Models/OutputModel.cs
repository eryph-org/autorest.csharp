// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsInCadl.Models
{
    /// <summary> Model used only as output. </summary>
    public partial class OutputModel : BaseModel
    {
        /// <summary> Initializes a new instance of OutputModel. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredModel"></param>
        /// <param name="requiredCollection"></param>
        /// <param name="requiredModelRecord"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredModel"/>, <paramref name="requiredCollection"/> or <paramref name="requiredModelRecord"/> is null. </exception>
        public OutputModel(string requiredString, int requiredInt, DerivedModel requiredModel, IEnumerable<CollectionItem> requiredCollection, IDictionary<string, RecordItem> requiredModelRecord)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));
            Argument.AssertNotNull(requiredCollection, nameof(requiredCollection));
            Argument.AssertNotNull(requiredModelRecord, nameof(requiredModelRecord));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
            RequiredCollection = requiredCollection.ToList();
            RequiredModelRecord = requiredModelRecord;
        }

        /// <summary> Initializes a new instance of OutputModel. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredModel"></param>
        /// <param name="requiredCollection"></param>
        /// <param name="requiredModelRecord"></param>
        internal OutputModel(string requiredString, int requiredInt, DerivedModel requiredModel, IList<CollectionItem> requiredCollection, IDictionary<string, RecordItem> requiredModelRecord)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
            RequiredCollection = requiredCollection.ToList();
            RequiredModelRecord = requiredModelRecord;
        }

        /// <summary> Gets or sets the required string. </summary>
        public string RequiredString { get; set; }
        /// <summary> Gets or sets the required int. </summary>
        public int RequiredInt { get; set; }
        /// <summary> Gets or sets the required model. </summary>
        public DerivedModel RequiredModel { get; set; }
        /// <summary> Gets the required collection. </summary>
        public IList<CollectionItem> RequiredCollection { get; }
        /// <summary> Gets the required model record. </summary>
        public IDictionary<string, RecordItem> RequiredModelRecord { get; }
    }
}