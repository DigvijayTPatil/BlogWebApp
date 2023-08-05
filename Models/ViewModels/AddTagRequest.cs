// step 21: Model Binding : when submit button is clicked, the model as a whole 
// comes into the action method of AddTags 


namespace BlogWebApp.Models.ViewModels
{
    public class AddTagRequest
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
// step 22: now to bind the model go to Add.cshtml