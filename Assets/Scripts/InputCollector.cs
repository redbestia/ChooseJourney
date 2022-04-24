using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCollector : Singleton<InputCollector>
{
    public bool Jump => Input.GetKeyDown(KeyCode.Space);
    public bool GoLeft => Input.GetKey(KeyCode.LeftArrow);
    public bool GoRight => Input.GetKey(KeyCode.RightArrow);

}
