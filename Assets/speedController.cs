using UnityEngine;

public class CurrentSpeedController : MonoBehaviour
{
    public Animator wireAnimator; // assign your wire here
    public Material wireMat;      // assign your wire material
    public float baseSpeed = 1f;
    private float offset = 0f;
    [Range(0f, 5f)]
    public float speed = 1f;      // default speed
    private float userSpeed = 1f; // for direction control

    void Update()
    {
        if (wireAnimator != null)
        {
            wireAnimator.speed = speed; // positive = forward
            offset += Time.deltaTime * baseSpeed * userSpeed;
            wireMat.SetTextureOffset("_EmissionMap", new Vector2(offset, 0));
        }
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetForward()
    {
        userSpeed = Mathf.Abs(userSpeed);
    }

    public void SetBackward()
    {
        userSpeed = -Mathf.Abs(userSpeed);
    }

    public void Stop()
    {
        userSpeed = 0f;
    }
}
