// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RawExtension is used to hold extensions in external versions.
    ///
    /// To use this, make a field which has RawExtension as its type in your
    /// external, versioned struct, and Object in your internal struct. You
    /// also need to register your various plugin types.
    ///
    /// // Internal package: type MyAPIObject struct {
    /// runtime.TypeMeta `json:",inline"`
    /// MyPlugin runtime.Object `json:"myPlugin"`
    /// } type PluginA struct {
    /// AOption string `json:"aOption"`
    /// }
    ///
    /// // External package: type MyAPIObject struct {
    /// runtime.TypeMeta `json:",inline"`
    /// MyPlugin runtime.RawExtension `json:"myPlugin"`
    /// } type PluginA struct {
    /// AOption string `json:"aOption"`
    /// }
    ///
    /// // On the wire, the JSON will look something like this: {
    /// "kind":"MyAPIObject",
    /// "apiVersion":"v1",
    /// "myPlugin": {
    /// "kind":"PluginA",
    /// "aOption":"foo",
    /// },
    /// }
    ///
    /// So what happens? Decode first uses json or yaml to unmarshal the
    /// serialized data into your external MyAPIObject. That causes the raw
    /// JSON to be stored, but not unpacked. The next step is to copy (using
    /// pkg/conversion) into the internal struct. The runtime package's
    /// DefaultScheme has conversion functions installed which will unpack the
    /// JSON stored in RawExtension, turning it into the correct object type,
    /// and storing it in the Object. (TODO: In the case where the object is of
    /// an unknown type, a runtime.Unknown object will be created and stored.)
    /// </summary>
    public partial class RuntimeRawExtension
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeRawExtension class.
        /// </summary>
        public RuntimeRawExtension()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuntimeRawExtension class.
        /// </summary>
        /// <param name="raw">Raw is the underlying serialization of this
        /// object.</param>
        public RuntimeRawExtension(byte[] raw)
        {
            Raw = raw;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets raw is the underlying serialization of this object.
        /// </summary>
        [JsonProperty(PropertyName = "Raw")]
        public byte[] Raw { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Raw == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Raw");
            }
        }
    }
}
