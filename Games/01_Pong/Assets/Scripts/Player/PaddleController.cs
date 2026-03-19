using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public bool isLeftPlayer = true;
    public float minY = -3;
    public float maxY = 3;

    private PlayerControls controls;
    private float moveInput;

    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Enable();

        if (isLeftPlayer)
        {
            controls.Gameplay.LeftPaddleMove.performed += ctx => moveInput = ctx.ReadValue<float>();
            controls.Gameplay.LeftPaddleMove.canceled += ctx => moveInput = 0f;
        }
        else
        {
            controls.Gameplay.RightPaddleMove.performed += ctx => moveInput = ctx.ReadValue<float>();
            controls.Gameplay.RightPaddleMove.canceled += ctx => moveInput = 0f;
        }
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.y += moveInput * moveSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}