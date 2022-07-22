public static class Utility
{
    public const string ModalClose = "modal-close";
    public const string SearchBox = "search-box";
    public const string AddToBasket = "add-to-basket";
    public const string AccountBasket = "account-basket";
    public const string ITrash = "i-trash";
    public const string RemoveXPath = "//button[text()='Sil']";
    public static string GetProductPath(int productNumber)
    {
        return ".//*[@id='search-app']/div/div[1]/div[2]/div[5]/div/div[" + productNumber + "]/div[1]/a";
    }

}