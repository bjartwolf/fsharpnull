# Summary
I think the TIL is that exposing functions in the point free style accross assemblies is not a good idea, but there is something weirder in here with top-level statements and fsharpfunc.

https://learn.microsoft.com/en-us/dotnet/fsharp/style-guide/conventions#partial-application-and-point-free-programming
> F# supports partial application, and thus, various ways to program in a point-free style. This can be beneficial for code reuse within a module or the implementation of something, but it is not something to expose publicly. In general, point-free programming is not a virtue in and of itself, and can add a significant cognitive barrier for people who are not immersed in the style.

# fsharpnull

Point free function gives nullpointer when referenced from an project, when the project with the point free function is a console app without an explicit main method.

```
dotnet run --project .\project1\project2.fsproj
```
It gets compiled to a FSharpFunc and that somehow gives null pointer when there is no main method explictly defined.

<img width="839" alt="image" src="https://github.com/user-attachments/assets/6fc761cd-e023-474d-9726-3cb7acb223bf" />

# IL Spy
## Normal
<img width="580" alt="image" src="https://github.com/user-attachments/assets/2ca5086f-5a2b-471b-a1f9-833bbace5d67" />

## Point free
<img width="672" alt="image" src="https://github.com/user-attachments/assets/23363fef-6376-45d5-b0dc-ad4e8e88342c" />


<img width="424" alt="image" src="https://github.com/user-attachments/assets/72a4a4c5-529f-41e0-9762-b1e81e0e11e4" />
