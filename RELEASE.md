# Release

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
