namespace Shuck
open System

[<AutoOpen>]
module Types = 

    type Id = string
    type Line = string
    type Text = string
    type Url = Uri 
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

    module Mock = 
        let postcasts : Podcasts = [
            ({
              Id = "012345"
              Name = "This Week in Tech"
              Url = Uri("http://twit.tv/show/this-week-in-tech")
              Description = """Your first podcast of the week is the last word in tech. 
              Join the top tech pundits in a roundtable discussion of the latest trends in high tech.
              Records live every Sunday at 3:00pm PT/6:00pm ET."""
              LastChanged = DateTime(2015, 02, 25,5,3,10)
             }, [])
        ] 