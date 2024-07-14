using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielerBewegung : MonoBehaviour
{

    //Durch SerializeField kann man die Variablen im Unity Editor bearbeiten
    public float geschwindigkeit, sprungHoehe;
    [SerializeField] private LayerMask boden;
    [SerializeField] private ParticleSystem laufPartikel;

    private SpielerActionControls spielerActionControls;
    private Rigidbody2D rb;
    private Collider2D coll;
    private Animator animator;

    private SpriteRenderer spriteRenderer;

    private void Awake(){
        spielerActionControls = new SpielerActionControls();
        rb = GetComponent<Rigidbody2D>(); //Zugriff auf Rigidbody erhalten
        coll = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable(){
        spielerActionControls.Enable();
    }

    private void OnDisable(){
        spielerActionControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Wenn Leertaste gedrückt wird, soll die Methode Springen() aufgerufen werden
        spielerActionControls.Block.Springen.performed += _ => Springen();
    }

    private void Springen(){
        //Schauen ob Spieler Boden berührt, nur dann Springen lassen...
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            //Spieler springen lassen
            rb.AddForce(new Vector2(0, sprungHoehe), ForceMode2D.Impulse);

            //Animation
            animator.SetTrigger("Springen");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Bewegen();
    }
        

    private void Bewegen(){
        if (MainStartbildschirm.gameIsPaused == false && OptionIngame.gameIsPaused == false)
        {
            //Schauen, welcher Button geklickt wurde
            float bewegungInput = spielerActionControls.Block.Bewegen.ReadValue<float>();

            //Bewege den Spieler
            Vector3 aktuellePostion = transform.position;
            aktuellePostion.x += bewegungInput * geschwindigkeit * Time.deltaTime; //Time.deltaTime wird verwendet, dass die geschwindigkeit immer gleich bleibt, und nicht schneller wird
            transform.position = aktuellePostion;

            //Animationen
            if(bewegungInput != 0){
                animator.SetBool("Rennen", true);
                /*
                if(Mathf.Abs(rb.velocity.y) < 0.001f){
                    laufPartikel.Play();
                }
                */
                LaufPartikel();
            }
            else{
                animator.SetBool("Rennen", false);
            }

            //Charakter bei Richtungswechsel drehen
            if (bewegungInput == -1)
            {
                spriteRenderer.flipX = true;
            }
            else if (bewegungInput == 1)
            {
                spriteRenderer.flipX = false;
            }
        }
    }

    void LaufPartikel(){
        laufPartikel.Play();
    }
}
