using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UtilClasses
{
    public class DataBase
    {
        #region Singleton - Pattern

        private static DataBase _instance;

        public static DataBase GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new DataBase(path);
            }

            return _instance;
        }

        public DataBase(string path)
        {
            VerifyXmlExists(path);
        }

        public static DataBase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBase();
            }

            return _instance;
        }

        public DataBase()
        {
            
        }

        #endregion

        private List<User> _usuariosCadastrados;
        private Hash hash = new Hash(SHA512.Create());
        private User finalUser;

        private void VerifyXmlExists(string path)
        {
            if (File.Exists(path))
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                XmlSerializer serializador = new XmlSerializer(typeof(List<User>));
                _usuariosCadastrados = (List<User>)serializador.Deserialize(stream);
                stream.Close();
            }
            else
            {
                _usuariosCadastrados = new List<User>();
            }
        }

        public bool VerifyUsernameExists(string username)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if(u.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public bool VerifyLogin(string username, string password)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if (u.Username == username)
                {
                    if (hash.VerificarSenha(password, u.Password))
                    {
                        finalUser = u;
                        return true;
                    }
                }
            }

            return false;
        }

        private int GetID()
        {
            return _usuariosCadastrados.Count + 1;
        }

        public void AddUser(User user)
        {
            if (VerifyUsernameExists(user.Username))
            {
                throw new Exception("Este usuário já existe.");
            }

            user.ID = GetID();
            user.Password = hash.CriptografarSenha(user.Password);

            _usuariosCadastrados.Add(user);
        }

        public bool EditUsername(string oldUsername,string newUsername)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if(u.Username == oldUsername)
                {
                    u.Username = newUsername;
                    return true;
                }
            }

            return false;
        }

        public bool EditPassword(string username, string newPassword)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if (u.Username == username)
                {
                    u.Password = hash.CriptografarSenha(newPassword);
                    return true;
                }
            }

            return false;
        }

        public bool EditCoins(string username, int newValue)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if (u.Username == username)
                {
                    u.Coins = newValue;
                    return true;
                }
            }

            return false;
        }

        public void Save(string path)
        {
            //Serializa o objeto
            FileStream stream = new FileStream(path, FileMode.Create);
            XmlSerializer serializador = new XmlSerializer(typeof(List<User>));
            serializador.Serialize(stream, _usuariosCadastrados);
            stream.Close();
        }

        public User GetFinalUser()
        {
            return finalUser;
        }

        public void SaveUser(User user)
        {
            foreach(var u in _usuariosCadastrados)
            { 
                if(u.Username == user.Username)
                {
                    u.Username = user.Username;
                    u.Coins = user.Coins;
                }
            }
        }
    }
}
