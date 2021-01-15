using UnityEngine;

public class LevelBlock : MonoBehaviour
{
    public static LevelBlock Instance;
    [SerializeField] private GameObject levelPrefab;
    private LevelController _levelController;


    private void Awake()
    {
        Instance = this;
        SpawnLevel();
    }

    private void SpawnLevel()
    {
        var spawnedLevel = Instantiate(levelPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        _levelController = spawnedLevel.GetComponent<LevelController>();
    }

    public LevelController GetLevelController() => _levelController;
}
