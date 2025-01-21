# Summary
I think the TIL here is https://learn.microsoft.com/en-us/dotnet/fsharp/style-guide/conventions#partial-application-and-point-free-programming

F# supports partial application, and thus, various ways to program in a point-free style. This can be beneficial for code reuse within a module or the implementation of something, but it is not something to expose publicly. In general, point-free programming is not a virtue in and of itself, and can add a significant cognitive barrier for people who are not immersed in the style.

# fsharpnull

Point free stuff gives nullpointer when referenced

```
dotnet run --project .\project1\project1.fsproj
dotnet run --project .\project2\project2.fsproj
```
It gets compiled to a FSharpFunc and that somehow gives null pointer when referenced.

<img width="821" alt="image" src="https://github.com/user-attachments/assets/d2396b8d-a921-40e5-bb75-eef3bdf1b852" />

They only look the same in code and within the same project.
<img width="352" alt="image" src="https://github.com/user-attachments/assets/bbbf6f4f-4faf-4414-97f7-f7716fab50e9" />

This is not the same signature
<img width="429" alt="image" src="https://github.com/user-attachments/assets/32f44522-d9e6-4e3d-b926-4bc3e9eeafa2" />


# For once I agree with CoPilot and we are both wrong

<img width="587" alt="image" src="https://github.com/user-attachments/assets/7c20d015-5825-4490-b03a-3cffc44cea40" />

https://github.com/fsharp/fsharp-compiler-docs/issues/838

# IL Spy
## Normal
<img width="580" alt="image" src="https://github.com/user-attachments/assets/2ca5086f-5a2b-471b-a1f9-833bbace5d67" />

## Point free
<img width="672" alt="image" src="https://github.com/user-attachments/assets/23363fef-6376-45d5-b0dc-ad4e8e88342c" />


<img width="424" alt="image" src="https://github.com/user-attachments/assets/72a4a4c5-529f-41e0-9762-b1e81e0e11e4" />
