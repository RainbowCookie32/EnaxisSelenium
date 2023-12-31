﻿namespace EnaxisSelenium.SummaryHandlers.Contracts
{
    public interface ITestSummaryExporter
    {
        void Export(List<(TimeSpan ElapsedTime, string Action, TimeSpan? TimeTaken)> logMessages, string outputPath);
    }

}
