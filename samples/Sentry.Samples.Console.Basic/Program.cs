using System;
using Sentry;

static class Program
{
    static void Main()
    {
        using (SentrySdk.Init("https://eb71c11712f7493ea868ea426744cf1b@o487614.ingest.sentry.io/5546564"))
        {
            // The following exception is captured and sent to Sentry

            throw null;

        }
    }
}
