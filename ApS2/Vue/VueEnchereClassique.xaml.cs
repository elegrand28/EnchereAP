using ApS2.Modele;
using ApS2.VueModele;
using Microsoft.Maui.Graphics.Text;

namespace ApS2.Vue;

public partial class VueEnchereClassique : ContentPage
{
    PageChoixEnchereVuesModele vueModele;
    public VueEnchereClassique()
    {
        InitializeComponent();
        BindingContext = vueModele = new PageChoixEnchereVuesModele();


    }

    public async void BoutonSoumettre(object sender, EventArgs args)
    {
        string result = await DisplayPromptAsync("Enchère", "Donner votre prix");

        int Leresult = Convert.ToInt32(result);
        
        
            foreach (Enchere leprix in vueModele.EnchereClassiqueList)
            {
                if (Leresult >= leprix.Leproduit.Prixreel)
                {
                
            }
            }
        }
       
           


    }


  