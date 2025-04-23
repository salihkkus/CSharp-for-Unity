using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>(); // Animator bileşenini buluyoruz
    }

    private void Update()
    {
        // Space tuşuna basınca "Jump" trigger'ı tetikleniyor
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump"); // Jump animasyonunu tetikle
        }

        // Sol shift tuşuna basınca koşma bool'u aktif oluyor
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunning", true); // Koşma animasyonu açılıyor
        }
        else
        {
            animator.SetBool("IsRunning", false); // Koşma animasyonu kapanıyor
        }
    }
}

/*
TR: 
Bu script karakterin Animator bileşenine erişir. Space tuşuna basıldığında 'Jump' trigger'ını tetikler.
Ayrıca sol shift tuşuna basıldığında koşma animasyonu aktif edilir ('IsRunning' bool parametresi).

EN: 
This script accesses the character's Animator component. When the Space key is pressed, it triggers the 'Jump' animation.
Also, when the left shift key is pressed, it activates the running animation ('IsRunning' bool parameter).
*/
