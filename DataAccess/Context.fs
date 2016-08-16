namespace DataAccess

open System.Data
open System.Data.Entity
open DataAccess.InternalModels

type internal Context() = 
    inherit DbContext()

    [<DefaultValue>]
    val mutable m_cars : DbSet<Car>
    member public this.Cars     with get() = this.m_cars
                                and  set v = this.m_cars <- v
