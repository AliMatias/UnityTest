using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

    public Rigidbody rb;
    public static List<Attractor> attractors;
    const float G = 0.06674f;

    void FixedUpdate()
    {
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this)
                Attract(attractor);
        }
    }

    void OnEnable()
    {
        if (attractors == null)
            attractors = new List<Attractor>();
        attractors.Add(this);
    }

    void OnDisable()
    {
        attractors.Remove(this);
    }

    void Attract(Attractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
        if (distance == 0f)
            return;
        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / (distance * distance);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
