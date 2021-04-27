using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace UtilClasses
{
    public class Table
    {
        #region Singleton

        private static Table instance;

        public static Table GetInstance(string path)
        {
            if(instance == null)
            {
                instance = new Table(path);
            }

            return instance;
        }

        public Table(string path)
        {
            VerifyDataTableExists(path);
        }

        #endregion

        public DataTable dt;

        private void VerifyDataTableExists(string path)
        {
            if (File.Exists(path))
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(DataTable));
                dt = (DataTable)desserializador.Deserialize(stream);
                stream.Close();
            }
            else
            {
                dt = new DataTable("usuarios");

                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("user", typeof(string));
                dt.Columns.Add("password", typeof(string));
                dt.Columns.Add("coins", typeof(int));
            }
        }

        public bool VerifyUsernameExists(string username)
        {
            var consulta = from tbl in dt.AsEnumerable()
                           select new
                           {
                               username = tbl.Field<string>("user")
                           };

            foreach(var user in consulta)
            {
                if(user.username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public bool VerifyLogin(string username, string password)
        {
            Hash hash = new Hash(SHA512.Create());

            var consulta = from tbl in dt.AsEnumerable()
                           select new
                           {
                               username = tbl.Field<string>("user"),
                               password = tbl.Field<string>("password")
                           };

            foreach (var user in consulta)
            {
                if (user.username == username && hash.VerificarSenha(password, user.password))
                    return true;
            }

            return false;                       
        }

        private int GetID()
        {
            return dt.Rows.Count + 1;
        }

        public void AddRow(User user)
        {
            if(VerifyUsernameExists(user.Username))
            {
                throw new Exception("Este usuário já existe.");
            }

            Hash hash = new Hash(SHA512.Create());

            dt.Rows.Add(GetID(), user.Username, hash.CriptografarSenha(user.Password), user.Coins);
        }
                
        public void EditRow(User user)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i].Field<string>("user") == user.Username)
                {
                    dt.Rows[i].Delete();
                    AddRow(user);
                }

            }
        }
             
        public void Save(string path)
        {
            //Serializa o objeto
            FileStream stream = new FileStream(path, FileMode.Create);
            XmlSerializer serializador = new XmlSerializer(typeof(DataTable));
            serializador.Serialize(stream, dt);
            stream.Close();
        }
    }
}
