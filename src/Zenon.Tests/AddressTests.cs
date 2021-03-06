using FluentAssertions;
using Xunit;
using Zenon.Model.Primitives;
using Zenon.Tests.TestData.Model.Primatives;

namespace Zenon.Tests
{
    public partial class ModelTests
    {
        public partial class Primatives
        {
            public class AddressType
            {
                [Theory]
                [ClassData(typeof(AddressTestData))]
                public void When_ParseAddress_ExpectToEqual(string addressString, string shortString, string hrp, byte[] bytes, bool embedded)
                {
                    // Execute
                    var address = Address.Parse(addressString);

                    // Validate
                    address.ToString().Should().Be(addressString);
                    address.ToShortString().Should().Be(shortString);
                    address.Hrp.Should().Be(hrp);
                    address.Bytes.Should().BeEquivalentTo(bytes);
                    address.IsEmbedded.Should().Be(embedded);
                }
            }
        }
    }
}
