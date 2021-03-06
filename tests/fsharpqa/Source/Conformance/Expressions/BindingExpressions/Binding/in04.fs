// #in #BindingExpressions
//
// These are pretty pathological cases related to ";;" and "in"
// I'm adding these cases to make sure we do not accidentally change the behavior from version to version
// Eventually, we will deprecated them - and the specs will be updated.
//
//<Expects status="error" span="(11,5-13,10)" id="FS0020">This expression should have type 'unit', but has type 'bool'\. Use 'ignore' to discard the result of the expression, or 'let' to bind the result to a name\.$</Expects>
//

module D =
    let a = 3 in
        a + 1 |> ignore
    a > 4

