using UnityEngine;

public class NucleonSpawner : MonoBehaviour
{
    public Nucleon[] nucleonPrefabs;
    [SerializeField]
    private Transform parent;

    public void SpawnNucleon(bool proton)
    {
        int index = 1;
        if (proton)
        {
            index = 0;
        }
        Nucleon prefab = nucleonPrefabs[index];
        Nucleon spawn = Instantiate<Nucleon>(prefab, parent);
        spawn.transform.localPosition = Random.onUnitSphere;
    }
}
