namespace Shuck
open System


module Podcasts = 
    open Shuck.Repositories
    let getPodcasts (repos: Repository) : Podcasts = 
        repos.GetPodcasts ()

