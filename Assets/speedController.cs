using UnityEngine;

public class CurrentSpeedController : MonoBehaviour
{
    public Animator wireAnimator;  // assign animator
    public Material wireMat;       // assign material

    public float animationSpeed = 1f; // animator playback speed
    public float scrollSpeed = 1f;    // how fast the texture scrolls

    private float offset = 0f;

    void Update()
    {
        // Apply animation speed
        if (wireAnimator != null)
            wireAnimator.speed = animationSpeed;

        // Scroll texture only forward
        offset += Time.deltaTime * scrollSpeed;
        wireMat.SetTextureOffset("_EmissionMap", new Vector2(offset, 0));
    }

    // UI SLIDER: Speed control
    public void SetSpeed(float newSpeed)
    {
        scrollSpeed = newSpeed;
    }
}
