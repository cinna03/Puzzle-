using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject objectToReveal; // Note or Canvas

    public void Interact()
    {
        if (objectToReveal != null)
            objectToReveal.SetActive(true); // Show the clue
    }
}
