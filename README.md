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
