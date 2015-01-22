using System.Collections;
using cor = Anycmd.Xacml;
using inf = Anycmd.Xacml.Interfaces;
using rtm = Anycmd.Xacml.Runtime;

namespace Anycmd.Xacml.Runtime
{
    /// <summary>
    /// Defines a Bag of values as defined in A.5
    /// </summary>
    public class BagValue : inf.IFunctionParameter
    {
        #region Static members

        /// <summary>
        /// Returns a default Empty bag of values.
        /// </summary>
        public static BagValue Empty
        {
            get { return new BagValue(null); }
        }

        #endregion

        #region Private members

        /// <summary>
        /// The elements of the bag.
        /// </summary>
        private ArrayList _elements = new ArrayList();

        /// <summary>
        /// The datatype of the elements of the bag
        /// </summary>
        private inf.IDataType _dataType;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new empty bag for the given data type.
        /// </summary>
        /// <param name="dataType">The data type of the bag.</param>
        public BagValue(inf.IDataType dataType)
        {
            _dataType = dataType;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Add an element to the bag.
        /// </summary>
        /// <param name="value">The element to add.</param>
        public void Add(object value)
        {
            _elements.Add(value);
        }

        #endregion

        #region IFunctionParameter Members

        /// <summary>
        /// Gets the data type of the value.
        /// </summary>
        /// <param name="context">The evaluation context.</param>
        /// <returns>The data type descriptor.</returns>
        public inf.IDataType GetType(rtm.EvaluationContext context)
        {
            return _dataType;
        }

        /// <summary>
        /// Gets the value as a generic object.
        /// </summary>
        /// <param name="dataType">The expected data type of the value.</param>
        /// <param name="parNo">THe number of parameter used only for error notification.</param>
        /// <returns></returns>
        public object GetTypedValue(inf.IDataType dataType, int parNo)
        {
            if (dataType != DataTypeDescriptor.Bag)
            {
                throw new EvaluationException("invalid datatype.");
            }
            return this;
        }

        /// <summary>
        /// Can't get a value from the bag using this function.
        /// </summary>
        /// <param name="parNo">THe number of parameter used only for error notification.</param>
        /// <returns></returns>
        public inf.IFunction GetFunction(int parNo)
        {
            throw new EvaluationException(string.Format(cor.Resource.exc_invalid_datatype_in_stringvalue, parNo, "BagValue"));
        }

        /// <summary>
        /// Gets whether the function parameter is a bag of values.
        /// </summary>
        public bool IsBag
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the size of the bag.
        /// </summary>
        public int BagSize
        {
            get { return _elements.Count; }
        }

        /// <summary>
        /// Gets the elements of the bag so they can be iterated.
        /// </summary>
        public ArrayList Elements
        {
            get { return _elements; }
        }

        #endregion
    }
}