using HotChocolate.Types;

namespace TestHC13
{
    public class Query
    {
        public TestEntity GetTEstEntity() => new TestEntity() { PLZ = "12345", VKNummer = "Test 1234" };
    }

    public class TestEntityExtension : ObjectTypeExtension<TestEntity> {

        protected override void Configure(IObjectTypeDescriptor<TestEntity> descriptor)
        {
            base.Configure(descriptor);
            
            // Bug in HC 13.2.1: field names are not overridden, but additionally added.
            // (is this by design?)
            descriptor.Field(f => f.PLZ).Name("pLZ");
            descriptor.Field(f => f.VKNummer).Name("vKNummer");
        }

    }

}
