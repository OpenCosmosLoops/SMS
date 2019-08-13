﻿namespace Cosmos.Business.Extensions.SMS.ChuangLan.Configuration
{
    public class ChuangLanConfig : IConfig
    {
        public ChuangLanAccount CodeAccount { get; set; }

        public ChuangLanAccount MarketingAccount { get; set; }

        public bool UseMarketingSms { get; set; } = false;

        public int RetryTimes { get; set; } = 3;
    }
}