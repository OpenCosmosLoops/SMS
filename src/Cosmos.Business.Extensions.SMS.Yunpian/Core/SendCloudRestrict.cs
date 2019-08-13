﻿using System.Collections.Generic;
using Cosmos.Business.Extensions.SMS.Events.Restrict;

namespace Cosmos.Business.Extensions.SMS.Yunpian.Core
{
    public sealed class SendCloudRestrict : SmsSendRestrictTemplate
    {
        public static SendCloudRestrict Instance { get; } = new SendCloudRestrict();

        private static Dictionary<SmsSendEventType, SmsSendEventRule> _legitimateSmsSendEventRules
            = new Dictionary<SmsSendEventType, SmsSendEventRule> {
                {SmsSendEventType.Code, new SmsSendEventRule(1)},
                {SmsSendEventType.Message, new SmsSendEventRule(Constants.MaxReceivers)}
            };

        private SendCloudRestrict() : base(_legitimateSmsSendEventRules) { }
    }
}