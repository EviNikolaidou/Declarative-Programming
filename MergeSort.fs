Module MergeSort
open System
open System.IO
let MergeSort fileNum1 fileNum2 =
let filesubstance = File.ReadAllText fileNum1
filesubstance |&gt; fun substance -&gt;
File.WriteAllText(fileNum2 , substance)

[&lt;EntryPoint&gt;]
let main argv =
Merge &quot;C:\Users\user\Documents\BCU\Year
2\Declarative programming\Coursework\mergesortfile.txt&quot;
