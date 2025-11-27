using UnityEngine;

public class Tower : MonoBehaviour
{
    public float attackCooldown;
    public float attackCounter;

    private void Update()
    {
        attackCounter += Time.deltaTime;

        if (attackCounter >= attackCooldown)
        {
            Debug.Log("tower is attacking");
            attackCounter = 0;
        }
    }
}
