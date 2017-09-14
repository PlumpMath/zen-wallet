module Zen.Crypto

open Zen.Cost
module  A = Zen.Array
module  M = FStar.Mul
module U8 = FStar.UInt8
(*
  http://bench.cr.yp.to/results-hash.html :
  Used to relate costs of crypto functions to number of processor cycles.
  An explanation of how the costs of crypto primitives was chosen is in `Crypto Analysis.nb`
*)

type hash      = Zen.Types.hash
type signature = Zen.Types.signature
type key       = Zen.Types.key

val sha2_256: #n:nat
  -> msg: A.t U8.byte n
  -> cost (A.t U8.byte n) M.(n*2 + 160)

val sha2_512: #n:nat
  -> msg: A.t U8.byte n
  -> cost (A.t U8.byte n) M.(n*7 + 710)

val sha3_256: #n:nat
  -> msg: A.t U8.byte n
  -> cost (A.t U8.byte n) M.(n*6 + 1050)

val sha3_512: #n:nat
  -> msg: A.t U8.byte n
  -> cost (A.t U8.byte n) M.(n*8 + 800)

val sign: #n:nat
  -> msg: A.t U8.byte n
  -> key
  -> signature

val verify: #n:nat
  -> msg: A.t U8.byte n
  -> signature
  -> pubkey: key
  -> bool
(*
(** verifies a signature on an instruction and data for a particular contract. *)
val verifyCommand: #n:nat
  -> contracthash: hash
  -> opcode: U8.byte
  -> data: A.t U8.byte n
  -> signature: A.t U8.byte 64
  -> key: A.t U8.byte 64
  -> bool
*)
val verifyInputMsg: Zen.Types.inputMsg -> signature -> key -> bool
