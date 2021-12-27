namespace JNISharp.ToolInterface;

using System.Text.Json;
using System.Text.Json.Serialization;

public class JClassSignature
{
    [JsonInclude]
    public string Signature { get; init; }

    [JsonInclude]
    public string Generic { get; init; }

    [JsonInclude]
    public IEnumerable<JFieldSignature> FieldSignatures { get; init; }

    [JsonInclude]
    public IEnumerable<JMethodSignature> MethodSignatures { get; init; }

    public JClassSignature(string signature, string generic, IEnumerable<JFieldSignature> fieldSignatures, IEnumerable<JMethodSignature> methodSignatures)
    {
        this.Signature = signature;
        this.Generic = generic;
        this.FieldSignatures = fieldSignatures;
        this.MethodSignatures = methodSignatures;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
