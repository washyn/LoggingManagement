﻿using System;
using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Models;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Volo.Abp.DependencyInjection;

namespace LoggingManagementSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class FakeTencentCloudApiRequester : ITencentCloudApiRequester, ITransientDependency
    {
        private readonly AbpTencentCloudCommonOptions _sdkCommonOptions;

        public FakeTencentCloudApiRequester(
            IOptions<AbpTencentCloudCommonOptions> sdkCommonOptions)
        {
            _sdkCommonOptions = sdkCommonOptions.Value;
        }

        
        public async Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint) where TResponse : ICommonResponse
        {
            return await SendRequestAsync<TResponse>(request, endpoint, _sdkCommonOptions);
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint, AbpTencentCloudCommonOptions options) where TResponse : ICommonResponse
        {
            const string result = "{\"context\":\"\",\"listover\":false,\"results\":[{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"},{\"content\":\"{\\\"MessageTemplate\\\": \\\"1\\\" }\",\"filename\":\"\",\"pkg_id\":\"\",\"pkg_logid\":\"\",\"source\":\"\",\"time\":0,\"timestamp\":\"2017-07-14 20:43:00\",\"topic_id\":\"\",\"topic_name\":\"\"}]}";
            
            return request.ResultRoot.IsNullOrEmpty()
                ? JObject.Parse(result).ToObject<TResponse>()
                : JObject.Parse(result).SelectToken($"$.{request.ResultRoot}").ToObject<TResponse>();
        }
    }
}