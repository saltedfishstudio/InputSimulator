using System.Collections.Generic;
using UnityEngine;

#if INPUT_INTERNAL_TEST
public class Input
{
	public static bool GetKeyDown(KeyCode keyCode)
	{
		return UnityEngine.Input.GetKeyDown(keyCode);
	}

	public static bool GetButton(string buttonName)
	{
		return UnityEngine.Input.GetButton(buttonName);
	}
}

public static class InputInternal
{
	static Dictionary<KeyCode, bool> map;
	
	public static void KeyDown(KeyCode keyCode)
	{
		
	}
}
#endif