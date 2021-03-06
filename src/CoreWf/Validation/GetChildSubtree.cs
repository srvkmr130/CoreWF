// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

namespace System.Activities.Validation
{
    using System.Activities.Runtime;
    using System.Collections.Generic;

    public sealed class GetChildSubtree : CodeActivity<IEnumerable<Activity>> 
    {
        public GetChildSubtree()
            : base()
        {
        }

        public InArgument<ValidationContext> ValidationContext
        {
            get;
            set;
        }
        
        protected override IEnumerable<Activity> Execute(CodeActivityContext context)
        {
            Fx.Assert(this.ValidationContext != null, "ValidationContext must not be null");

            ValidationContext currentContext = this.ValidationContext.Get(context);
            if (currentContext != null)
            {
                return currentContext.GetChildren();
            }
            else
            {
                return ActivityValidationServices.EmptyChildren;
            }
        }
    }
}
