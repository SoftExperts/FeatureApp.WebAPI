using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Services.SecurityAttacks
{
    public class SecurityAttacks : ISecurityAttacks
    {
        private readonly IConfiguration _configuration;

        public SecurityAttacks(IConfiguration configuration)
        {
			_configuration = configuration;
        }

        public async Task InjectionAttack(string id)
        {
			try
			{
                string connectionString = _configuration.GetConnectionString("AsifProdDb");

                if (string.IsNullOrEmpty(id))
					throw new ArgumentException("Id is Empty");
                string sql = "Select * from Products where Id =" + id;

                SqlConnection connection = new SqlConnection(connectionString);

                using (SqlCommand cmd = new SqlCommand(sql, connection))
				{
                    connection.Open();
                    await cmd.ExecuteReaderAsync();
				}

                connection.Close();
            }
			catch (Exception)
			{

				throw;
			}
        }


        public async Task FileAttack(IFormFile file)
        {
            try
            {

                // Save a file into temporary loctaion.
                var path = Path.GetTempFileName();

                using (var stream = System.IO.File.OpenWrite(path))
                {
                    await file.CopyToAsync(stream);
                }

                // Do something with upload file

            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task PreventFileAttack(IFormFile file)
        {

            try
            {
                //Check File Extension
                //var extensions= Path.GetExtension(file.FileName);
                //if (extensions != ".pdf")
                //    throw new Exception("Only Pdf files are allowed!");

                // Check File Size
                //if(file.Length> 10*1024)
                //    throw new Exception("File is Larger Than 10b!");

                // Save a file into temporary loctaion.
                var path = Path.GetTempFileName();

                using (var stream = System.IO.File.OpenWrite(path))
                {
                    await file.CopyToAsync(stream);
                }

                // Do something with upload file

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task PreventInjectionAttack(Guid id)
        {
            try
            {
                string connectionString = _configuration.GetConnectionString("AsifProdDb");

                if (id == Guid.Empty)
                    throw new ArgumentException("Id is Empty");

                string sql = "Select * from Products where Id = @userId";

                using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection(connectionString)))
                {
                    cmd.Parameters.AddWithValue("@userId", id);
                    await cmd.ExecuteReaderAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
