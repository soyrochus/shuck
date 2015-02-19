namespace Shuck
open System

module Repositories = 
    open Shuck.Types
    type Repository = 
        abstract GetPodcasts: unit -> Podcasts 


    type MockRepository () = 
        interface Repository with 
            member v.GetPodcasts () = Mock.postcasts
               

