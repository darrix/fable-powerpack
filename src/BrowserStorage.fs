module Fable.PowerPack.BrowserStorage

open Fable.Import
open Fable.Core.JsInterop

module LocalStorage = 

  let inline load<'T> key =
      Browser.localStorage.getItem(key) |> unbox
      |> Option.map ofJson<'T>

  let inline delete key =
      Browser.localStorage.removeItem(key)

  let inline save<'T> key (data: 'T) =
      Browser.localStorage.setItem(key, toJson data)

module SessionStorage = 

  let inline load<'T> key =
      Browser.sessionStorage.getItem(key) |> unbox
      |> Option.map ofJson<'T>

  let inline delete key =
      Browser.sessionStorage.removeItem(key)

  let inline save<'T> key (data: 'T) =
      Browser.sessionStorage.setItem(key, toJson data)
