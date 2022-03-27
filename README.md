# Zig MSBuild Toolsets

<div align="center">
    <img src="zig.svg"
         width="128" />
</div>

<p align="center">
    <strong>
        The Zig compiler and standard library packaged for use in MSBuild.
    </strong>
</p>

<div align="center">

[![License](https://img.shields.io/badge/license-0BSD%20AND%20MIT-brown)](LICENSE.md)
[![Commits](https://img.shields.io/github/commit-activity/m/vezel-dev/zig-msbuild-toolsets/master?label=commits&color=slateblue)](https://github.com/vezel-dev/zig-msbuild-toolsets/commits/master)
[![Build](https://img.shields.io/github/workflow/status/vezel-dev/zig-msbuild-toolsets/Build/master)](https://github.com/vezel-dev/zig-msbuild-toolsets/actions/workflows/build.yml)

</div>

---

This project packs and distributes the [Zig](https://ziglang.org) compiler and
standard library in a set of NuGet packages. These packages are mainly used by
the [Zig MSBuild SDK](https://github.com/vezel-dev/zig-msbuild-sdk) but can also
be used by other projects.

* For every official release of Zig, a set of NuGet packages with the name
  pattern `Zig.Toolset.<rid>` will be published, where `<rid>` is replaced with
  `linux-arm64`, `osx-x64`, `win-x86`, etc.
* Only the RIDs that .NET runs on will be covered (so e.g.
  `Zig.Toolset.linux-riscv64` will *not* be available).
* The package version will match the official Zig release's version, with an
  extra fourth component added indicating the packaging version.

## Usage

This project offers the following packages:

| Package | Description | Downloads |
| -: | - | :- |
| [![Zig.Toolset.linux-arm][linux-arm-img]][linux-arm-pkg] | Toolset for the `linux-arm` build platform. | ![Downloads][linux-arm-dls] |
| [![Zig.Toolset.linux-arm64][linux-arm64-img]][linux-arm64-pkg] | Toolset for the `linux-arm64` build platform. | ![Downloads][linux-arm64-dls] |
| [![Zig.Toolset.linux-x64][linux-x64-img]][linux-x64-pkg] | Toolset for the `linux-x64` build platform. | ![Downloads][linux-x64-dls] |
| [![Zig.Toolset.osx-arm64][osx-arm64-img]][osx-arm64-pkg] | Toolset for the `osx-arm64` build platform. | ![Downloads][osx-arm64-dls] |
| [![Zig.Toolset.osx-x64][osx-x64-img]][osx-x64-pkg] | Toolset for the `osx-x64` build platform. | ![Downloads][osx-x64-dls] |
| [![Zig.Toolset.win-arm64][win-arm64-img]][win-arm64-pkg] | Toolset for the `win-arm64` build platform. | ![Downloads][win-arm64-dls] |
| [![Zig.Toolset.win-x64][win-x64-img]][win-x64-pkg] | Toolset for the `win-x64` build platform. | ![Downloads][win-x64-dls] |
| [![Zig.Toolset.win-x86][win-x86-img]][win-x86-pkg] | Toolset for the `win-x86` build platform. | ![Downloads][win-x86-dls] |

[linux-arm-pkg]: https://www.nuget.org/packages/Zig.Toolset.linux-arm
[linux-arm64-pkg]: https://www.nuget.org/packages/Zig.Toolset.linux-arm64
[linux-x64-pkg]: https://www.nuget.org/packages/Zig.Toolset.linux-x64
[osx-arm64-pkg]: https://www.nuget.org/packages/Zig.Toolset.osx-arm64
[osx-x64-pkg]: https://www.nuget.org/packages/Zig.Toolset.osx-x64
[win-arm64-pkg]: https://www.nuget.org/packages/Zig.Toolset.win-arm64
[win-x64-pkg]: https://www.nuget.org/packages/Zig.Toolset.win-x64
[win-x86-pkg]: https://www.nuget.org/packages/Zig.Toolset.win-x86

[linux-arm-img]: https://img.shields.io/nuget/v/Zig.Toolset.linux-arm?label=Zig.Toolset.linux-arm
[linux-arm64-img]: https://img.shields.io/nuget/v/Zig.Toolset.linux-arm64?label=Zig.Toolset.linux-arm64
[linux-x64-img]: https://img.shields.io/nuget/v/Zig.Toolset.linux-x64?label=Zig.Toolset.linux-x64
[osx-arm64-img]: https://img.shields.io/nuget/v/Zig.Toolset.osx-arm64?label=Zig.Toolset.osx-arm64
[osx-x64-img]: https://img.shields.io/nuget/v/Zig.Toolset.osx-x64?label=Zig.Toolset.osx-x64
[win-arm64-img]: https://img.shields.io/nuget/v/Zig.Toolset.win-arm64?label=Zig.Toolset.win-arm64
[win-x64-img]: https://img.shields.io/nuget/v/Zig.Toolset.win-x64?label=Zig.Toolset.win-x64
[win-x86-img]: https://img.shields.io/nuget/v/Zig.Toolset.win-x86?label=Zig.Toolset.win-x86

[linux-arm-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.linux-arm?label=
[linux-arm64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.linux-arm64?label=
[linux-x64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.linux-x64?label=
[osx-arm64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.osx-arm64?label=
[osx-x64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.osx-x64?label=
[win-arm64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.win-arm64?label=
[win-x64-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.win-x64?label=
[win-x86-dls]: https://img.shields.io/nuget/dt/Zig.Toolset.win-x86?label=

To install a package, run `dotnet add package <name>`.

The following MSBuild properties will be injected into your project:

* `ZigToolsetPath`: Path to the extracted toolset package directory in the NuGet
  package cache.
* `ZigExePath`: Path to the Zig compiler executable (`zig` or `zig.exe`).
* `ZigLibPath`: Path to the Zig standard library.
* `ZigDocPath`: Path to the Zig standard library documentation.
