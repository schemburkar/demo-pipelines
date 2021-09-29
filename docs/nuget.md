# Packaging and References

### **Packaging**

All class library projects are auto pacakged as nuget on local directory. 
These can be pushed to a nuget server or GitHub pacakges if needed.

```xml
<PackageId>$(PackagePrefix)$(MSBuildProjectName)</PackageId>
<PackageVersion>$(PackageReferenceVersion)</PackageVersion>
<GeneratePackageOnBuild>true</GeneratePackageOnBuild>
```

### **References**

Between projects, all references are driven through nuget, served from local directory ```localsources```.

```xml
<ItemGroup>
  <PackageReference Include="$(PackagePrefix)Core" Version="$(PackageReferenceVersion)" />
</ItemGroup>
```
