using System;

namespace GetSetExercicio
{
    class Professor
    {
        private string _nome;
        private string _sobrenome;
        private int _telefone;
        private Boolean _oculos;

        public string GetNome()
        {
            return _nome;
        }

        public string GetSobrenome()
        {
            return _sobrenome;
        }

        public int GetTelefone()
        {
            return _telefone;
        }

        public void SetTelefone(int telefone)
        {
            _telefone = telefone;
        }

        public Boolean GetOculos()
        {
            return _oculos;
        }

        public void SetOculos(Boolean oculos)
        {
            if (oculos == true || oculos == false) { 
            _oculos = oculos;
            }
        }

    }
}
