namespace FuckOff
{


    public class FuckOffSettings 
    {
        private string userName;
        public string UserName
        {
            get { return string.IsNullOrWhiteSpace(userName) ? "Mr FuckFace" : userName; }
            set { userName = value; }
        }
        public int FuckOffCounter { get; set; }
    }

}
