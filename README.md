# Zig MSBuild Toolsets

This project packs and distributes the [Zig](https://ziglang.org) compiler and
standard library in a set of NuGet packages. These packages are mainly used by
the [Zig MSBuild SDK](https://github.com/alexrp/zig-msbuild-sdk) but can also be
used by other projects.

* For every official release of Zig, a set of NuGet packages with the name pattern
  `Zig.Toolset.<rid>` will be published, where `<rid>` is replaced with
  `linux-arm64`, `osx-x64`, `win-x86`, etc.
* Only the RIDs that are relevant to the .NET ecosystem will be covered (so e.g.
  `Zig.Toolset.linux-riscv64` will not be available).
* The package version will match the official Zig release's version.

When a new Zig version is released, the process is as follows:

* Update the `Version` property in
  [`Directory.Build.props`](Directory.Build.props).
* Commit the change.
* Tag a release as e.g. `v0.8.0`.
* Push the commit and the tag.
* Edit the draft release on GitHub to add a release note link, such as
  [this one](https://ziglang.org/download/0.8.0/release-notes.html).
* Publish the release on GitHub.

Fresh NuGet packages will then be built and published by an automatic workflow.
