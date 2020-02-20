using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;

public class SkyManager : MonoBehaviour
{

    public bool on = true;
    public VolumeProfile _defaultProfile;
    public VolumeProfile _proceduralProfile;

    private Volume _volume;

    // public VisualEnvironment _visualEnvironment;

    void Awake()
    {

        _volume = GetComponent<Volume>();
    }

    public void SkyOnOff()
    {
        if (on)
        {
            VisualEnvironment visualEnvironment;
            _volume.profile.TryGet<VisualEnvironment>(out visualEnvironment);
            visualEnvironment.skyType.value = 2;
            //_volume.profile = _proceduralProfile;
            on = false;
        }
        else
        {
            VisualEnvironment visualEnvironment;
            _volume.profile.TryGet<VisualEnvironment>(out visualEnvironment);
            visualEnvironment.skyType.value = 1;
            //_volume.profile = _proceduralProfile;
            on = true;
        }
    }
}
