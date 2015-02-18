namespace Schuck
open System

module Types = 

    type Id = string
    type Line = string
    type Text = string
    type Url = string 
    type Date = DateTime
    type EpisodeStatus = 
        | New
        | Untouched
        | Touched

    type PodcastInfo = {
            Id: Id
            Name: Line
            Url: Url
            Description: Text
            LastChanged: Date
    }
    
    type Episode = {
        Id: Id
        Number: Line
        Name: Line
        Url: Url
        Description: Text 
        Published: Date
        Status: EpisodeStatus
    }
    type Podcast = PodcastInfo * Episode list 
    type Podcasts = Podcast list

