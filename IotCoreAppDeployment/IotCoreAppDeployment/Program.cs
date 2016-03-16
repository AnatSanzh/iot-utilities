// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.Iot.IotCoreAppDeployment
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            using (var stream = System.Console.OpenStandardOutput())
            {
                var task = DeploymentWorker.Execute(args, stream);
                var retval = (task.Result) ? 0 : 1;
                return retval;
            }
        }
    }
}
