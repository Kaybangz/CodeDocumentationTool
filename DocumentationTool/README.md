# Code Documentation Tool

A custom attribute used as code-documentation tool 

## Description

A custom attribute used to annotate types such as classes, methods, properties, enums etc. 


## Getting Started

### Prerequisite

* .NET Standard 2.0.
* C#
* Basic knowledge of attribute usage in C#

### Usage

* The custom attribute takes 3 parameters, one required ``Description`` parameter and two optional parameters, ``Input`` and ``Output``

* Annotate any type or types by placing the custom attribute above

```csharp

[CustomAttribute("Required description", Input = "Optional input", Output = "Optional output")]
public class MyClass 
{
	//
}

[CustomAttribute("Required description", Input = "Optional input", Output = "Optional output")]
public enum Gender{
	Male,
	Female
}
...

```