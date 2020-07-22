using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8de8-12445776")]
        public void /* sys */ Method_1016_8de8()
        {
            ii(0x1016_8de8, 1);  push(edx);                            /* push edx */
            ii(0x1016_8de9, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_8df0, 2);  if(jz(0x1016_8e10, 0x1e)) goto l_0x1016_8e10;/* jz 0x10168e10 */
            ii(0x1016_8df2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_8df4, 5);  call(/* sys */ 0x1016_7f00, -0xef9);  /* call 0x10167f00 */
            ii(0x1016_8df9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_8dfb, 2);  if(jz(0x1016_8e12, 0x15)) goto l_0x1016_8e12;/* jz 0x10168e12 */
            ii(0x1016_8dfd, 4);  test(memb[ds, eax + 4], 1);           /* test byte [eax+0x4], 0x1 */
            ii(0x1016_8e01, 2);  if(jz(0x1016_8e10, 0xd)) goto l_0x1016_8e10;/* jz 0x10168e10 */
            ii(0x1016_8e03, 4);  test(memb[ds, eax + 6], 2);           /* test byte [eax+0x6], 0x2 */
            ii(0x1016_8e07, 2);  if(jz(0x1016_8e10, 7)) goto l_0x1016_8e10;/* jz 0x10168e10 */
            ii(0x1016_8e09, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_8e0e, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_8e0f, 1);  ret(); return;                        /* ret */
        l_0x1016_8e10:
            ii(0x1016_8e10, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1016_8e12:
            ii(0x1016_8e12, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_8e13, 1);  ret();                                /* ret */
        }
    }
}
