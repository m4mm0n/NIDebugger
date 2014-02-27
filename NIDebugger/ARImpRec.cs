using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NonIntrusive
{
    public class ARImpRec
    {
        /// <summary>
        /// Searches and rebuilds the IAT...
        /// </summary>
        /// <param name="IRProcessId">Process ID</param>
        /// <param name="IRNameOfDumped">Dumped filename</param>
        /// <param name="IROEP">OEP</param>
        /// <param name="IRSaveOEPToFile">Wether to save OEP to file or not</param>
        /// <param name="IRIATRVA">IAT Start Address</param>
        /// <param name="IRIATSize">IAT Size</param>
        /// <param name="IRWarning">Return Code</param>
        [DllImport("ARImpRec.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SearchAndRebuildImports@28", CharSet = CharSet.Ansi)]
        public static extern void SearchAndRebuildImports(uint IRProcessId, string IRNameOfDumped, UInt32 IROEP, UInt32 IRSaveOEPToFile, out UInt32 IRIATRVA, out UInt32 IRIATSize, IntPtr IRWarning);
        /// <summary>
        /// Searches and rebuilds the IAT (Optimized and smaller size!)...
        /// </summary>
        /// <param name="IRProcessId">Process ID</param>
        /// <param name="IRNameOfDumped">Dumped filename</param>
        /// <param name="IROEP">OEP</param>
        /// <param name="IRSaveOEPToFile">Wether to save OEP to file or not</param>
        /// <param name="IRIATRVA">IAT Start Address</param>
        /// <param name="IRIATSize">IAT Size</param>
        /// <param name="IRWarning">Return Code</param>
        [DllImport("ARImpRec.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SearchAndRebuildImportsIATOptimized@28", CharSet = CharSet.Ansi)]
        public static extern void SearchAndRebuildImportsIATOptimized(uint IRProcessId, string IRNameOfDumped, UInt32 IROEP, UInt32 IRSaveOEPToFile, out UInt32 IRIATRVA, out UInt32 IRIATSize, IntPtr IRWarning);
        /// <summary>
        /// Searches and rebuilds the IAT (With no new section!)...
        /// </summary>
        /// <param name="IRProcessId">Process ID</param>
        /// <param name="IRNameOfDumped">Dumped filename</param>
        /// <param name="IROEP">OEP</param>
        /// <param name="IRSaveOEPToFile">Wether to save OEP to file or not</param>
        /// <param name="IRIATRVA">IAT Start Address</param>
        /// <param name="IRIATSize">IAT Size</param>
        /// <param name="IRWarning">Return Code</param>
        [DllImport("ARImpRec.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SearchAndRebuildImportsNoNewSection@28", CharSet = CharSet.Ansi)]
        public static extern void SearchAndRebuildImportsNoNewSection(uint IRProcessId, string IRNameOfDumped, UInt32 IROEP, UInt32 IRSaveOEPToFile, out UInt32 IRIATRVA, out UInt32 IRIATSize, IntPtr IRWarning);
    }
}
