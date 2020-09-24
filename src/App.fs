module App

open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop

[<Import("includedFn", from="./tsfiles/interop")>]
let includedFn(a: int, b: int): int = jsNative
// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

// Register our listener
myButton.onclick <- fun _ ->
    count <- includedFn (count, 1)
    myButton.innerText <- sprintf "You clicked: %i time(s)" count
