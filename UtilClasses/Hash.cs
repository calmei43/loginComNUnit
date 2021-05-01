using System;
using System.Security.Cryptography;
using System.Text;

namespace UtilClasses
{
    /// <summary>
    /// Classe que contém a lógica de Criptografia
    /// </summary>
    public class Hash
    {
        private HashAlgorithm _algoritmo;

        /// <summary>
        /// Construtor personalizado
        /// </summary>
        /// <param name="algoritmo">Algorítmo utilizado</param>
        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        /// <summary>
        /// Criptografa a Senha
        /// </summary>
        /// <param name="senha">String com a senha</param>
        /// <returns>Senha criptografada</returns>
        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Compara a Senha digitada com a Cadastrada
        /// </summary>
        /// <param name="senhaDigitada">String com a senha digitada </param>
        /// <param name="senhaCadastrada">String com a senha cadastrada</param>
        /// <returns></returns>
        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }

            return sb.ToString() == senhaCadastrada;
        }
    }
}
