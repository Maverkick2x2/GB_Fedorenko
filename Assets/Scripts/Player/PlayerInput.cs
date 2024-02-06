using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float GetMoveAxis()
    {
        return Input.GetAxisRaw("Horizontal");
    }
}
