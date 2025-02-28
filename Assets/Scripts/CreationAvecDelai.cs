using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationAvecDelai : MonoBehaviour
{
    [SerializeField ] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;

    private int _monnaies; /*Int = nombre entier (1, 2, 3, 4, 5' ect...). Float = Décimales (1.1, 1.2, 1.3, 1.4, ect...)*/

    void Start()
    {
        // Éxecute la méthode CreerObjet après un délai de 5s
        // Invoke("CreerObjet", 5f);
        // Éxecute la méthode CreerObjet après un délai initiale de 3s et à chaque 1s après
        InvokeRepeating("CreerObjet", 3f, 1f);
        _monnaies = 0;
        // Cancelle tous les Invoke() actifs
        // CancelInvoke();
    }

    private void Update()
    {
        
    }

    void CreerObjet()
    {


        // Instancie un nouveau objet et garde une référence à lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une référence a le Rigidbody attaché au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale aléatoire
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale aléatoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);

        _monnaies += 1;

        if(_monnaies == 10)
        {
            CancelInvoke();
        }
    }
}
