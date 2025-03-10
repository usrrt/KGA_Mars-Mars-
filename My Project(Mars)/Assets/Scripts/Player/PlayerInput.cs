using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //public string JumpName = "Jump";
    public string MoveAxisName = "Horizontal";

    public bool CanJump { get; private set; }
    //public bool CanMove { get; private set; }
    public float MoveDirection { get; private set; }
    public bool RightJetForce { get; private set; }
    public bool LeftJetForce { get; private set; }

    private void Update()
    {
        CanJump = Input.GetKeyDown(KeyCode.Space);
        MoveDirection = Input.GetAxis(MoveAxisName);

        RightJetForce = Input.GetKey(KeyCode.RightArrow);
        LeftJetForce = Input.GetKey(KeyCode.LeftArrow);
    }

}
