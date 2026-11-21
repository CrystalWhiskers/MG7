using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;

    [SerializeField] private Transform _player;

    [SerializeField] private float _interactionDistance = 6.0f;

    private void Update ()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            GameObject bird = _birds[i];

            float distance = Vector3.Distance(
                bird.transform.position,
                _player.position
            );

            if (distance <= _interactionDistance)
            {
                bird.SetActive(true);
            }
        }
    }
}
