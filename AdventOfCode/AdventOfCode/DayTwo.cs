// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayTwo.cs" company="arjan-kuiper">
//   Arjan
// </copyright>
// <summary>
//   Defines the DayTwo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode
{
    using System.Collections.Generic;
    using System.Linq;

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
            var numberWithTwo = 0;
            var numberWithThree = 0;

            foreach (var entry in Value)
            {
                var chars = new Dictionary<char, int>();
                foreach (var character in entry)
                {
                    chars[character] = chars.ContainsKey(character) ? chars[character] + 1 : 1;
                }

                numberWithTwo += chars.Any(c => c.Value == 2) ? 1 : 0;
                numberWithThree += chars.Any(c => c.Value == 3) ? 1 : 0;
            }

            return (numberWithTwo * numberWithThree).ToString();
        }

        /// <summary>
        /// The solve part two.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string SolvePartTwo()
        {
            var match = string.Empty;

            foreach (var entry in Value)
            {
                foreach (var other in Value)
                {
                    var count = 0;
                    var modified = string.Empty;

                    for (var i = 0; i < entry.Length; i++)
                    {
                        if (!entry[i].Equals(other[i]))
                        {
                            count++;
                            modified = entry.Remove(i, 1);
                        }
                    }

                    if (count == 1)
                    {
                        match = modified;
                    }
                }
            }
            
            return match;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        // ReSharper disable once StyleCop.SA1201
        private static readonly string[] Value = { "lsrivfotzgdxpkefaqmuiygchj", "lsrivfotzqdxpkeraqmewygchj", "lsrivfotzbdepkenarjuwygchj", "lsrivfotwbdxpkeoaqmunygchj", "lsrijfotzbdxpkenwqmuyygchj", "lsrivfotzbdxpkensqsuwygcdj", "lsrivfotubdxpkenzqmuwyschj", "lsrjvwotzbdxpkenaqjuwygchj", "lsrtvfotzbdxpkeaaqmuqygchj", "lscivzotzbdxpkenaqmuwygcnj", "ddrivfotzbdxpkenlqmuwygchj", "jsrivfvtzbdxpkenaqmufygchj", "csrivfotzxdxpkenaqguwygchj", "lprivfbtzbqxpkenaqmuwygchj", "lsrnvfotzbnxpkenaqmuwygchk", "lsiivfotzbdhpkencqmuwygchj", "lsrivfotzbyxpkenaqmzwygchc", "lsjivfotqbdxpvenaqmuwygchj", "lsrivfotzbdxpkencqmuwvgqhj", "lsrivfotzhdxpqenaqouwygchj", "lsrivfytzbnxpkenaqmuwygcsj", "llrivfotzbdxpkenaqmuwynchd", "lsuivfotzbdxpnenaqmuwygchk", "lsrtvootnbdxpkenaqmuwygchj", "ysrivfotzcdxpkenaqmuwhgchj", "lsrivfotxbdxpkefgqmuwygchj", "lsrmvfotzbaxpkenaqmuwygfhj", "lsrivfothbyxpkxnaqmuwygchj", "isrivfotzbdxpkenaqmkwygcht", "lhrivfotzbdxpkbnfqmuwygchj", "lsrivfotzbmxpkenaqmuwbgdhj", "lsrivvotzbdxcoenaqmuwygchj", "ssrwvfotzbdjpkenaqmuwygchj", "lsrivfotgbwxpkenaqmhwygchj", "lsrivfotzbdxpkenaqcuhygcyj", "lcdivfotzbdxpkenaqmuwxgchj", "ysbivfotzbdxpkenaqmuwkgchj", "lsrivfltzbdxxkenaqcuwygchj", "lsrivfotzbdxpkgnaqmunegchj", "fsqpvfotzbdxpkenaqmuwygchj", "lsriifotzbcxpkenaqmubygchj", "lsrivfotzjdxpkenaqmugygcjj", "tsrikfotzbdxpkeneqmuwygchj", "larivfotzbdxpkenaqmwwygcpj", "larivfotzbdxpkenaqmuayrchj", "lsravfotzbdxpkdoaqmuwygchj", "lsrivfotzbixpkenaqvtwygchj", "lsrixfotnbdxtkenaqmuwygchj", "lsrirfotzbdxpkeneqmuwygchv", "lsrivfofzedxpkenaqmswygchj", "lwrivfotzvdxpkenaqmuwygfhj", "lsrivfotzbdapkenaqmuqygehj", "lsrizfotgbdxpkenaqjuwygchj", "lsrivioxzbdxpkanaqmuwygchj", "lsrivfmtzbdxpkgnaqmuwcgchj", "lsrivfotzbdxpkeaaqmuofgchj", "lsrivfotvbdxpkenuqmuwygcht", "lsrivfothcdxpkenaqouwygchj", "lsgivfotzbdxpkenawmuwygchi", "lsrigfotzbdxpmonaqmuwygchj", "lsrivfotzbdxrkfnaqmuwygcha", "lsrivfopobdxpkenaqmuwygchv", "lsrejfotzbdxpkvnaqmuwygchj", "lsrivfotzbdxplenqqmuwygchz", "lsmivfotzbdppkebaqmuwygchj", "lsrivfotubdipkewaqmuwygchj", "lsrivfodnbhxpkenaqmuwygchj", "lsrivfotzbdxpkenaqmkwzgshj", "lsrixfotzbdxpkensqmuwygohj", "lsdivfotzbdxpkenaqmuwagcwj", "lsrimfotzbdxpkenaqmuwygcyu", "asnivfotzbdxpkenaqmbwygchj", "lseivfltfbdxpkenaqmuwygchj", "lsrivfbtzbdxpuenaqmuwyychj", "lsziafozzbdxpkenaqmuwygchj", "lsrivfotzbdxpkwnaomuwygchg", "ldrivfotzbdxpkeniqmuwygihj", "lsrivfotzbdxpkenaqhdwycchj", "lsrigfotzbdxphenaqmuwynchj", "lsripfotzbdxpgenaqmuwygchh", "lsrgvfoczbdxpkenaqmuwygihj", "lsribfotzbgxpkenaqhuwygchj", "lsrkvfotztdxpienaqmuwygchj", "lsrivfohzbdxpkenaqrxwygchj", "lsrivfoszbdxpkenavmuwygvhj", "lsrivfstzblxpkcnaqmuwygchj", "lzrivfotzbdxpkegaqmuwygchv", "lsrivtotzbdxpkenaqrumygchj", "lsgivfotzbdwpkenaqmuwhgchj", "lurivfotybdxpkenaqmuwygchg", "lsrivfogzbdxpkmnrqmuwygchj", "lsrivgotzbdxpkengqmuwygcwj", "lirivfbyzbdxpkenaqmuwygchj", "lwrivfotzbdxpkbjaqmuwygchj", "lsrivkotzbqxakenaqmuwygchj", "lxrivfotzbdxpkenaqmuwygshy", "lxxivfqtzbdxpkenaqmuwygchj", "lsrivfohzbdxpzenaqmuzygchj", "lsrivfotzndxekenaqmuwygcvj", "lsrdvfotzbdxpkenaqguiygchj", "lsrivfotzbdxpiehaqauwygchj", "atrivfotzbdxpkenaqmuwygchz", "lsrivfovzbdxpkenaqmuvygcwj", "lsrivfotzmdxpkennqmuwyxchj", "luvcvfotzbdxpkenaqmuwygchj", "lsriqfotzbdxpbenaqmuwygchg", "bsoivfotzudxpkenaqmuwygchj", "lsrivfotzbdxphenaqmhwxgchj", "lsrivfotzbdxpkenasmuwjgchw", "lsrivdotzboxpkenaqmuwykchj", "lsqivfotzbdxcdenaqmuwygchj", "lsrivfktzndypkenaqmuwygchj", "lwrivfotzbdxpkenaqmuolgchj", "lkrivfowzbdxpkenaqmbwygchj", "lsrivhotzbdxpkenaqyuwygvhj", "lsruvfotzbdxpkecaqmukygchj", "lsrivdotzbdsskenaqmuwygchj", "lsrivfotzbdxpkanaqmuwygcmc", "lsrgvfotubdxpkenrqmuwygchj", "psrivfotzbdxpkenaqmutygchd", "lsrivfitzbdxpkenagmiwygchj", "lsrivfotzbdxpkbnaqauwyrchj", "lsrivfotvbdxpjenaqmuwygchr", "lsrdvfoyzbjxpkenaqmuwygchj", "vsrivfothbdxpkenaqmuwyychj", "lyrivfotzpdxpkepaqmuwygchj", "lsgbqfotzbdxpkenaqmuwygchj", "lxrivfotzbdxpkenegmuwygchj", "lsrivfokzbdxpkenaqnuwyxchj", "lsrivfotubmxpkexaqmuwygchj", "lswivfvtzbdxpkenaqmuwygcgj", "lsrivfonzbdxpkenaqiuwygchc", "isrivlotzbdxpkenaqmuwygchf", "lsrilfozzbdxpkenaqmuwygcvj", "wsrivfotzbdxpkepaqmuwegchj", "lsrivfrtzbrxpkenaqquwygchj", "lsrivfotzbdxpkeqaqmuoygjhj", "lsrivfotzmdxpkenaqmuwyxchg", "lsrnvfotzbzxxkenaqmuwygchj", "ldrivfotzbdxpkenaqmlxygchj", "lsriofotzbdxpkenaqmwwmgchj", "lsrivfotzodxjkenaqmuwyglhj", "lsriviotzbdxpkegaqguwygchj", "lsrimfotzbdxpkanaqmuwygshj", "lwrzvfotzbdxpkenaqmuwygcfj", "lirivfotzbdxkkenvqmuwygchj", "lsrivfotlbdxpkeoaqmuwygahj", "lsxivfotzbdxpkenaqmuwwgchi", "lsrivfotzbdxpkenaqmukygzzj", "lsrtvfotzbdxskenaqmuwygcij", "lsgilfotzbdxpdenaqmuwygchj", "lsriyfotbbdxpkenaqmuwygchm", "lsrivfotabdxpkenaqmuwyghhs", "xsrizfotzbdxpkenaqmuwygczj", "lsrivfotybdxpkenaqquwygchx", "lsrzvfofzbdxpktnaqmuwygchj", "xsripfotzbdxpkenaqmqwygchj", "lsrivfotzbdspkenahmuwugchj", "lsmivfotzbdbpkenaqmuwygchy", "lsruvfotzbdxpkenaqqpwygchj", "lrmivfotzbdxpkenaqguwygchj", "lsnivfotzbdlpketaqmuwygchj", "lsrivfotzbdxjketaqjuwygchj", "lsrivxotzbdchkenaqmuwygchj", "lsrivootzbdxpkenaqmuwybmhj", "tsrivfdtzbdxpkenaqmuwpgchj", "lsrivmotzbdxpkxnaqmuwcgchj", "lsrivfotzadepkenaqmuwyichj", "dsrivfotrbdxpkenaqmuwtgchj", "lsrivfhtzbdxvkenoqmuwygchj", "lsrivfotzvdxbkenaqmbwygchj", "lsrxvcotzbdxpkenaqmuwygvhj", "lsrivfotzbdxykenaqmuwfgcha", "lsbivfotzbdxpkenaqmuwfvchj", "lfrivfotzbdcpkgnaqmuwygchj", "lsrivfotzbdxpwegdqmuwygchj", "lsrivfotyjdupkenaqmuwygchj", "gsrivfotzbdxpkenaemuwcgchj", "lsrivfodqbdxpkenaqmuwygchg", "lsrivfoczbdxpkenaqnuwwgchj", "lsrivpouzbhxpkenaqmuwygchj", "llbivuotzbdxpkenaqmuwygchj", "lfrivfofzbdxpkenaqmuwygchb", "lsrivfotzbdxpkenaumuwgghhj", "lsrivfotzbdxqaenazmuwygchj", "lsrivfotzbgxpkenkqmqwygchj", "lsrivfotzbdxpkensqiawygchj", "ljrijfotzbdxppenaqmuwygchj", "lsrivfoszbdxpkrnlqmuwygchj", "lsrijfotzbdxpcfnaqmuwygchj", "lsrivfotzbdopkebaqmuwytchj", "lsrivfonzbdxnkenalmuwygchj", "larivfouzbvxpkenaqmuwygchj", "lsryvfotzbdxpkensqmuwygyhj", "lsrivfztzbdxpkenaxmuwigchj", "lqkivfotzbdxpkenaqmuwygcht", "wsdivfotzbdxpkenbqmuwygchj", "lsrlvfotzadxpkencqmuwygchj", "lsrivfotoohxpkenaqmuwygchj", "lsrivfbuzbdfpkenaqmuwygchj", "psrivfotzbdxpkenawmuqygchj", "lsrivmotzbdxpkxnaqmuwcychj", "lsrivfotzvdgpkenaqmuwlgchj", "lcfivfstzbdxpkenaqmuwygchj", "lsrivfotzbddpkeeaqmuwygcij", "lsribfotzbdxpkenaqmuwugcyj", "lsrivfotzbdxakenaqmkwygyhj", "lsrivfotzbdxpkegaqmupyvchj", "lfrivfitzbdxpkenaqmuwygcrj", "lskivfotzbdxpkenaqmuwygwwj", "lsrivfotzddnpkenaqmuwfgchj", "lsrivfotzbdiukhnaqmuwygchj", "lfrivfotzbdxpkendqmuwygctj", "ljriqfotzvdxpkenaqmuwygchj", "lsrivfotzbdxpkeskqpuwygchj", "lsrivfotzbdxpkehaqmupygghj", "lsriyfotsbdxpkedaqmuwygchj", "lsrivfotzbdsjsenaqmuwygchj", "lsrivfotzbwxpienaqmuaygchj", "lsrivrotzbdxpkenaumuwygahj", "lsrivpotzfdxpkenaqmuwyjchj", "lsrivfomebdxpoenaqmuwygchj", "lswigfotpbdxpkenaqmuwygchj", "lsrivnotzbdxpkenaqmufrgchj", "lsrivfolbbdxpkenaqmuwygcqj", "lirivfotzbdxpknnaqeuwygchj", "lsrrvfxtzbdxpaenaqmuwygchj", "lspivfotzbdxpnsnaqmuwygchj", "lsrivfotzbyxpkenaqmawygcij", "lsrivfotzbfxpbenaqmuwyichj", "lsrivfotzbvxpjeyaqmuwygchj", "lyrihfotzbdxpknnaqmuwygchj", "uurivfotzbdxpkenaqmubygchj", "lsrivfotgbdxnkenaxmuwygchj", "lsriffotzbdxpkdnaqmuwygshj", "lsrisfotzbdxpkenaqzjwygchj", "lsrilfotzbdxpkenaqmuwygtgj", "lsrivfotzbdxzkenaqmuhmgchj", "hsrivfotzbdxprenaqauwygchj", "tsrevfotzbdupkenaqmuwygchj", "lsrizfotzbpxpkenaqmuwyrchj", "lsdivfotzbxxpkenaqmuhygchj", "lsrivfttzbyxpkenaqmuaygchj", "lsrivfotzodxpwenaqzuwygchj", "lsrivfotfbdxpkenaqvuwygyhj", "lsrivfotzzdxpknnaqmulygchj", "lsrjvvotzbdxpkenaqmuwjgchj", "lsrivuotzbdxpkeiaqxuwygchj", "lsrivfotzbdxpzenaqmmwygthj", "lsrivfotzbdxphenaqmuwyghvj" };
    }
}
