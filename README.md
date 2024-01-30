# Zig Toolsets

<div align="center">
    <img src="zig.svg"
         width="128"
         alt="Zig Toolsets" />
</div>

<p align="center">
    <strong>
        The Zig compiler and standard library packaged for use in MSBuild.
    </strong>
</p>

<div align="center">

[![License](https://img.shields.io/badge/license-0BSD%20AND%20MIT-brown)](LICENSE-0BSD)
[![Commits](https://img.shields.io/github/commit-activity/m/vezel-dev/zig-toolsets/master?label=commits&color=slateblue)](https://github.com/vezel-dev/zig-toolsets/commits/master)
[![Build](https://img.shields.io/github/actions/workflow/status/vezel-dev/zig-toolsets/build.yml?branch=master)](https://github.com/vezel-dev/zig-toolsets/actions/workflows/build.yml)
[![Discussions](https://img.shields.io/github/discussions/vezel-dev/zig-sdk?color=teal)](https://github.com/vezel-dev/zig-sdk/discussions)
[![Discord](https://img.shields.io/discord/960716713136095232?color=peru&label=discord)](https://discord.gg/GE88ZrPg8j)

</div>

---

This project packs and distributes the [Zig](https://ziglang.org) compiler and
standard library in a set of NuGet packages for each platform that .NET runs on.
These packages are mainly used by the [Zig SDK](https://docs.vezel.dev/zig-sdk)
but can also be used by other projects.

* For every official release of Zig, a set of NuGet packages with the name
  pattern `Vezel.Zig.Toolsets.<rid>` is published, where `<rid>` is replaced
  with `linux-arm64`, `osx-x64`, `win-x86`, etc.
* Only the RIDs that .NET runs on are covered (so e.g.
  `Vezel.Zig.Toolsets.linux-x86` is *not* available).
* The package version matches the official Zig release's version, with an extra
  fourth component added indicating the packaging version.

## Usage

This project offers the following packages:

| Package | Description | Downloads |
| -: | - | :- |
| [![Vezel.Zig.Toolsets.linux-arm][linux-arm-img]][linux-arm-pkg] | Provides the toolset for the `linux-arm` build platform. | ![Downloads][linux-arm-dls] |
| [![Vezel.Zig.Toolsets.linux-arm64][linux-arm64-img]][linux-arm64-pkg] | Provides the toolset for the `linux-arm64` build platform. | ![Downloads][linux-arm64-dls] |
| [![Vezel.Zig.Toolsets.linux-ppc64le][linux-ppc64le-img]][linux-ppc64le-pkg] | Provides the toolset for the `linux-ppc64le` build platform. | ![Downloads][linux-ppc64le-dls] |
| [![Vezel.Zig.Toolsets.linux-riscv64][linux-riscv64-img]][linux-riscv64-pkg] | Provides the toolset for the `linux-riscv64` build platform. | ![Downloads][linux-riscv64-dls] |
| [![Vezel.Zig.Toolsets.linux-x64][linux-x64-img]][linux-x64-pkg] | Provides the toolset for the `linux-x64` build platform. | ![Downloads][linux-x64-dls] |
| [![Vezel.Zig.Toolsets.osx-arm64][osx-arm64-img]][osx-arm64-pkg] | Provides the toolset for the `osx-arm64` build platform. | ![Downloads][osx-arm64-dls] |
| [![Vezel.Zig.Toolsets.osx-x64][osx-x64-img]][osx-x64-pkg] | Provides the toolset for the `osx-x64` build platform. | ![Downloads][osx-x64-dls] |
| [![Vezel.Zig.Toolsets.win-arm64][win-arm64-img]][win-arm64-pkg] | Provides the toolset for the `win-arm64` build platform. | ![Downloads][win-arm64-dls] |
| [![Vezel.Zig.Toolsets.win-x64][win-x64-img]][win-x64-pkg] | Provides the toolset for the `win-x64` build platform. | ![Downloads][win-x64-dls] |
| [![Vezel.Zig.Toolsets.win-x86][win-x86-img]][win-x86-pkg] | Provides the toolset for the `win-x86` build platform. | ![Downloads][win-x86-dls] |

[linux-arm-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-arm
[linux-arm64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-arm64
[linux-ppc64le-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-ppc64le
[linux-riscv64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-riscv64
[linux-x64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-x64
[osx-arm64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.osx-arm64
[osx-x64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.osx-x64
[win-arm64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-arm64
[win-x64-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-x64
[win-x86-pkg]: https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-x86

[linux-arm-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.linux-arm?label=Vezel.Zig.Toolsets.linux-arm
[linux-arm64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.linux-arm64?label=Vezel.Zig.Toolsets.linux-arm64
[linux-ppc64le-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.linux-ppc64le?label=Vezel.Zig.Toolsets.linux-ppc64le
[linux-riscv64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.linux-riscv64?label=Vezel.Zig.Toolsets.linux-riscv64
[linux-x64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.linux-x64?label=Vezel.Zig.Toolsets.linux-x64
[osx-arm64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.osx-arm64?label=Vezel.Zig.Toolsets.osx-arm64
[osx-x64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.osx-x64?label=Vezel.Zig.Toolsets.osx-x64
[win-arm64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.win-arm64?label=Vezel.Zig.Toolsets.win-arm64
[win-x64-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.win-x64?label=Vezel.Zig.Toolsets.win-x64
[win-x86-img]: https://img.shields.io/nuget/v/Vezel.Zig.Toolsets.win-x86?label=Vezel.Zig.Toolsets.win-x86

[linux-arm-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.linux-arm?label=
[linux-arm64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.linux-arm64?label=
[linux-ppc64le-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.linux-ppc64le?label=
[linux-riscv64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.linux-riscv64?label=
[linux-x64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.linux-x64?label=
[osx-arm64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.osx-arm64?label=
[osx-x64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.osx-x64?label=
[win-arm64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.win-arm64?label=
[win-x64-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.win-x64?label=
[win-x86-dls]: https://img.shields.io/nuget/dt/Vezel.Zig.Toolsets.win-x86?label=

To install a package, run `dotnet add package <name>`.

The following MSBuild properties will be injected into your project:

* `ZigToolsetPath`: Path to the extracted toolset package directory in the NuGet
  package cache.
* `ZigExePath`: Path to the Zig compiler executable (`zig` or `zig.exe`).
* `ZigLibPath`: Path to the Zig standard library.
* `ZigDocPath`: Path to the Zig standard library documentation.

## Building

You will need the .NET SDK installed. Simply run `./cake`
(a [Bash](https://www.gnu.org/software/bash) script) to build artifacts.

Note that, on Windows, you must have a `tar` program capable of extracting
`.tar.xz` archives. For example, `tar` from
[Git for Windows](https://gitforwindows.org) or [MSYS2](https://www.msys2.org)
will satisfy this requirement.

## License

This project is licensed under the terms found in
[`LICENSE-0BSD`](LICENSE-0BSD).

The Zig compiler and standard library are licensed under the terms found in
[`LICENSE-MIT`](LICENSE-MIT).

The Zig logo is licensed under the terms found in
[`LICENSE-CC-BY-SA-4.0`](LICENSE-CC-BY-SA-4.0).
