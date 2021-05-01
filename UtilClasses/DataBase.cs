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
    /// <summary>
    /// Classe que detém os Dados e Métodos referentes ao Cadastro
    /// de Usuários.
    /// </summary>
    public class DataBase
    {
        // O padrão de projeto Singleton, garante que haverá
        //apenas uma instância do objeto (enquanto o método
        //GetInstance() for utilizado)
        #region Singleton - Pattern

        private static DataBase _instance;

        /// <summary>
        /// Retorna uma nova Instância do Objeto e se já existir
        /// uma, ele retorna ela.
        /// </summary>
        /// <param name="path">Endereço do arquivo .xml</param>
        /// <returns>Instância do Objeto</returns>
        public static DataBase GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new DataBase(path);
            }

            return _instance;
        }

        /// <summary>
        /// Retorna uma nova Instância do Objeto e se já existir
        /// uma, ele retorna ela.
        /// </summary>
        /// <param name="path">Endereço do arquivo .xml</param>
        public static DataBase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBase();
            }

            return _instance;
        }

        /// <summary>
        /// Construtor personalizado que carrega o arquivo .xml
        /// </summary>
        /// <param name="path">Endereço do arquivo .xml</param>
        public DataBase(string path)
        {
            VerifyXmlExists(path);
            _instance = this;
        }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public DataBase()
        {
            _instance = this;
        }

        #endregion


        //Variáveis Locais
        private List<User> _usuariosCadastrados;
        private Hash hash = new Hash(SHA512.Create());
        private User finalUser;

        //Verifica se o arquivo .xml com os Usuários cadastrados existe
        //e carrega a lista com eles, se não existir, instância uma nova.
        private void VerifyXmlExists(string path)
        {
            if (File.Exists(path))
            {
                //Desserializa o arquivo .xml
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

        /// <summary>
        /// Verifica se já existe algum usuário cadastrado com esse username
        /// </summary>
        /// <param name="username">String com o username</param>
        /// <returns>True se existir e False se não existir</returns>
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

        /// <summary>
        /// Verifica o usuário e a senha para logar o usuário
        /// </summary>
        /// <param name="username">String com o username</param>
        /// <param name="password">String da senha ainda não criptografada</param>
        /// <returns></returns>
        public bool VerifyLogin(string username, string password)
        {
            foreach (var u in _usuariosCadastrados)
            {
                if (u.Username == username)
                {
                    //Verifica a senha digitada com a senha criptografada salva
                    //no arquivo
                    if (hash.VerificarSenha(password, u.Password))
                    {
                        finalUser = u;
                        return true;
                    }
                }
            }

            return false;
        }

        //Seta o ID do usuário sem repetição
        private int GetID()
        {
            return _usuariosCadastrados.Count + 1;
        }

        /// <summary>
        /// Adiciona um novo usuário
        /// </summary>
        /// <param name="user">Objeto User</param>
        public void AddUser(User user)
        {
            if (VerifyUsernameExists(user.Username))
            {
                throw new Exception("Este usuário já existe.");
            }

            user.ID = GetID();
            //Criptografa a senha
            user.Password = hash.CriptografarSenha(user.Password);

            _usuariosCadastrados.Add(user);
        }

        /// <summary>
        /// Edita o username 
        /// </summary>
        /// <param name="oldUsername">String com o username antigo</param>
        /// <param name="newUsername">String com o novo username</param>
        /// <returns>True se funcionar e False se não</returns>
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

        /// <summary>
        /// Edita a senha do usuário
        /// </summary>
        /// <param name="username">String com username do Usuário</param>
        /// <param name="newPassword">String da nova senha</param>
        /// <returns></returns>
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

        /// <summary>
        /// Muda o valor de Coins que o Usuário possui
        /// </summary>
        /// <param name="username">String com o username</param>
        /// <param name="newValue">Int com o novo valor</param>
        /// <returns>True se funcionar e False se não</returns>
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

        /// <summary>
        /// Salva as mudanças feitas nos Usuários no .xml
        /// </summary>
        /// <param name="path">Endereço do arquivo .xml</param>
        public void Save(string path)
        {
            //Serializa o objeto
            FileStream stream = new FileStream(path, FileMode.Create);
            XmlSerializer serializador = new XmlSerializer(typeof(List<User>));
            serializador.Serialize(stream, _usuariosCadastrados);
            stream.Close();
        }

        /// <summary>
        /// Pega o Usuário Logado atual
        /// </summary>
        /// <returns>Objeto User atual</returns>
        public User GetFinalUser()
        {
            return finalUser;
        }

        /// <summary>
        /// Salva as mudanças de um Usuário específico.
        /// </summary>
        /// <param name="user">Objeto User</param>
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
