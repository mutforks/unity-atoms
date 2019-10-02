using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SceneField", fileName = "SetSceneFieldVariableValue")]
    public sealed class SetSceneFieldVariableValue : SetVariableValue<
        SceneField,
        SceneFieldVariable,
        SceneFieldReference,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent>
    { }
}
