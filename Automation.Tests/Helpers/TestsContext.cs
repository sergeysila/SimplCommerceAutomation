using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Automation.Tests.Helpers
{
    public static class TestsContext
    {
        private static TestContext CurrentContext
            => TestContext.CurrentContext;

        public static void Add<T>(string key, T value, bool replace = false)
        {
            if (!CurrentContext.Keys.Contains(key) || replace)
                CurrentContext[key] = value;
        }

        public static T TryGet<T>(string key) where T : class
        {
            if(CurrentContext.ContainsKey(key))
                return CurrentContext.Get<T>(key);

            return null;
        }

        public static InternalOrderAggregationDto InternalOrderAggregations
        {
            get => CurrentContext.Get<InternalOrderAggregationDto>(Constants.InternalOrderAggregation);
            set => CurrentContext[Constants.InternalOrderAggregation] = value;
        }
    }
}