using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
		private readonly SqlConnection _conection;
        public SerieRepositorio()
        {
			var conn = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SeriesDB; Integrated Security = True;";
			_conection = new SqlConnection(conn);
		}

        public void Atualiza(int id, Serie objeto)
		{
			_conection.Open();
			_conection.Update(objeto);
			_conection.Close();
		}

		public void Exclui(int id)
		{
			_conection.Open();
			_conection.Delete(new Serie(id: id));
			_conection.Close();
		}

		public void Insere(Serie objeto)
		{
			_conection.Open();
			_conection.Insert(objeto);
			_conection.Close();
		}

		public List<Serie> Lista()
		{
			_conection.Open();
			var r =  _conection.GetAll<Serie>();
			_conection.Close();

			return r.ToList();
		}

		public int ProximoId()
		{
			_conection.Open();
			var comand = @"SELECT ISNULL(MAX(id),0) + 1 FROM Serie";
			var id = _conection.QueryFirst<int>(comand);
			_conection.Close();
			return id;
		}

		public Serie RetornaPorId(int id)
		{
			_conection.Open();
			var serie = _conection.Get<Serie>(id);
			_conection.Close();
			return serie;
		}
	}
}