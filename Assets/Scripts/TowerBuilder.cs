using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject basis;
    [SerializeField] private StartPlatform spawnPlatform;
    [SerializeField] private FinishPlatform finishPlatform;
    [SerializeField] private Platform[] platforms;
    void Start()
    {
        Build();
    }
    void Update()
    {

    }

    private void Build()
    {
        GameObject beam = Instantiate(basis, transform);
        beam.transform.localScale = new Vector3(1.2f, levelCount / 2f, 1.2f);
    }
}
