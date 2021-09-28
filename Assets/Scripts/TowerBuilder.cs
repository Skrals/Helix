using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject basis;
    [SerializeField] private StartPlatform spawnPlatform;
    [SerializeField] private FinishPlatform finishPlatform;
    [SerializeField] private Platform[] platforms;

    private float adittionalScaleForStartAndFinish = 1f;
    public float BeamScaleY => levelCount + adittionalScaleForStartAndFinish;
    void Start()
    {
        Build();
    }

    private void Build()
    {
        GameObject beam = Instantiate(basis, transform);
        beam.transform.localScale = new Vector3(1.2f, BeamScaleY, 1.2f);

        Vector3 spawnPosition = beam.transform.position;
        spawnPosition.y += beam.transform.localScale.y;

        SpawnPlatform(spawnPlatform, ref spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), beam.transform);

        for (int i =0; i<levelCount; i++)
        {
            SpawnPlatform(platforms[Random.Range(0, platforms.Length)], ref spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), beam.transform);
        }

        SpawnPlatform(finishPlatform, ref spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), beam.transform);
    }

    private void SpawnPlatform (Platform platform,ref Vector3 spawnPosition, Quaternion rotation, Transform parent)
    {
        Instantiate(platform, spawnPosition, rotation, parent);
        spawnPosition.y -= 2;
    }
}
