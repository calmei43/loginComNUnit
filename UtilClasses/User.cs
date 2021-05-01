using System;

namespace UtilClasses
{
    /// <summary>
    /// Classe referente ao Objeto User
    /// </summary>
    public class User
    {
        #region "Singleton - Pattern"

        private static User _instance;

        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        public User()
        {
            _instance = this;
        }

        /// <summary>
        /// Pega a ultima instância do Objeto e se não existir
        /// nenhuma, retorna uma nova
        /// </summary>
        /// <returns>Objeto User</returns>
        public static User GetCurrent()
        {
            if(_instance == null)
            {
                _instance = new User();
            }

            return _instance;
        }

        #endregion

        private int id;
        private string username;
        private string password;
        private int coins;

        /// <summary>
        /// Propriedade Username Encapsulada
        /// </summary>
        public string Username
        {
            get => username;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("O Login não pode ser nulo.");
                else
                    username = value;
            }
        }

        /// <summary>
        /// Propriedade Password Encapsulada
        /// </summary>
        public string Password
        {
            get => password;
            set
            {
                if (value == null || value == string.Empty)
                    throw new Exception("A senha não pode ser nula.");
                if (value.Length < 4)
                    throw new Exception("A senha deve ter no mínimo 4 caracteres.");
                else
                    password = value;
            }
        }

        /// <summary>
        /// Propriedade Coins Encapsulada
        /// </summary>
        public int Coins
        {
            get => coins;
            set 
            {
                if(value < 0)
                {
                    throw new Exception("Você não possui mais Dinheiro");
                }
                else
                {
                    coins = value;
                }
            }
        }

        /// <summary>
        /// Propriedade ID Encapsulada
        /// </summary>
        public int ID
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Você não possui mais Dinheiro");
                }
                else
                {
                    id = value;
                }
            }
        }
    }
}
