//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class InputMatcher {

    static IMatcher<InputEntity> _matcherBurstMode;

    public static IMatcher<InputEntity> BurstMode {
        get {
            if(_matcherBurstMode == null) {
                var matcher = (Matcher<InputEntity>)Matcher<InputEntity>.AllOf(InputComponentsLookup.BurstMode);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherBurstMode = matcher;
            }

            return _matcherBurstMode;
        }
    }
}