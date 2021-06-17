using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class TestPlayableAsset : PlayableAsset
{
    //使用ExposedReference进行赋值操作
    public ExposedReference<GameObject> Dialog;

    private GameObject _Dialog;
    // Factory method that generates a playable based on this asset
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) {
        var scriptPlayable = ScriptPlayable<TestPlayableBehaviour>.Create(graph);
        _Dialog = Dialog.Resolve(graph.GetResolver());
        scriptPlayable.GetBehaviour().Dialog = _Dialog;
        return scriptPlayable;
    }
}
