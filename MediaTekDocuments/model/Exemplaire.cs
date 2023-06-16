using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Exemplaire (exemplaire d'une revue)
    /// </summary>
    public class Exemplaire
    {
        public int Numero { get; set; }
        public string Photo { get; set; }
        public DateTime DateAchat { get; set; }
        public string IdEtat { get; set; }
        public string Id { get; set; }
<<<<<<< HEAD
        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
=======
<<<<<<< HEAD
        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
=======
<<<<<<< HEAD
        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
=======

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument)
>>>>>>> 68b5eb50f6ce5e8b6b28fd6ad12515fed3313fc3
>>>>>>> 667bfb7329a602575225277290e0b0f421d31175
>>>>>>> 92022dd655b811bce0b9f8f1e59544695ace3576
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.Id = idDocument;
<<<<<<< HEAD
            this.Libelle = libelle;
=======
<<<<<<< HEAD
            this.Libelle = libelle;
=======
<<<<<<< HEAD
            this.Libelle = libelle;
=======
>>>>>>> 68b5eb50f6ce5e8b6b28fd6ad12515fed3313fc3
>>>>>>> 667bfb7329a602575225277290e0b0f421d31175
>>>>>>> 92022dd655b811bce0b9f8f1e59544695ace3576
        }

    }
}
