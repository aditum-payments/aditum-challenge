namespace Aditum.Catalog.Model
{
    /// <summary>
    /// Returned to the user from the API when an error occurres.
    /// </summary>
    public class Error
    {
        public bool Success => false;

        public int Code { get; set; }

        public string Message { get; set; }
    }
}
