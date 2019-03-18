using Puppet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.environment;

namespace wizardscode.procedural.dancers
{
    public class DancerSpawner : SimpleSpawner
    {
        internal override void CustomizeObject(GameObject go, SpawnableObject spawnerDefinition)
        {
            SpawnableDancer def = spawnerDefinition as SpawnableDancer;

            var dancer = go.GetComponent<Puppet.Dancer>();

            dancer.footDistance *= Random.Range(0.8f, 2.0f);
            dancer.stepFrequency = Random.Range(def.minTempo, def.maxTempo);
            dancer.stepHeight *= 0.1f + Random.Range(def.minEnergy, def.maxEnergy);
            dancer.stepAngle *= Random.Range(def.minEnergy, def.maxEnergy);

            dancer.hipHeight *= Random.Range(0.75f, 1.25f);
            dancer.hipPositionNoise *= Random.Range(def.minEnergy, def.maxEnergy);
            dancer.hipRotationNoise *= Random.Range(def.minEnergy, def.maxEnergy);

            dancer.spineBend = Random.Range(def.minEnergy * 5, -def.maxEnergy * 12);
            dancer.spineRotationNoise *= Random.Range(0.75f, 1.25f);

            dancer.handPositionNoise *= Random.Range(0.5f, 2.0f);
            dancer.handPosition += Random.insideUnitSphere * 0.25f;

            dancer.headMove *= Random.Range(def.minEnergy / 2, def.maxEnergy * 2);
            dancer.noiseFrequency *= Random.Range(0.4f, 1.8f);
            dancer.randomSeed = Random.Range(0, 0xffffff);

            var renderer = dancer.GetComponentInChildren<Renderer>();
            renderer.material.color = Random.ColorHSV(0, 1, 0.6f, 0.8f, 0.8f, 1.0f);
        }
    }
}
