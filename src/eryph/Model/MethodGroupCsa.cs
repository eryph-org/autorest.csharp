﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.Core.Utilities;
using AutoRest.CSharp.Model;

namespace AutoRest.CSharp.eryph.Model
{
    public class MethodGroupCsa : MethodGroupCs
    {

        protected MethodGroupCsa() : base()
        {
            TypeName.OnGet += value =>
            {
                if (IsCodeModelMethodGroup)
                {
                    return value;
                }
                return value.Else("").Contains("Operations") ? value : value + "Operations";
            };
        }

        public MethodGroupCsa(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Returns the using statements for the Operations.
        /// </summary>
        public override IEnumerable<string> Usings
        {
            get
            {
                yield return "Eryph.ClientRuntime";

                if ((CodeModel as CodeModelCsa).HaveModelNamespace)
                {
                    yield return CodeModel.ModelsName;
                }
            }
        }
    }
}