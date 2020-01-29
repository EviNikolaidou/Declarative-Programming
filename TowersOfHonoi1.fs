module TowersOfHonoi
open System
open System.IO

let main() =
    printfn "Give number of discs: " 
    let discs = Console.ReadLine()
    Console.Write("You entered: {0}", discs)
    Console.ReadLine() |> ignore
main()

let rec TowerOfHanoiRec num from destination =
  match n with
  | 0 -> [ ]
  | _ -> let t = (6 - from - destination)
    (TowerOfHanoiRec (num-1) from destination) @ [ s, destination ] @ (TowerOfHanoiRec(num-1) t destination)

[<EntryPoint>]
let main args =    
    (TowerOfHanoi discs 1 2) |> List.iteri (fun i (a,b) -> printfn "%d: %A to %A\n" i a b)
    List.length [ ] |> printfn "Length: %d"
0
