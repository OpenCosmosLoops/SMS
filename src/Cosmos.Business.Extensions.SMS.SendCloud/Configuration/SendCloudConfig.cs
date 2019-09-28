﻿namespace Cosmos.Business.Extensions.SMS.SendCloud.Configuration
{
    public class SendCloudConfig : IConfig<SendCloudAccount>
    {
        public SendCloudAccount Account { get; set; }

        public int RetryTimes { get; set; } = 3;
    }
}