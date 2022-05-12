namespace DemonstrationLibrary
{
    partial class HelloMonotonicFactorySrc
    {
        private sealed class HelloMonotonicFactoryDefaultImpl : IHelloMonotonicProviderFactory<HelloMonotonicProvider>
        {
            internal static IHelloMonotonicProviderFactory<HelloMonotonicProvider> FactoryInstance => TheSingleton;
            /// <inheritdoc />
            public HelloMonotonicProvider GetMessageProvider() => HelloMonotonicProvider.Instance;


            /// <inheritdoc />
            IHelloMonotonicMessageProvider IHelloMonotonicProviderFactory.GetMessageProvider() => GetMessageProvider();

            private HelloMonotonicFactoryDefaultImpl(){}

            private static readonly HelloMonotonicFactoryDefaultImpl TheSingleton = new();
        }
    }
}
