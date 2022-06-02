using System.Diagnostics.CodeAnalysis;

namespace GEM.VISA
{
    public record IsExternalInitConsumer(string Value);

    public class NullableAttributeConsumer
    {
        object? _value;

        [MemberNotNull(nameof(_value))]
        public void Init()
        {
            _value = new();
        }
    }
}
