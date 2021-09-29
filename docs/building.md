# Build and Tests

### **Building the projects**


```bash
dotnet build
```

Yes thats it! all projects are built using a composite msbuild file [build.proj](../build.proj)

Things to note

- As part of the build command, projects are compiled, including building the test project. 
- Test are not executed as part of this command.

### **Unit Testing**


```bash
dotnet test
```

All tests are run using this command and summary output available.
