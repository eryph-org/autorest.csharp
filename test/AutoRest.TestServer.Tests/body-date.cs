﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using body_date;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests
{
    public class BodyDateTest: TestServerTestBase
    {
        public BodyDateTest(TestServerVersion version) : base(version, "date") { }

        [Test]
        public Task GetDateInvalid() => Test((host, pipeline) =>
        {
            Assert.ThrowsAsync<FormatException>(async () =>
                await DateOperations.GetInvalidDateAsync(ClientDiagnostics, pipeline, host));
        });

        [Test]
        public Task GetDateMax() => Test(async (host, pipeline) =>
        {
            var result = await DateOperations.GetMaxDateAsync(ClientDiagnostics, pipeline, host);
            Assert.AreEqual(DateTimeOffset.Parse("9999-12-31"), result.Value);
        });

        [Test]
        public Task GetDateMin() => Test(async (host, pipeline) =>
        {
            var result = await DateOperations.GetMinDateAsync(ClientDiagnostics, pipeline, host);
            Assert.AreEqual(DateTimeOffset.Parse("0001-01-01"), result.Value);
        });

        [Test]
        [Ignore("https://github.com/Azure/autorest.csharp/issues/300")]
        public Task GetDateNull() => Test(async (host, pipeline) =>
        {
            var result = await DateOperations.GetNullAsync(ClientDiagnostics, pipeline, host);
            Assert.AreEqual(null, result.Value);
        });

        [Test]
        public Task GetDateOverflow() => Test((host, pipeline) =>
        {
            Assert.ThrowsAsync<FormatException>(async () =>
                await DateOperations.GetOverflowDateAsync(ClientDiagnostics, pipeline, host));
        });

        [Test]
        public Task GetDateUnderflow() => Test((host, pipeline) =>
        {
            Assert.ThrowsAsync<FormatException>(async () =>
                await DateOperations.GetUnderflowDateAsync(ClientDiagnostics, pipeline, host));
        });

        [Test]
        public Task PutDateMax() => TestStatus(async (host, pipeline) =>
        {
            var value = DateTimeOffset.Parse("9999-12-31");
            return await DateOperations.PutMaxDateAsync(ClientDiagnostics, pipeline, value, host);
        });

        [Test]
        public Task PutDateMin() => TestStatus(async (host, pipeline) =>
        {
            var value = DateTimeOffset.Parse("0001-01-01");
            return await DateOperations.PutMinDateAsync(ClientDiagnostics, pipeline, value, host);
        });
    }
}