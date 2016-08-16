namespace ApiTest.Controllers

open ApiTest.Models
open System
open System.Web.Http
open System.Net.Http

type TestController()  = 
    inherit ApiController()

    [<RouteAttribute("test/get")>]
    [<HttpGetAttribute>]
    member this.Test() = { TestData.ControllerName = "testcontroller"; Id = 4 }
    
    [<RouteAttribute("test/getHttp")>]
    [<HttpGetAttribute>]
    member this.TestHttpClient() = Async.RunSynchronously (async {
        let httpClient = new HttpClient (BaseAddress = new Uri("http://localhost:48213/"))
        let! response = httpClient.GetAsync("test/get") |> Async.AwaitTask
        
        response.EnsureSuccessStatusCode |> ignore

        let! result = response.Content.ReadAsAsync<TestData>() |> Async.AwaitTask
        let alteredResult = { result with ControllerName = "alteredController" }
        return alteredResult
    })