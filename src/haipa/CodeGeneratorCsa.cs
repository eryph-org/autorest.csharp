// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.CSharp.haipa.Templates;
using AutoRest.CSharp.Model;
using AutoRest.CSharp.vanilla.Templates.Rest.Client;
using AutoRest.CSharp.vanilla.Templates.Rest.Common;
using static AutoRest.Core.Utilities.DependencyInjection;
using System.Collections.Generic;
using AutoRest.CSharp.Haipa.Model;
using PageTemplate = AutoRest.CSharp.haipa.Templates.PageTemplate;

namespace AutoRest.CSharp.Haipa
{
    public class CodeGeneratorCsa : CodeGeneratorCs
    {
        private const string ClientRuntimePackage = "Haipa.ClientRuntime.0.0.1";

        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
            Properties.Resources.UsageInformation, ClientRuntimePackage);


        /// <summary>
        ///     Generates C# code for service client.
        /// </summary>
        /// <param name="codeModel"></param>
        /// <returns></returns>
        public override async Task Generate(CodeModel cm)
        {
            var codeModel = cm as CodeModelCsa ?? throw new InvalidCastException("CodeModel is not a Haipa c# CodeModel");

            await GenerateServiceClient<HaipaServiceClientTemplate>(codeModel);
            await GenerateOperations<HaipaMethodGroupTemplate>(codeModel.Operations);
            await GenerateModels(codeModel.ModelTypes.Union(codeModel.HeaderTypes));
            await GenerateEnums(codeModel.EnumTypes);
            await GeneratePageClasses(codeModel.pageClasses);
            await GenerateExceptions(codeModel.ErrorTypes);
            if (codeModel.ShouldGenerateXmlSerialization)
            {
                await GenerateXmlSerialization();
            }
        }

        protected virtual async Task GeneratePageClasses(IEnumerable<KeyValuePair<KeyValuePair<string, string>, string>> pageClasses)
        {
            foreach (var pageClass in pageClasses)
            {
                var page = new Page(pageClass.Value, pageClass.Key.Key, pageClass.Key.Value);
                await Write(new PageTemplate { Model = page }, $"{GeneratedSourcesBaseFolder}{FolderModels}/{page.TypeDefinitionName}{ImplementationFileExtension}");
            }
        }

        protected override async Task GenerateExceptions(IEnumerable<CompositeType> errorTypes)
        {
            foreach (CompositeTypeCs exceptionType in errorTypes)
            {
                if (exceptionType.Name == "CloudError")
                {
                    continue;
                }

                var exceptionTemplate = new ExceptionTemplate {Model = exceptionType};
                await Write(exceptionTemplate,
                     $"{GeneratedSourcesBaseFolder}{FolderModels}/{exceptionTemplate.Model.ExceptionTypeDefinitionName}{ImplementationFileExtension}");
            }
        }
    }
}