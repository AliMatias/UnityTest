using UnityEngine;

public class NucleonSpawner : MonoBehaviour
{
    public Attractor[] nucleonPrefabs;
    [SerializeField]
    private Transform parent;

    public void SpawnNucleon(bool proton)
    {
        int index = 1;
        if (proton)
        {
            index = 0;
        }
        Attractor prefab = nucleonPrefabs[index];
        Attractor spawn = Instantiate<Attractor>(prefab, parent);
        float randomNumber = Random.Range(0f, 0.2f);
        Vector3 randomPosition = new Vector3(randomNumber,randomNumber,randomNumber);
        spawn.transform.localPosition = randomPosition;
    }
}
