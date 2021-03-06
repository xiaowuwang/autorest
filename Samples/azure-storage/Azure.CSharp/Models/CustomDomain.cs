
namespace Petstore.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The custom domain assigned to this storage account. This can be set via
    /// Update.
    /// </summary>
    public partial class CustomDomain
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        /// <param name="name">Gets or sets the custom domain name. Name is the
        /// CNAME source.</param>
        /// <param name="useSubDomain">Indicates whether indirect CName
        /// validation is enabled. Default value is false. This should only be
        /// set on updates</param>
        public CustomDomain(string name, bool? useSubDomain = default(bool?))
        {
            Name = name;
            UseSubDomain = useSubDomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the custom domain name. Name is the CNAME source.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets indicates whether indirect CName validation is
        /// enabled. Default value is false. This should only be set on updates
        /// </summary>
        [JsonProperty(PropertyName = "useSubDomain")]
        public bool? UseSubDomain { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
