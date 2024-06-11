# Release

When a new Zig version is released, the process is as follows:

* Update property values in [`Directory.Build.props`](Directory.Build.props).
    * Set `ZigVersion` to the official Zig version.
    * Reset `ToolsetVersion` to `1`.
* Commit the change.
* Tag a release with
  `git tag v$(ZigVersion).$(ToolsetVersion) -m v$(ZigVersion).$(ToolsetVersion) -s`
  (e.g. `v0.13.0.1`).
* Push the commit and the tag.
* Edit the draft release on GitHub to add a link to the Zig release, such as
  [this one](https://github.com/ziglang/zig/releases/tag/0.13.0).
* Publish the release on GitHub.

Fresh NuGet packages will then be built and published by an automatic workflow.
