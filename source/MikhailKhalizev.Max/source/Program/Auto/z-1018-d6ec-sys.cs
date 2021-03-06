using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d6ec-b3d62bb9")]
        public void /* sys */ Method_1018_d6ec()
        {
            ii(0x1018_d6ec, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_d6ed, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_d6ee, 1);  push(edx);                            /* push edx */
            ii(0x1018_d6ef, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_d6f1, 4);  test(memb[ds, eax + 13], 0x20);       /* test byte [eax+0xd], 0x20 */
            ii(0x1018_d6f5, 2);  if(jnz(0x1018_d719, 0x22)) goto l_0x1018_d719;/* jnz 0x1018d719 */
            ii(0x1018_d6f7, 3);  mov(eax, memd[ds, edx + 16]);         /* mov eax, [edx+0x10] */
            ii(0x1018_d6fa, 5);  call(/* sys */ 0x1019_467e, 0x6f7f);  /* call 0x1019467e */
            ii(0x1018_d6ff, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1018_d701, 2);  if(jz(0x1018_d719, 0x16)) goto l_0x1018_d719;/* jz 0x1018d719 */
            ii(0x1018_d703, 3);  mov(bl, memb[ds, edx + 13]);          /* mov bl, [edx+0xd] */
            ii(0x1018_d706, 3);  or(bl, 0x20);                         /* or bl, 0x20 */
            ii(0x1018_d709, 3);  mov(memb[ds, edx + 13], bl);          /* mov [edx+0xd], bl */
            ii(0x1018_d70c, 3);  test(bl, 7);                          /* test bl, 0x7 */
            ii(0x1018_d70f, 2);  if(jnz(0x1018_d719, 8)) goto l_0x1018_d719;/* jnz 0x1018d719 */
            ii(0x1018_d711, 2);  mov(cl, bl);                          /* mov cl, bl */
            ii(0x1018_d713, 3);  or(cl, 2);                            /* or cl, 0x2 */
            ii(0x1018_d716, 3);  mov(memb[ds, edx + 13], cl);          /* mov [edx+0xd], cl */
        l_0x1018_d719:
            ii(0x1018_d719, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d71a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_d71b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_d71c, 1);  ret();                                /* ret */
        }
    }
}
