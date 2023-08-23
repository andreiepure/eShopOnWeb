namespace Microsoft.eShopWeb.Web.ViewModels;

public class CatViewModel
{
    public CatViewModel(string catName)
    {
        CatName = catName;
    }
    public string CatName { get; set; }
    public string? CatPhotoPath { get; set; }
}
