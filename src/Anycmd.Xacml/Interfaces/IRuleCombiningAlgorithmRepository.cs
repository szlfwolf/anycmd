using System.Xml;

namespace Anycmd.Xacml.Interfaces
{
	/// <summary>
	/// Defines an abstract rule combining algorithm repository that is called by the EvaluationEngine when an 
	/// rule combining algorithm can't be found in the context document.
	/// </summary>
	public interface IRuleCombiningAlgorithmRepository
	{
		/// <summary>
		/// Initializes the repository provider using XmlNode that defines the provider in the configuration file.
		/// </summary>
		/// <param name="configNode">The XmlNode that defines the provider in the configuration file.</param>
		void Init( XmlNode configNode );

		/// <summary>
		/// This method is called by the EvalationEngine when the rule combining algorith used is not defined in 
		/// the specification.
		/// </summary>
		/// <param name="ruleCombiningAlgorithmId">The id of the rule combining algorithm that can't be found.</param>
		/// <returns>An instance of a rule combining algorithm.</returns>
		IRuleCombiningAlgorithm GetRuleCombiningAlgorithm( string ruleCombiningAlgorithmId );
	}
}
