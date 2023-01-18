using System;


namespace DocumentationTool
{

    public delegate void GetDocs();
    public class CustomAttributeAttribute : Attribute
    {
        public string Description { get; }
        public string Input { get; set; }
        public string Output { get; set; }

        public CustomAttributeAttribute(string description)
        {
            Description = description;
           
        }

        

    }
}
