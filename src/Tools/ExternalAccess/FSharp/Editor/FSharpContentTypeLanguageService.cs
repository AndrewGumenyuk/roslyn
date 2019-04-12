﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Composition;
using Microsoft.CodeAnalysis.Editor;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.Editor
{
    [ExportContentTypeLanguageService(ContentTypeNames.FSharpContentType, LanguageNames.FSharp), Shared]
    internal class FSharpContentTypeLanguageService : IContentTypeLanguageService
    {
        private readonly IContentTypeRegistryService _contentTypeRegistry;

        [ImportingConstructor]
        public FSharpContentTypeLanguageService(IContentTypeRegistryService contentTypeRegistry)
        {
            _contentTypeRegistry = contentTypeRegistry;
        }

        public IContentType GetDefaultContentType()
        {
            return _contentTypeRegistry.GetContentType(ContentTypeNames.FSharpContentType);
        }
    }
}
