using UnityEngine;

public class LevelController : MonoBehaviour
{
    private LevelModes _levelMode;
    public enum LevelModes
    {
        GAMEPLAY,
        PAUSE
    }

    private void Awake()
    {
        SetLevelMode(LevelModes.GAMEPLAY);
    }

    public void SetLevelMode(LevelModes mode)
    {
        _levelMode = mode;
    }

    public LevelModes GetLevelMode() => _levelMode;
}
