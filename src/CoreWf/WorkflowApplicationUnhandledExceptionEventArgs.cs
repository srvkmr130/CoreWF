// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

namespace CoreWf
{
    using System;
    using CoreWf.Runtime;

    [Fx.Tag.XamlVisible(false)]
    public class WorkflowApplicationUnhandledExceptionEventArgs : WorkflowApplicationEventArgs
    {
        internal WorkflowApplicationUnhandledExceptionEventArgs(WorkflowApplication application, Exception exception, Activity exceptionSource, string exceptionSourceInstanceId)
            : base(application)
        {
            this.UnhandledException = exception;
            this.ExceptionSource = exceptionSource;
            this.ExceptionSourceInstanceId = exceptionSourceInstanceId;
        }

        public Exception UnhandledException
        {
            get;
            private set;
        }

        public Activity ExceptionSource
        {
            get;
            private set;
        }

        public string ExceptionSourceInstanceId
        {
            get;
            private set;
        }
    }
}


