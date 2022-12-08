using ApS2.Modele;
using ApS2.VueModele;
using Microsoft.Maui.Graphics.Text;

namespace ApS2.Vue;

public partial class VueEnchereClassique : ContentPage
{
    Enchere currentEnchere;
    PageChoixEnchereVuesModele vueModele;
    public VueEnchereClassique()
    {
        InitializeComponent();
        BindingContext = vueModele = new PageChoixEnchereVuesModele();


    }





    private async void CollectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        currentEnchere= (Enchere)e.CurrentSelection.FirstOrDefault();
        await Navigation.PushModalAsync(new VueEnchere(currentEnchere));
    }
}

   /* private async void CollectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        currentEnchere = (Enchere)e.CurrentSelection.FirstOrDefault();
        string result = await DisplayPromptAsync("Enchère", "Donner votre prix");
 
        float Leresult = Convert.ToInt32(result);
        vueModele.PostEnchereClassique(Leresult, currentEnchere);
    }
}
   */







