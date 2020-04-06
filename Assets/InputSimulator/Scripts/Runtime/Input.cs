using System.Collections.Generic;
using UnityEngine;

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
	Dictionary<KeyCode, bool>
	
	public static void KeyDown(KeyCode keyCode)
	{
		
	}
}