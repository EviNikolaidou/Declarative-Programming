module TowersOfHonoi
open System
open System.IO

let main() =
    printfn "Give number of discs: " 
    let discs = Console.ReadLine()
    Console.Write("You entered: {0}", discs)
    Console.ReadLine() |> ignore
main()

let rec TowerOfHanoi start inter final d =
  if d > 0 then
    TowerOfHanoi  start final inter (d - 1)
    printfn "Move disc from peg %c to peg %c" start final
    TowerOfHanoi  inter start final (d - 1)
