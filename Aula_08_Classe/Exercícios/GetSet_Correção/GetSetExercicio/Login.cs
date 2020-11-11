namespace GetSetExercicio
{
    class Login
    {
        private string _email;

        public Login()
        {

        }

        public Login(string email)
        {
            _email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetLogin(string email)
        {
            if (email.Contains("@"))
            {
                _email = email;
            }
        }
    }
}
