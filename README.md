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
