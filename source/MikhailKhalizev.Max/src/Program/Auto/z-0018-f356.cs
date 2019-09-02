using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f356-86391313")]
        public void Method_0018_f356()
        {
            ii(0x18_f356, 3); sub(edi, esi);                            /* sub edi, esi */
            ii(0x18_f359, 4); shl(edi, 6);                              /* shl edi, 0x6 */
            ii(0x18_f35d, 6); movzx(eax, memw[ds, 0xa2]);               /* movzx eax, word [0xa2] */
            ii(0x18_f363, 4); shl(eax, 4);                              /* shl eax, 0x4 */
            ii(0x18_f367, 6); movzx(ebx, memw[ds, 0xa0]);               /* movzx ebx, word [0xa0] */
            ii(0x18_f36d, 6); lea(ebx, memd_a32[ds, eax + ebx + 0x14]); /* lea ebx, [eax+ebx+0x14] */
            ii(0x18_f373, 5); mov(esi, memd_a32[es, ebx]);              /* mov esi, [es:ebx] */
            ii(0x18_f378, 4); mov(eax, memd[ds, 0xac]);                 /* mov eax, [0xac] */
            ii(0x18_f37c, 3); cmp(eax, esi);                            /* cmp eax, esi */
            ii(0x18_f37f, 2); if(ja(0x18_f383, 2)) goto l_0x18_f383;    /* ja 0xf383 */
            ii(0x18_f381, 2); xchg(esi, eax);                           /* xchg esi, eax */
        l_0x18_f383:
            ii(0x18_f383, 3); cmp(eax, edi);                            /* cmp eax, edi */
            ii(0x18_f386, 2); if(ja(0x18_f38a, 2)) goto l_0x18_f38a;    /* ja 0xf38a */
            ii(0x18_f388, 2); xchg(edi, eax);                           /* xchg edi, eax */
        l_0x18_f38a:
            ii(0x18_f38a, 5); mov(memd_a32[es, ebx], eax);              /* mov [es:ebx], eax */
            ii(0x18_f38f, 4); mov(memd[ds, 0xac], eax);                 /* mov [0xac], eax */
            ii(0x18_f393, 1); ret();                                    /* ret */
        }
    }
}
