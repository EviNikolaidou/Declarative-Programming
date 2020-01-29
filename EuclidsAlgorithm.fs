module EuclidsAlgorithm
open System
open System.IO
let rec mkd= function
| (0,a) -&gt; a
| (b,a) -&gt; mkd( a % b,b);;
val mkd : ans * ans -&gt; ans
