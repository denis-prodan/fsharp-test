namespace ApiTest.Models

open Newtonsoft.Json

[<JsonObject(MemberSerialization=MemberSerialization.OptOut)>]
type TestData = {
    [<JsonProperty("controllerName")>]
    ControllerName : string;

    [<JsonProperty("id")>]
    Id : int }