// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using FluentAssertions;
using Microsoft.DotNet.Tools.Test.Utilities;
using Xunit;

namespace Microsoft.DotNet.Tests.Commands
{
    public class CommandIntegrationTests : TestBase
    {
        [Fact]
        public void GivenNoArgumentsProvided()
        {
            var cmd = new DotnetCommand().Execute(string.Empty);
            cmd.StdErr.Should().BeEmpty();
        }

        [Fact]
        public void GivenOnlyArgumentProvidedIsDiagnosticsFlag()
        {
            var cmd = new DotnetCommand().Execute("-d");
            cmd.ExitCode.Should().Be(0);
            cmd.StdErr.Should().BeEmpty();
        }
    }
}
