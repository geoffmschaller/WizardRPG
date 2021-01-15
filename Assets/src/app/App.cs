using UnityEngine;

public class App : MonoBehaviour
{
	public static App Instance;

	private void Awake()
	{
		Instance = this;
	}
	
}
