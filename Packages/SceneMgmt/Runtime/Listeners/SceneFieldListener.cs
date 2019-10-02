using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneField")]
    public sealed class SceneFieldListener : AtomListener<
        SceneField,
        SceneFieldAction,
        SceneFieldEvent,
        SceneFieldUnityEvent>
    { }
}
