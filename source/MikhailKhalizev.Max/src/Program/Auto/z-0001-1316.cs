using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1316-86391313")]
        public void Method_0001_1316()
        {
            ii(0x1_1316, 3);  sub(edi, esi);                            /* sub edi, esi */
            ii(0x1_1319, 4);  shl(edi, 0x6);                            /* shl edi, 0x6 */
            ii(0x1_131d, 6);  movzx(eax, memw_a16[ds, 0xa2]);           /* movzx eax, word [0xa2] */
            ii(0x1_1323, 4);  shl(eax, 0x4);                            /* shl eax, 0x4 */
            ii(0x1_1327, 6);  movzx(ebx, memw_a16[ds, 0xa0]);           /* movzx ebx, word [0xa0] */
            ii(0x1_132d, 6);  lea(ebx, eax + ebx + 0x14);               /* lea ebx, [eax+ebx+0x14] */
            ii(0x1_1333, 5);  mov(esi, memd_a32[es, ebx]);              /* mov esi, [es:ebx] */
            ii(0x1_1338, 4);  mov(eax, memd_a16[ds, 0xac]);             /* mov eax, [0xac] */
            ii(0x1_133c, 3);  cmp(eax, esi);                            /* cmp eax, esi */
            ii(0x1_133f, 2);  if(jaw(0x1_1343, 0x2)) goto l_0x1_1343;   /* ja 0x1343 */
            ii(0x1_1341, 2);  xchg(esi, eax);                           /* xchg esi, eax */
        l_0x1_1343:
            ii(0x1_1343, 3);  cmp(eax, edi);                            /* cmp eax, edi */
            ii(0x1_1346, 2);  if(jaw(0x1_134a, 0x2)) goto l_0x1_134a;   /* ja 0x134a */
            ii(0x1_1348, 2);  xchg(edi, eax);                           /* xchg edi, eax */
        l_0x1_134a:
            ii(0x1_134a, 5);  mov(memd_a32[es, ebx], eax);              /* mov [es:ebx], eax */
            ii(0x1_134f, 4);  mov(memd_a16[ds, 0xac], eax);             /* mov [0xac], eax */
            ii(0x1_1353, 1);  retw();                                   /* ret */
        }
    }
}
