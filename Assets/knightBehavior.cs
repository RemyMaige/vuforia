using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Animator m_Animator;
    private bool charge = false;
    private bool demo = false;
    private bool idle = true;

    public Vuforia.ImageTarget swordMarker;
    public Vuforia.Image shieldMarker;
    public Vuforia.CameraDevice cam;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (swordMarker.)
        {
            demo = false;
            m_Animator.SetBool("lk_heavy_infantry_06_combat_walk", demo);
            charge = !charge;
            m_Animator.SetBool("WK_heavy_infantry_04_charge 0", charge);
        }

        if (shieldMarker.)
        {
            charge = false;
            m_Animator.SetBool("WK_heavy_infantry_04_charge 0", charge);
            demo = !demo;
            m_Animator.SetBool("lk_heavy_infantry_06_combat_walk", demo);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            demo = false;
            charge = false;
            m_Animator.SetBool("lk_heavy_infantry_06_combat_walk", demo);
            m_Animator.SetBool("WK_heavy_infantry_04_charge 0", charge);
        }

    }
}
