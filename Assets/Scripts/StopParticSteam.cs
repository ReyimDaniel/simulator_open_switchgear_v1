using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticSteam : MonoBehaviour
{
    public List<ParticleSystem> particleSystems = new List<ParticleSystem>();

    public void STEAMStopParticl()
    {
        foreach (ParticleSystem ps in particleSystems)
        {
            ps.Stop();
        }
    }
}
