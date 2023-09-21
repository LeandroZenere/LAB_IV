using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Clase2.Helpers
{
    public class TagHelperCustomizado : TagHelper
    {
        public string customMailPrueba { get; set; }
        public string customMail { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output) {
            //base.Process(context, output);
            output.TagName = "a";
            //output.Attributes.SetAttribute("href", "mailto:leandrozenere@gmail.com")
            output.Attributes.SetAttribute("href", $"mailto:{customMail}");
            output.Attributes.SetAttribute("style", "font-family:arial black");
            output.Attributes.Add("id", "custom_mail");
            output.Content.SetContent("Email Leandro Zénere");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
