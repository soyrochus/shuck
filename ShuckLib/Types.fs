(* Copyright (c) 2014, Iwan van der Kleijn (iwanvanderkleijn@gmail.com) - see the file LICENSE for details *) 
module shuck.Types

type FileRef = Url of string | FileName of string
type Image = FileRef | Base64 of string

type Media = Audio of FileRef | Video of FileRef
type EpisodeState = New | Available | Downloaded | Local
type Date = DateString of string | DateRef of System.DateTime

type Episode = {
    name: string
    url: string
    publishedDate: Date
    state: EpisodeState
}

type Podcast = {
    name : string
    url: string
    image: Image
    media: Media
    episodes: Episode list
}

