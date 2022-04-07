# Zig Toolsets

This project packs and distributes the [Zig](https://ziglang.org) compiler and
standard library in a set of NuGet packages for each platform that .NET runs on.
These packages are mainly used by
[Zig.Sdk](https://github.com/vezel-dev/zig-sdk) but can also be used by other
projects.

* For every official release of Zig, a set of NuGet packages with the name
  pattern `Vezel.Zig.Toolsets.<rid>` is published, where `<rid>` is replaced
  with `linux-arm64`, `osx-x64`, `win-x86`, etc.
* Only the RIDs that .NET runs on are covered (so e.g.
  `Vezel.Zig.Toolsets.linux-riscv64` is *not* available).
* The package version matches the official Zig release's version, with an extra
  fourth component added indicating the packaging version.

This project offers the following packages:

* [Vezel.Zig.Toolsets.linux-arm](https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-arm):
  Provides the toolset for the `linux-arm` build platform.
* [Vezel.Zig.Toolsets.linux-arm64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-arm64):
  Provides the toolset for the `linux-arm64` build platform.
* [Vezel.Zig.Toolsets.linux-x64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.linux-x64):
  Provides the toolset for the `linux-x64` build platform.
* [Vezel.Zig.Toolsets.osx-arm64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.osx-arm64):
  Provides the toolset for the `osx-arm64` build platform.
* [Vezel.Zig.Toolsets.osx-x64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.osx-x64):
  Provides the toolset for the `osx-x64` build platform.
* [Vezel.Zig.Toolsets.win-arm64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-arm64):
  Provides the toolset for the `win-arm64` build platform.
* [Vezel.Zig.Toolsets.win-x64](https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-x64):
  Provides the toolset for the `win-x64` build platform.
* [Vezel.Zig.Toolsets.win-x86](https://www.nuget.org/packages/Vezel.Zig.Toolsets.win-x86):
  Provides the toolset for the `win-x86` build platform.
