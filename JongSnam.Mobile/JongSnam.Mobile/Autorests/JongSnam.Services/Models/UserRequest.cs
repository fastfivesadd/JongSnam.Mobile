// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserRequest
    {
        /// <summary>
        /// Initializes a new instance of the UserRequest class.
        /// </summary>
        public UserRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRequest class.
        /// </summary>
        public UserRequest(string email, string password, string confirmPassword, string firstName, string lastName, string contactMobile, int userTypeId, string address = default(string), string imageProfile = default(string))
        {
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ContactMobile = contactMobile;
            ImageProfile = imageProfile;
            UserTypeId = userTypeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "confirmPassword")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactMobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageProfile")]
        public string ImageProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userTypeId")]
        public int UserTypeId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
            if (ConfirmPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConfirmPassword");
            }
            if (FirstName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirstName");
            }
            if (LastName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastName");
            }
            if (ContactMobile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactMobile");
            }
            if (Email != null)
            {
                if (Email.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Email", 50);
                }
            }
            if (Password != null)
            {
                if (Password.Length > 20)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Password", 20);
                }
                if (Password.Length < 8)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Password", 8);
                }
            }
            if (ConfirmPassword != null)
            {
                if (ConfirmPassword.Length > 20)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ConfirmPassword", 20);
                }
                if (ConfirmPassword.Length < 8)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ConfirmPassword", 8);
                }
            }
            if (FirstName != null)
            {
                if (FirstName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FirstName", 50);
                }
            }
            if (LastName != null)
            {
                if (LastName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LastName", 50);
                }
            }
            if (Address != null)
            {
                if (Address.Length > 150)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Address", 150);
                }
            }
            if (ContactMobile != null)
            {
                if (ContactMobile.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ContactMobile", 10);
                }
                if (ContactMobile.Length < 9)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ContactMobile", 9);
                }
            }
        }
    }
}
