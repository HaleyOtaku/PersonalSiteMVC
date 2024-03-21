using System.ComponentModel.DataAnnotations;//added for access to annotations for validation

namespace PersonalSiteMVC.UI.Models
{
    public class ContactViewModel
    {
        //We can use Data Annotations to add validation to our model.
        //This is useful when we have required fields or need data with certain formatting,
        //as it allows us to verify those conditions are met and display messages
        //in the front end to let the user know what to do:

        //Annotations ALWAYS go above + space from prop they apply to

        [Required(ErrorMessage = "*Name is required")]//Makes the field required 
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "*Email is required")]

        [DataType(DataType.EmailAddress)]//This ensures minimal email formatting (chars + @ + chars + . + chars)

        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "*Subject is required")]

        public string Subject { get; set; } = null!;

        [Required(ErrorMessage = "*Message is required")]
        [DataType(DataType.MultilineText)]//This ensures the textbox will be larger than an input tag
        public string Message { get; set; } = null!;

    }
}
