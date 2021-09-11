using System.Collections.Generic;

namespace PowerfulDiscounts.Model.Validation
{
    public interface IValidator<in T>
    {
        public IReadOnlyCollection<string> Errors { get; }
        
        public bool IsValid { get; }

        public void Validate(T o);
    }
}