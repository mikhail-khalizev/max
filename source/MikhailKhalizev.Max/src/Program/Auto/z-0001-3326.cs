using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3326-86391313")]
        public void Method_0001_3326()
        {
            ii(0x1_3326, 3);  sub(edi, esi);                            /* sub edi, esi */
            ii(0x1_3329, 4);  shl(edi, 6);                              /* shl edi, 0x6 */
            ii(0x1_332d, 6);  movzx(eax, memw[ds, 0xa2]);               /* movzx eax, word [0xa2] */
            ii(0x1_3333, 4);  shl(eax, 4);                              /* shl eax, 0x4 */
            ii(0x1_3337, 6);  movzx(ebx, memw[ds, 0xa0]);               /* movzx ebx, word [0xa0] */
            ii(0x1_333d, 6);  lea(ebx, memd_a32[ds, eax + ebx + 0x14]); /* lea ebx, [eax+ebx+0x14] */
            ii(0x1_3343, 5);  mov(esi, memd_a32[es, ebx]);              /* mov esi, [es:ebx] */
            ii(0x1_3348, 4);  mov(eax, memd[ds, 0xac]);                 /* mov eax, [0xac] */
            ii(0x1_334c, 3);  cmp(eax, esi);                            /* cmp eax, esi */
            ii(0x1_334f, 2);  if(ja(0x1_3353, 2)) goto l_0x1_3353;      /* ja 0x3353 */
            ii(0x1_3351, 2);  xchg(esi, eax);                           /* xchg esi, eax */
        l_0x1_3353:
            ii(0x1_3353, 3);  cmp(eax, edi);                            /* cmp eax, edi */
            ii(0x1_3356, 2);  if(ja(0x1_335a, 2)) goto l_0x1_335a;      /* ja 0x335a */
            ii(0x1_3358, 2);  xchg(edi, eax);                           /* xchg edi, eax */
        l_0x1_335a:
            ii(0x1_335a, 5);  mov(memd_a32[es, ebx], eax);              /* mov [es:ebx], eax */
            ii(0x1_335f, 4);  mov(memd[ds, 0xac], eax);                 /* mov [0xac], eax */
            ii(0x1_3363, 1);  ret();                                    /* ret */
        }
    }
}
