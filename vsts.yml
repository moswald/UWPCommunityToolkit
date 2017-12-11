queue:
  name: Hosted VS2017

steps:
- task: PowerShell@2
  inputs:
    targetType: "inline"
    script: "git config --global core.autocrlf true"

- task: PowerShell@2
  inputs:
    filePath: "./build/build.ps1"
    arguments: "-target=SignNuGet"

- task: artifactcrewinternal.build-tasks-dev.artifactDropTask-1.artifactDropTask@0
  inputs:
    dropServiceURI: "https://buildcanary.artifacts.visualstudio.com/DefaultCollection"
    sourcePath: "$(Build.SourcesDirectory)\\bin\\nupkg"
    detailedLog: "true"
    retentionDays: "10"
