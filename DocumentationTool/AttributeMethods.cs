using System;
using System.Reflection;

namespace DocumentationTool
{
    public static class AttributeMethods
    {
        public static void GetClasses(Type type)
        {
            Console.WriteLine($"CLASS NAME: {type.Name.ToUpper()}\n");

            object[] listClasses = type.GetCustomAttributes(true);

            foreach (Attribute item in listClasses)
            {
                CustomAttributeAttribute storeItem;

                if (item is CustomAttributeAttribute)
                {
                    storeItem = (CustomAttributeAttribute)item;

                    Console.WriteLine($"Desciption: \n\t{storeItem.Description}\n");
                }
                
            }
        }

        public static void GetProperties(Type type)
        {
            Console.WriteLine($"PROPERTIES OF CLASS {type.Name.ToUpper()}");

            PropertyInfo[] listProperties = type.GetProperties();

            for (int i = 0; i < listProperties.GetLength(0); i++)
            {
                object[] attributesArray = listProperties[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttributeAttribute)
                    {
                        CustomAttributeAttribute propertyStore = (CustomAttributeAttribute)item;
                        Console.WriteLine($"PROPERTY NAME: {listProperties[i].Name} \n\tDescription: {propertyStore.Description}\n\tInput: {propertyStore.Input} \n\tOutput: {propertyStore.Output}\n\n");
                    }
                }
            }
        }
    

        public static void GetFields(Type type)
        {
            Console.WriteLine($"FIELDS OF CLASS {type.Name.ToUpper()}\n");

            FieldInfo[] listFields = type.GetFields();

            for (int i = 0; i < listFields.GetLength(0); i++)
            {
                object[] attributesArray = listFields[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttributeAttribute)
                    {
                        CustomAttributeAttribute fieldStore = (CustomAttributeAttribute)item;
                        Console.WriteLine($"FIELD NAME: {listFields[i].Name} \n\tDescription: {fieldStore.Description}\n\tInput: {fieldStore.Input} \n\tOutput: {fieldStore.Output}\n\n");
                    }
                }
            }
        }

        public static void GetMethods(Type type)
        {
            Console.WriteLine($"METHODS OF CLASS {type.Name.ToUpper()}");

            MethodInfo[] listMethods = type.GetMethods();


            for (int i = 0; i < listMethods.GetLength(0); i++)
            {
                object[] attributesArray = listMethods[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttributeAttribute)
                    {
                        CustomAttributeAttribute methodStore = (CustomAttributeAttribute)item;
                        Console.WriteLine($"METHOD NAME: {listMethods[i].Name} \n\tDescription: {methodStore.Description}\n\tInput: {methodStore.Input} \n\tOutput: {methodStore.Output}\n\n");
                    }
                }
            }
        }

    }
}
