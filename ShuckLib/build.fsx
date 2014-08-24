// include Fake lib
#r @"../packages/FAKE.3.2.17/tools/FakeLib.dll"
open Fake

// Properties
let buildDir = "./bin/"

// Targets
Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "BuildApp" (fun _ ->
    !! "*.fsproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "Default" (fun _ ->
    trace "Hello World from FAKE"
)

// Dependencies
"Clean"
  ==> "BuildApp"
  ==> "Default"

// start build
RunTargetOrDefault "Default"