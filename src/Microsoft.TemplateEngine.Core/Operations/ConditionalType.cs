﻿namespace Microsoft.TemplateEngine.Core.Operations
{
    // The commonly used conditional types. If more get added to ConditionalConfig.cs, they should be added here too.
    public enum ConditionalType
    {
        None,
        Xml,
        Razor,
        CWithComments,
        CNoComments,
        CBlockComments
    }
}
