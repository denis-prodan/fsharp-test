namespace DataAccess.Models

open DataAccess
open DataAccess.InternalModels

type public Car(id, name) =
    member public this.ID = id
    member public this.Name = name

    static member AddAsync(name) =
        async {
            let db = new Context()
            let car = new InternalModels.Car(Name = name)
            let carFromDB = db.Cars.Add car
            let! id = db.SaveChangesAsync () |> Async.AwaitTask
            return new Car(carFromDB.ID, carFromDB.Name)
        }

    static member LoadAsync(id) = 
        async {
            let db = new Context()
            let! carFromDB = db.Cars.FindAsync id |> Async.AwaitTask
            return new Car(carFromDB.ID, carFromDB.Name)
        }
