using System;

namespace UtilClasses
{
    public class User
    {
        #region "Singleton - Pattern"

        private static User _instance;

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
