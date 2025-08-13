using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPartucleSystem : MonoBehaviour
{
    public List<ParticleSystem> particleSystems = new List<ParticleSystem>();
    public void STEAMStartParticl()
    {
        foreach (ParticleSystem ps in particleSystems)
        {
            ps.Play();
        }
    }
    public void STEAMStopParticl()
    {
        foreach (ParticleSystem ps in particleSystems)
        {
            ps.Stop();
        }
    }
}