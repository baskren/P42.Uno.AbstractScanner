# How to generate an iOS native binding library

https://github.com/dotnet/maui/issues/7755#issuecomment-1211419088
https://github.com/xamarin/xamarin-macios/issues/17449

1. Create binding project:
```
dotnet new iosbinding -o [your_project_name_here]
```

2. Add your native framework or static library:
    Open your binding csproj and add a section like this
```xml    
<ItemGroup>
   <NativeReference Include="MyLibrary.xcframework">
     <Kind>Framework</Kind>
     <Frameworks></Frameworks>
   </NativeReference>
 </ItemGroup>
 ```

2. Customize it for your specific library:
  - Change the Include to the correct path/name of your library
  - Change Kind to Static (.a) or Framework (.framework/.xcframework) based upon the library kind and extension.
    - Dynamic (.dylib) is a third option but rarely if ever valid, and only on macOS and Mac Catalyst
  - If your library depends on other frameworks, add them inside `<Frameworks></Frameworks>`
 
Example:
```
<NativeReference Include="libs\MyTestFramework.xcframework">
   <Kind>Framework</Kind>
   <Frameworks>CoreLocation ModelIO</Frameworks>
 </NativeReference>
 ```

3. move on to binding the API...

   Here is where you'd define your API definition for the native Objective-C library.

   For example, to bind the following Objective-C class:

```objectivec
     @interface Widget : NSObject {
     }
```

The C# binding would look like this:
```csharp
     [BaseType (typeof (NSObject))]
     interface Widget {
     }
```

To bind Objective-C properties, such as:
```objectivec
     @property (nonatomic, readwrite, assign) CGPoint center;
```
You would add a property definition in the C# interface like so:
```csharp
     [Export ("center")]
     CGPoint Center { get; set; }
```
To bind an Objective-C method, such as:
```objectivec
     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
```
You would add a method definition to the C# interface like so:
```csharp
     [Export ("doSomething:atIndex:")]
     void DoSomething (NSObject object, nint index);
```
Objective-C "constructors" such as:
```objectivec
     -(id)initWithElmo:(ElmoMuppet *)elmo;
```
Can be bound as:
```csharp
     [Export ("initWithElmo:")]
     NativeHandle Constructor (ElmoMuppet elmo);
```

For more information, see https://aka.ms/ios-binding
