﻿using System;

using Autofac;

using BetterCMS.Module.LuceneSearch.Services.ScrapeService;

using BetterCms.Core.Dependencies;

namespace BetterCMS.Module.LuceneSearch.Workers
{
    public class DefaultIndexSourceWatcher : WorkerBase
    {
        public DefaultIndexSourceWatcher()
            : base(new TimeSpan(0, 0, 30, 0))
        {
        }

        protected override void DoWork()
        {
            using (var lifetimeScope = ContextScopeProvider.CreateChildContainer())
            {
                var scrapeService = lifetimeScope.Resolve<IScrapeService>();

                scrapeService.FetchNewUrls();
            }
        }
    }
}