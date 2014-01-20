using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NonIntrusive
{
    /*
const BYTE SCY_ERROR_SUCCESS = 0;
const BYTE SCY_ERROR_PROCOPEN = -1;
const BYTE SCY_ERROR_IATWRITE = -2;
const BYTE SCY_ERROR_IATSEARCH = -3;
const BYTE SCY_ERROR_IATNOTFOUND = -4;
     */
    public enum SCYLLA_IATFIX_API
    {
        SCY_ERROR_SUCCESS = 0,
        SCY_ERROR_PROCOPEN = -1,
        SCY_ERROR_IATWRITE = -2,
        SCY_ERROR_IATSEARCH = -3,
        SCY_ERROR_IATNOTFOUND = -4
    }

    public static class ScyllaIAT
    {
        /// <summary>
        /// Search for the IAT given the new OEP as searchStart...
        /// </summary>
        /// <param name="pid">Process ID</param>
        /// <param name="iatAddr">Sets the IAT start</param>
        /// <param name="iatSize">Sets the size of the IAT</param>
        /// <param name="searchStart">Where to start the search for the IAT (OEP)</param>
        /// <param name="advancedSearch">This will take slightly longer</param>
        /// <returns></returns>
        [DllImport("scylla_wrapper.dll")]
        public static extern SCYLLA_IATFIX_API scylla_searchIAT(int pid, ref uint iatAddr, ref uint iatSize, uint searchStart, bool advancedSearch);
        /// <summary>
        /// Gets the entire IAT, and saves it in a temp array in memory....
        /// </summary>
        /// <param name="iatAddr">IAT start</param>
        /// <param name="iatSize">IAT size</param>
        /// <param name="pid">Process ID</param>
        /// <returns></returns>
        [DllImport("scylla_wrapper.dll")]
        public static extern SCYLLA_IATFIX_API scylla_getImports(uint iatAddr, uint iatSize, int pid);
        /// <summary>
        /// Rebuilds the IAT and writes the changes to the given fixed filename....
        /// </summary>
        /// <param name="dumpFile">The dumped executable to fix</param>
        /// <param name="iatFixFile">The fixed filename to write the changes to</param>
        /// <param name="sectionName">Section name to write the new IAT to</param>
        /// <returns></returns>
        [DllImport("scylla_wrapper.dll")]
        public static extern SCYLLA_IATFIX_API scylla_fixDump(string dumpFile, string iatFixFile, string sectionName = ".scy");
        /// <summary>
        /// Simply checks if the imports found are valid....
        /// </summary>
        /// <returns></returns>
        [DllImport("scylla_wrapper.dll")]
        public static extern bool scylla_importsValid();
    }
}
