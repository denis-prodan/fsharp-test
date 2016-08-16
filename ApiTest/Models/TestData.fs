namespace ApiTest.Models

open Newtonsoft.Json

[<JsonObject(MemberSerialization=MemberSerialization.OptOut)>]
type TestData = {
    [<JsonPropertyAttribute("controllerName")>]
    ControllerName : string;

    [<JsonPropertyAttribute("id")>]
    Id : int }