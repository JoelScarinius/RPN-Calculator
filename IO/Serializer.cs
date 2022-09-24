//using RPN_Calculator.Exceptions;
//using System.Runtime.Serialization.Formatters.Binary;


//namespace RPN_Calculator.IO
//{
//    /// <summary>
//    /// This class is responsible for serializing and deserializing objects to/from a binary file.
//    /// </summary>
//    public class Serializer
//    {
//        /// <summary>Represents the binary file to read/wrtie from/to.</summary>
//        private FileInfo file;

//        /// <summary>The binary formatter used to (de)serialize objects.</summary>
//        private BinaryFormatter binFormat;

//        /// <summary>
//        /// The constructor accepts a file name as a parameter.
//        /// </summary>
//        /// <param name="fileName">The name of the file used in the (de)serialization.</param>
//        public Serializer(string fileName)
//        {
//            file = new FileInfo(fileName);
//            binFormat = new BinaryFormatter();
//        }

//        /// <summary>
//        /// This method serializes an object to the chosen binary file.
//        /// </summary>
//        /// <typeparam name="T">The type of the object to serialize.</typeparam>
//        /// <param name="obj">The object to serialize.</param>
//        public void Serialize<T>(T obj)
//        {
//            if (!file.Directory.Exists)
//                throw new DirectoryNotFoundException("The directory in the chosen file path does not exist.");

//            using (Stream fStream = new FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.None))
//            {
//                binFormat.Serialize(fStream, obj);
//            }
//        }

//        /// <summary>
//        /// This method deserializes an object from the chosen binary file and returns the object.
//        /// </summary>
//        /// <typeparam name="T">The type of the object to deserialize.</typeparam>
//        /// <returns>The deserialized object.</returns>
//        public T Deserialize<T>()
//        {
//            if (!file.Exists)
//                throw new FileDoesNotExistException($"The file {file.FullName} does not exist.", file.FullName);

//            T obj;
//            using (Stream fStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
//            {
//                obj = (T)binFormat.Deserialize(fStream);
//                return obj;
//            }
//        }
//    }
//}