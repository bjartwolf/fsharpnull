# Summary
I think the TIL is that exposing functions in the point free style accross assemblies is not a good idea, but there is something wrong in here with top-level statements and fsharpfunc where something is not initialized properly and throws null pointer.

https://learn.microsoft.com/en-us/dotnet/fsharp/style-guide/conventions#partial-application-and-point-free-programming
> F# supports partial application, and thus, various ways to program in a point-free style. This can be beneficial for code reuse within a module or the implementation of something, but it is not something to expose publicly. In general, point-free programming is not a virtue in and of itself, and can add a significant cognitive barrier for people who are not immersed in the style.

# fsharpnull

Point free function gives nullpointer when referenced from an project, when the project with the point free function is a console app without an explicit main method.

```
dotnet run --project .\console_host\console_host.fsproj
```
The point free version gets compiled to a FSharpFunc and that somehow gives null pointer when there is no main method explictly defined.

<img width="805" alt="image" src="https://github.com/user-attachments/assets/49488d82-b618-4a42-b800-2ca55f504c21" />

The code does work when running from the project itself, just when refernced, as with a unit test project it fails.
<img width="810" alt="image" src="https://github.com/user-attachments/assets/a1a90057-134e-4aa4-a238-74ee86edef6a" />
