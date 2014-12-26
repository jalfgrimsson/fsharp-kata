module LSchemerTests1

open LSchemer
open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Given a LightBulb that has had its state set to true`` ()=

    [<Test>] member x.
     ``add1 should add 1`` ()=
            (add1 5) |> should equal 6

    [<Test>] member x.
     ``plus should add two numbers`` ()=
            (plus 5 4) |> should equal 9

    [<Test>] member x.
     ``minus should subtract two numbers`` ()=
            (minus 6 4) |> should equal 2

    [<Test>] member x.
     ``addtup should add all elements of a list`` ()=
            (addtup [1..4]) |> should equal 10

    [<Test>] member x.
     ``ismember should return true if x is member of a list`` ()=
            (ismember [1..5] 3) |> should be True

    [<Test>] member x.
     ``ismember should return false if x is not member of a list`` ()=
            (ismember [1..5] 8) |> should be False

    [<Test>] member x.
     ``removemember should remove a member of a list`` ()=
            (removemember [1..5] 3) |> should equal [1;2;4;5]

    [<Test>] member x.
     ``removemember should remove all matching members of a list`` ()=
            (removemember [1;3;1;3;1;3] 3) |> should equal [1;1;1]

    [<Test>] member x.
     ``removemember should not alter a list if asked to remove a non-member`` ()=
            (removemember [1..5] 8) |> should equal [1;2;3;4;5]

    [<Test>] member x.
     ``substitute should replace matching members with new value`` ()=
            (substitute [1;4;4;4;1;4] 4 3) |> should equal [1;3;3;3;1;3]
