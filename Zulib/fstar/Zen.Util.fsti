module Zen.Util

module  C = Zen.Crypto
module  A = Zen.Array
module U8 = FStar.UInt8

(* TODO: add cost; array's size?; handle exceptions using option *)
val hashFromBase64: string -> A.t U8.byte 32

val print: string -> unit
