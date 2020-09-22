using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class JimakuClip : PlayableAsset, ITimelineClipAsset
{
    public JimakuBehaviour template = new JimakuBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<JimakuBehaviour>.Create (graph, template);
        return playable;
    }
}
