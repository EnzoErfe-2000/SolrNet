using System.Collections.Generic;

namespace SolrNet {
	/// <summary>
	/// Executable query
	/// </summary>
	/// <typeparam name="T">Document type</typeparam>
	public interface ISolrQueryExecuter<T> where T : ISolrDocument {
		/// <summary>
		/// Connection to use
		/// </summary>
		ISolrConnection Connection { get; set; }

		ISolrQuery Query { get; set; }

		ICollection<SortOrder> OrderBy { get; set; }

		/// <summary>
		/// Executes the query and returns results
		/// </summary>
		/// <returns>query results</returns>
		ISolrQueryResults<T> Execute();

		ISolrQueryResults<T> Execute(int start, int rows);
	}
}