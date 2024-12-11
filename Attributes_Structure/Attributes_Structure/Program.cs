

//[My(value:"Test Constructor", Name = "Nijat", Surname ="Huseynov", age = field)]
//class MyClass
//{

//}


//[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
//public class MyAttribute:Attribute
//{

//    public MyAttribute(string value)
//    {

//    }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int age ;
//    public void Test(){}
//}

//using System.Reflection;

//[assembly: AssemblyTitle("car-title")]
//[Car(Mark = "Toyota", Year = 2022, Color = color)]
//class Car
//{
//    const string color = "green";
//}


//[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
//class CarAttribute:Attribute
//{
//    public int Year { get; set; }
//    public string Mark { get; set; }
//    public string  Color { get; set; }
//}




//#region Attribute & Assembly
//using System.Reflection;

//Assembly assembly = Assembly.GetExecutingAssembly();
//var types = assembly.GetTypes()
//    .Where(t => t.GetCustomAttribute<TestAttribute>() is not null)
//    .ToList();

//foreach (var type in types)
//{
//    var myCustomAttribute = type.GetCustomAttribute<TestAttribute>();
//    Console.WriteLine($"{type.Name}: {myCustomAttribute!.Description} ");
//}



//[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
//class TestAttribute : Attribute
//{
//    public string Description { get; set; }
//}

//[TestAttribute(Description = "My Class 1")]
//class MyClass1 { }

//class MyClass2 { }

//[TestAttribute(Description = "My Class 2")]
//class MyClass3 { }
//#endregion




#region Generic Attributes




[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class MyGenericAttribute<T>:Attribute
{
    public T MyProperty { get; set; }
}

[MyGeneric<string>(MyProperty = "bura verilen tipde olmalidir")]
class MyClass
{

}



#endregion
