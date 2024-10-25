using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace Greenplus.Database
{
    public class ApplicationDbContext
    {
        public SQLiteAsyncConnection _dbConnection;

        public readonly static string nameSpace = "Greenplus.Database.";

        public const string DataBaseFileName = "Greenplus.Database.db3";

        public static string databasePath => Path.Combine(FileSystem.AppDataDirectory, DataBaseFileName);

        public const SQLite.SQLiteOpenFlags Flags = 
                    SQLite.SQLiteOpenFlags.ReadWrite |
                    SQLite.SQLiteOpenFlags.Create |
                    SQLite.SQLiteOpenFlags.SharedCache;
        public  ApplicationDbContext() 
        {
            if(_dbConnection == null)
            {
                _dbConnection = new SQLiteAsyncConnection(databasePath, Flags);
                _dbConnection.CreateTableAsync<User>();
            }
        }

        public async Task<int> CreateAsync<TEntity>(TEntity entity) where TEntity : class 
        {
            return await _dbConnection.InsertAsync(entity);
        }

        public async Task<int> UpdateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbConnection.UpdateAsync(entity);
        }

        public async Task<int> DeleteAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbConnection.DeleteAsync(entity);
        }

        public async Task<int> AddOrUpdateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbConnection.InsertOrReplaceAsync(entity);
        }

        public List<T> GetTableRows<T>(string tableName) where T : class 
        {
            object[] obj = new object[] {};
            TableMapping map = new TableMapping(Type.GetType(nameSpace + tableName));
            string query = "SELECT * FROM [" + tableName + "]";
            return _dbConnection.QueryAsync(map, query, obj).Result.Cast<T>().ToList();
        }

        public object GetTableRow(string tableName, string coluna, string value)
        {
            object[] obj = new object[] { };
            TableMapping map = new TableMapping(Type.GetType(nameSpace + tableName));
            string query = "SELECT * FROM " + tableName + " WHERE " + coluna + "='" + value + "'";
            return _dbConnection.QueryAsync(map, query, obj).Result.FirstOrDefault();
        }

        //public Task GetUser()
        //{
        //    var requisicaoWeb = WebRequest.CreateHttp("https://rest-node-mztn.onrender.com/Teste");
        //    requisicaoWeb.Method = "GET";
        //    requisicaoWeb.UserAgent = "RequisicaoWebDemo";
        //    using (var resposta = requisicaoWeb.GetResponse())
        //    {
        //        var streamDados = resposta.GetResponseStream();
        //        StreamReader reader = new StreamReader(streamDados);
        //        object objResponse = reader.ReadToEnd();
        //        Console.WriteLine(objResponse.ToString());
        //        Console.ReadLine();
        //        streamDados.Close();
        //        resposta.Close();
        //    }
        //    //return requisicaoWeb.GetResponse();
        //}
    }
}
