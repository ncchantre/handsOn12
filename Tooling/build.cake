Task("Build")
    .Does(() =>
{
    DotNetBuild("./Tooling.csproj");
});

RunTarget("Build");
