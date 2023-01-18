using System;


namespace DocumentationTool
{
    public class CustomAttributeAttribute : Attribute
    {
        public string Description { get; }
        public string Input { get; set; }
        public string Output { get; set; }

        public CustomAttributeAttribute(string description)
        {
            Description = description;
           
        }

        public static void GetDocs(Type type)
        {
            AttributeMethods.GetClasses(type);
            AttributeMethods.GetFields(type);
            AttributeMethods.GetProperties(type);
            AttributeMethods.GetMethods(type);
        }

    }
}
