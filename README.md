# Zig MSBuild Toolsets

This project packs and distributes the [Zig](https://ziglang.org) compiler and
standard library in a set of NuGet packages. These packages are mainly used by
the [Zig MSBuild SDK](https://github.com/vezel-dev/zig-msbuild-sdk) but can also be
used by other projects.

* For every official release of Zig, a set of NuGet packages with the name pattern
  `Zig.Toolset.<rid>` will be published, where `<rid>` is replaced with
  `linux-arm64`, `osx-x64`, `win-x86`, etc.
* Only the RIDs that .NET runs on will be covered (so e.g.
  `Zig.Toolset.linux-riscv64` will not be available).
* The package version will match the official Zig release's version, with an
  extra fourth component added indicating the packaging version.

## Statistics

![Repobeats](https://repobeats.axiom.co/api/embed/c54ba3a665be3c1daae5ea6985ff99e11b51c458.svg)
