namespace RGB.curso.dominio.shared.ValueObjects
{
    public class EmailVO
    {
        public string EnderecoEmail { get; set; }

        public bool Validar(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                return ValidarEmail(email);
            }
            else
            {
                return true;
            }
        }

        public bool ValidarEmail(string Email)
        {
            bool validEmail = false;
            int indexArr = Email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = Email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }
    }
}
