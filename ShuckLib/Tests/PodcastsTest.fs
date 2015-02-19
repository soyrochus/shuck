namespace Shuck
open System
open NUnit.Framework

[<TestFixture>]
module TestPodcasts = 
    open Repositories

    [<Test>]
    let ``test getPodcasts (repository)`` () =  
        let repos = MockRepository() :> Repository
        let podcasts = repos.GetPodcasts ()
        Assert.AreEqual(1, podcasts.Length)
        let podcasts2 = Podcasts.getPodcasts repos 
        Assert.AreEqual(1, podcasts2.Length)
