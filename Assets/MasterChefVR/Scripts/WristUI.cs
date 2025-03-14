using UnityEngine;
using UnityEngine.SceneManagement;

public class WristUI : MonoBehaviour
{
    private Canvas wristCanvas;
    private Light sun;
    private float requiredSimilarity = 0.5f;
    void OnEnable()
    {
        wristCanvas = GetComponent<Canvas>();
        sun = GameObject.FindObjectOfType<Light>();
    }
    void Update()
    {
        float dotProduct = Vector3.Dot(Camera.main.transform.forward, transform.forward);
        wristCanvas.enabled = (dotProduct > requiredSimilarity);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("SpaceKitchen");
    }
    public void ChangeLightIntensity(float intensity)
    {
        sun.intensity = intensity;
    }
}
