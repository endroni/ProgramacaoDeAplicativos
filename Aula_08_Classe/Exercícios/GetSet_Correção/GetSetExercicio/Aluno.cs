using System;

namespace GetSetExercicio
{
    class Aluno
    {
        private string _nome;
        private string _email;
        private string _cidade;
        private Boolean _status;

        public string GetNome()
        {
            return _nome;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {
            if (email != null) { 
                _email = email;
            }
        }

        public string GetCidade()
        {
            return _cidade;
        }

        public void SetCidade(string cidade)
        {
            if (cidade != null && cidade.Length > 5) { 
                _cidade = cidade;
            }
        }

        public Boolean GetStatus()
        {
            return _status;
        }

        public void SetStatus(Boolean status)
        {
            _status = status;
        }
    }
}
