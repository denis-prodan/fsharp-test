namespace DataAccess.InternalModels

open System.ComponentModel.DataAnnotations
open System.Data.Linq.Mapping

[<Table(Name = "Cars")>]
type internal Car() =
    let mutable m_ID    : int = 0
    let mutable m_name  : string = ""

    [<Key>]
    [<Column(Name = "Id")>]
    member public this.ID   with get() = m_ID
                            and  set v = m_ID <- v

    [<Column(Name = "Name")>]
    member public this.Name with get() = m_name
                            and  set v = m_name <- v