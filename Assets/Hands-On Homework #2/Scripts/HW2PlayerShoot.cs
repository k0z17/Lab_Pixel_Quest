using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;


    private void Update()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;





        }


























    }






























}
