// include Fake lib
#r @"../packages/FAKE.3.2.17/tools/FakeLib.dll"
open Fake

// Default target
Target "Default" (fun _ ->
    trace "Hello World from FAKE"
)

// start build
RunTargetOrDefault "Default"