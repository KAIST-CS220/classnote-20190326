﻿// Homework 4. Prob 5
// a1, a2, a3, .....
// (1) a1 + ...
       // (1.1) a1 + a2 + ...
            // (1.1.1) a1 + a2 + a3 + ...
            // (1.1.2) a1 + a2 + a3 - ...
       // (1.2) a1 + a2 - ...
// (2) a1 - ...
       // (2.1) a1 - a2 + ...
       // (2.2) a1 - a2 - ...

let complete =
  match [1] with
  | [] -> 0
  | e :: rest -> e

let incomplete =
  match [1; 2; 3] with
  | [] -> 0
  | e1 :: e2 :: rest -> e2

open System

[<EntryPoint>]
let main argv =
    0 // return an integer exit code
