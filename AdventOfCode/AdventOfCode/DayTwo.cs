﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayTwo.cs" company="arjan-kuiper">
//   Arjan
// </copyright>
// <summary>
//   Defines the DayTwo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The day two.
    /// </summary>
    public static class DayTwo
    {
        /// <summary>
        /// The solve part one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string SolvePartOne()
        {
            // TODO - Implement Solution
            return "Unsolved";
        }

        /// <summary>
        /// The solve part two.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string SolvePartTwo()
        {
            // TODO - Implement Solution
            return "Unsolved";
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        private static readonly string[] value = { "lsrivfotzgdxpkefaqmuiygchj", "lsrivfotzqdxpkeraqmewygchj", "lsrivfotzbdepkenarjuwygchj", "lsrivfotwbdxpkeoaqmunygchj", "lsrijfotzbdxpkenwqmuyygchj", "lsrivfotzbdxpkensqsuwygcdj", "lsrivfotubdxpkenzqmuwyschj", "lsrjvwotzbdxpkenaqjuwygchj", "lsrtvfotzbdxpkeaaqmuqygchj", "lscivzotzbdxpkenaqmuwygcnj", "ddrivfotzbdxpkenlqmuwygchj", "jsrivfvtzbdxpkenaqmufygchj", "csrivfotzxdxpkenaqguwygchj", "lprivfbtzbqxpkenaqmuwygchj", "lsrnvfotzbnxpkenaqmuwygchk", "lsiivfotzbdhpkencqmuwygchj", "lsrivfotzbyxpkenaqmzwygchc", "lsjivfotqbdxpvenaqmuwygchj", "lsrivfotzbdxpkencqmuwvgqhj", "lsrivfotzhdxpqenaqouwygchj", "lsrivfytzbnxpkenaqmuwygcsj", "llrivfotzbdxpkenaqmuwynchd", "lsuivfotzbdxpnenaqmuwygchk", "lsrtvootnbdxpkenaqmuwygchj", "ysrivfotzcdxpkenaqmuwhgchj", "lsrivfotxbdxpkefgqmuwygchj", "lsrmvfotzbaxpkenaqmuwygfhj", "lsrivfothbyxpkxnaqmuwygchj", "isrivfotzbdxpkenaqmkwygcht", "lhrivfotzbdxpkbnfqmuwygchj", "lsrivfotzbmxpkenaqmuwbgdhj", "lsrivvotzbdxcoenaqmuwygchj", "ssrwvfotzbdjpkenaqmuwygchj", "lsrivfotgbwxpkenaqmhwygchj", "lsrivfotzbdxpkenaqcuhygcyj", "lcdivfotzbdxpkenaqmuwxgchj", "ysbivfotzbdxpkenaqmuwkgchj", "lsrivfltzbdxxkenaqcuwygchj", "lsrivfotzbdxpkgnaqmunegchj", "fsqpvfotzbdxpkenaqmuwygchj", "lsriifotzbcxpkenaqmubygchj", "lsrivfotzjdxpkenaqmugygcjj", "tsrikfotzbdxpkeneqmuwygchj", "larivfotzbdxpkenaqmwwygcpj", "larivfotzbdxpkenaqmuayrchj", "lsravfotzbdxpkdoaqmuwygchj", "lsrivfotzbixpkenaqvtwygchj", "lsrixfotnbdxtkenaqmuwygchj", "lsrirfotzbdxpkeneqmuwygchv", "lsrivfofzedxpkenaqmswygchj", "lwrivfotzvdxpkenaqmuwygfhj", "lsrivfotzbdapkenaqmuqygehj", "lsrizfotgbdxpkenaqjuwygchj", "lsrivioxzbdxpkanaqmuwygchj", "lsrivfmtzbdxpkgnaqmuwcgchj", "lsrivfotzbdxpkeaaqmuofgchj", "lsrivfotvbdxpkenuqmuwygcht", "lsrivfothcdxpkenaqouwygchj", "lsgivfotzbdxpkenawmuwygchi", "lsrigfotzbdxpmonaqmuwygchj", "lsrivfotzbdxrkfnaqmuwygcha", "lsrivfopobdxpkenaqmuwygchv", "lsrejfotzbdxpkvnaqmuwygchj", "lsrivfotzbdxplenqqmuwygchz", "lsmivfotzbdppkebaqmuwygchj", "lsrivfotubdipkewaqmuwygchj", "lsrivfodnbhxpkenaqmuwygchj", "lsrivfotzbdxpkenaqmkwzgshj", "lsrixfotzbdxpkensqmuwygohj", "lsdivfotzbdxpkenaqmuwagcwj", "lsrimfotzbdxpkenaqmuwygcyu", "asnivfotzbdxpkenaqmbwygchj", "lseivfltfbdxpkenaqmuwygchj", "lsrivfbtzbdxpuenaqmuwyychj", "lsziafozzbdxpkenaqmuwygchj", "lsrivfotzbdxpkwnaomuwygchg", "ldrivfotzbdxpkeniqmuwygihj", "lsrivfotzbdxpkenaqhdwycchj", "lsrigfotzbdxphenaqmuwynchj", "lsripfotzbdxpgenaqmuwygchh", "lsrgvfoczbdxpkenaqmuwygihj", "lsribfotzbgxpkenaqhuwygchj", "lsrkvfotztdxpienaqmuwygchj", "lsrivfohzbdxpkenaqrxwygchj", "lsrivfoszbdxpkenavmuwygvhj", "lsrivfstzblxpkcnaqmuwygchj", "lzrivfotzbdxpkegaqmuwygchv", "lsrivtotzbdxpkenaqrumygchj", "lsgivfotzbdwpkenaqmuwhgchj", "lurivfotybdxpkenaqmuwygchg", "lsrivfogzbdxpkmnrqmuwygchj", "lsrivgotzbdxpkengqmuwygcwj", "lirivfbyzbdxpkenaqmuwygchj", "lwrivfotzbdxpkbjaqmuwygchj", "lsrivkotzbqxakenaqmuwygchj", "lxrivfotzbdxpkenaqmuwygshy", "lxxivfqtzbdxpkenaqmuwygchj", "lsrivfohzbdxpzenaqmuzygchj", "lsrivfotzndxekenaqmuwygcvj", "lsrdvfotzbdxpkenaqguiygchj", "lsrivfotzbdxpiehaqauwygchj", "atrivfotzbdxpkenaqmuwygchz", "lsrivfovzbdxpkenaqmuvygcwj", "lsrivfotzmdxpkennqmuwyxchj", "luvcvfotzbdxpkenaqmuwygchj", "lsriqfotzbdxpbenaqmuwygchg", "bsoivfotzudxpkenaqmuwygchj", "lsrivfotzbdxphenaqmhwxgchj", "lsrivfotzbdxpkenasmuwjgchw", "lsrivdotzboxpkenaqmuwykchj", "lsqivfotzbdxcdenaqmuwygchj", "lsrivfktzndypkenaqmuwygchj", "lwrivfotzbdxpkenaqmuolgchj", "lkrivfowzbdxpkenaqmbwygchj", "lsrivhotzbdxpkenaqyuwygvhj", "lsruvfotzbdxpkecaqmukygchj", "lsrivdotzbdsskenaqmuwygchj", "lsrivfotzbdxpkanaqmuwygcmc", "lsrgvfotubdxpkenrqmuwygchj", "psrivfotzbdxpkenaqmutygchd", "lsrivfitzbdxpkenagmiwygchj", "lsrivfotzbdxpkbnaqauwyrchj", "lsrivfotvbdxpjenaqmuwygchr", "lsrdvfoyzbjxpkenaqmuwygchj", "vsrivfothbdxpkenaqmuwyychj", "lyrivfotzpdxpkepaqmuwygchj", "lsgbqfotzbdxpkenaqmuwygchj", "lxrivfotzbdxpkenegmuwygchj", "lsrivfokzbdxpkenaqnuwyxchj", "lsrivfotubmxpkexaqmuwygchj", "lswivfvtzbdxpkenaqmuwygcgj", "lsrivfonzbdxpkenaqiuwygchc", "isrivlotzbdxpkenaqmuwygchf", "lsrilfozzbdxpkenaqmuwygcvj", "wsrivfotzbdxpkepaqmuwegchj", "lsrivfrtzbrxpkenaqquwygchj", "lsrivfotzbdxpkeqaqmuoygjhj", "lsrivfotzmdxpkenaqmuwyxchg", "lsrnvfotzbzxxkenaqmuwygchj", "ldrivfotzbdxpkenaqmlxygchj", "lsriofotzbdxpkenaqmwwmgchj", "lsrivfotzodxjkenaqmuwyglhj", "lsriviotzbdxpkegaqguwygchj", "lsrimfotzbdxpkanaqmuwygshj", "lwrzvfotzbdxpkenaqmuwygcfj", "lirivfotzbdxkkenvqmuwygchj", "lsrivfotlbdxpkeoaqmuwygahj", "lsxivfotzbdxpkenaqmuwwgchi", "lsrivfotzbdxpkenaqmukygzzj", "lsrtvfotzbdxskenaqmuwygcij", "lsgilfotzbdxpdenaqmuwygchj", "lsriyfotbbdxpkenaqmuwygchm", "lsrivfotabdxpkenaqmuwyghhs", "xsrizfotzbdxpkenaqmuwygczj", "lsrivfotybdxpkenaqquwygchx", "lsrzvfofzbdxpktnaqmuwygchj", "xsripfotzbdxpkenaqmqwygchj", "lsrivfotzbdspkenahmuwugchj", "lsmivfotzbdbpkenaqmuwygchy", "lsruvfotzbdxpkenaqqpwygchj", "lrmivfotzbdxpkenaqguwygchj", "lsnivfotzbdlpketaqmuwygchj", "lsrivfotzbdxjketaqjuwygchj", "lsrivxotzbdchkenaqmuwygchj", "lsrivootzbdxpkenaqmuwybmhj", "tsrivfdtzbdxpkenaqmuwpgchj", "lsrivmotzbdxpkxnaqmuwcgchj", "lsrivfotzadepkenaqmuwyichj", "dsrivfotrbdxpkenaqmuwtgchj", "lsrivfhtzbdxvkenoqmuwygchj", "lsrivfotzvdxbkenaqmbwygchj", "lsrxvcotzbdxpkenaqmuwygvhj", "lsrivfotzbdxykenaqmuwfgcha", "lsbivfotzbdxpkenaqmuwfvchj", "lfrivfotzbdcpkgnaqmuwygchj", "lsrivfotzbdxpwegdqmuwygchj", "lsrivfotyjdupkenaqmuwygchj", "gsrivfotzbdxpkenaemuwcgchj", "lsrivfodqbdxpkenaqmuwygchg", "lsrivfoczbdxpkenaqnuwwgchj", "lsrivpouzbhxpkenaqmuwygchj", "llbivuotzbdxpkenaqmuwygchj", "lfrivfofzbdxpkenaqmuwygchb", "lsrivfotzbdxpkenaumuwgghhj", "lsrivfotzbdxqaenazmuwygchj", "lsrivfotzbgxpkenkqmqwygchj", "lsrivfotzbdxpkensqiawygchj", "ljrijfotzbdxppenaqmuwygchj", "lsrivfoszbdxpkrnlqmuwygchj", "lsrijfotzbdxpcfnaqmuwygchj", "lsrivfotzbdopkebaqmuwytchj", "lsrivfonzbdxnkenalmuwygchj", "larivfouzbvxpkenaqmuwygchj", "lsryvfotzbdxpkensqmuwygyhj", "lsrivfztzbdxpkenaxmuwigchj", "lqkivfotzbdxpkenaqmuwygcht", "wsdivfotzbdxpkenbqmuwygchj", "lsrlvfotzadxpkencqmuwygchj", "lsrivfotoohxpkenaqmuwygchj", "lsrivfbuzbdfpkenaqmuwygchj", "psrivfotzbdxpkenawmuqygchj", "lsrivmotzbdxpkxnaqmuwcychj", "lsrivfotzvdgpkenaqmuwlgchj", "lcfivfstzbdxpkenaqmuwygchj", "lsrivfotzbddpkeeaqmuwygcij", "lsribfotzbdxpkenaqmuwugcyj", "lsrivfotzbdxakenaqmkwygyhj", "lsrivfotzbdxpkegaqmupyvchj", "lfrivfitzbdxpkenaqmuwygcrj", "lskivfotzbdxpkenaqmuwygwwj", "lsrivfotzddnpkenaqmuwfgchj", "lsrivfotzbdiukhnaqmuwygchj", "lfrivfotzbdxpkendqmuwygctj", "ljriqfotzvdxpkenaqmuwygchj", "lsrivfotzbdxpkeskqpuwygchj", "lsrivfotzbdxpkehaqmupygghj", "lsriyfotsbdxpkedaqmuwygchj", "lsrivfotzbdsjsenaqmuwygchj", "lsrivfotzbwxpienaqmuaygchj", "lsrivrotzbdxpkenaumuwygahj", "lsrivpotzfdxpkenaqmuwyjchj", "lsrivfomebdxpoenaqmuwygchj", "lswigfotpbdxpkenaqmuwygchj", "lsrivnotzbdxpkenaqmufrgchj", "lsrivfolbbdxpkenaqmuwygcqj", "lirivfotzbdxpknnaqeuwygchj", "lsrrvfxtzbdxpaenaqmuwygchj", "lspivfotzbdxpnsnaqmuwygchj", "lsrivfotzbyxpkenaqmawygcij", "lsrivfotzbfxpbenaqmuwyichj", "lsrivfotzbvxpjeyaqmuwygchj", "lyrihfotzbdxpknnaqmuwygchj", "uurivfotzbdxpkenaqmubygchj", "lsrivfotgbdxnkenaxmuwygchj", "lsriffotzbdxpkdnaqmuwygshj", "lsrisfotzbdxpkenaqzjwygchj", "lsrilfotzbdxpkenaqmuwygtgj", "lsrivfotzbdxzkenaqmuhmgchj", "hsrivfotzbdxprenaqauwygchj", "tsrevfotzbdupkenaqmuwygchj", "lsrizfotzbpxpkenaqmuwyrchj", "lsdivfotzbxxpkenaqmuhygchj", "lsrivfttzbyxpkenaqmuaygchj", "lsrivfotzodxpwenaqzuwygchj", "lsrivfotfbdxpkenaqvuwygyhj", "lsrivfotzzdxpknnaqmulygchj", "lsrjvvotzbdxpkenaqmuwjgchj", "lsrivuotzbdxpkeiaqxuwygchj", "lsrivfotzbdxpzenaqmmwygthj", "lsrivfotzbdxphenaqmuwyghvj" };
    }
}
