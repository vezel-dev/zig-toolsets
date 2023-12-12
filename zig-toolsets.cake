#nullable enable

// Arguments

var target = Argument("t", "default");

// Environment

var nugetToken = EnvironmentVariable("NUGET_TOKEN");

// Paths

var root = Context.Environment.WorkingDirectory;
var zigToolsetsProj = root.CombineWithFilePath("zig-toolsets.proj");
var @out = root.Combine("out");
var outLog = @out.Combine("log");
var outPkg = @out.Combine("pkg");

// Globs

var nugetGlob = new GlobPattern(outPkg.Combine("release").CombineWithFilePath("*.nupkg").FullPath);

// Utilities

DotNetMSBuildSettings ConfigureMSBuild(string target)
{
    var prefix = $"{target}_{Environment.UserName}_{Environment.MachineName}_";
    var time = DateTime.Now;

    string name;

    do
    {
        name = $"{prefix}{time:yyyy-MM-dd_HH_mm_ss}.binlog";
        time = time.AddSeconds(1);
    }
    while (System.IO.File.Exists(name));

    return new()
    {
        // TODO: https://github.com/dotnet/msbuild/issues/6756
        NoLogo = true,
        BinaryLogger = new()
        {
            Enabled = true,
            FileName = outLog.CombineWithFilePath(name).FullPath,
        },
        ConsoleLoggerSettings = new()
        {
            NoSummary = true,
        },
        ArgumentCustomization = args => args.Append("-ds:false"),
    };
}

// Tasks

Task("default")
    .IsDependentOn("build")
    .IsDependentOn("pack");

Task("restore")
    .Does(() =>
        DotNetRestore(
            zigToolsetsProj.FullPath,
            new()
            {
                MSBuildSettings = ConfigureMSBuild("restore"),
            }));

Task("build")
    .IsDependentOn("restore")
    .Does(() =>
        DotNetBuild(
            zigToolsetsProj.FullPath,
            new()
            {
                MSBuildSettings = ConfigureMSBuild("build"),
                NoRestore = true,
            }));

Task("pack")
    .IsDependentOn("build")
    .Does(() =>
        DotNetPack(
            zigToolsetsProj.FullPath,
            new()
            {
                MSBuildSettings = ConfigureMSBuild("pack"),
                NoBuild = true,
            }));

Task("upload")
    .WithCriteria(BuildSystem.GitHubActions.Environment.Workflow.Ref.StartsWith("refs/tags/v"))
    .IsDependentOn("pack")
    .Does(() =>
        DotNetNuGetPush(
            nugetGlob.Pattern,
            new()
            {
                Source = "https://api.nuget.org/v3/index.json",
                ApiKey = nugetToken,
                SkipDuplicate = true,
            }));

RunTarget(target);
