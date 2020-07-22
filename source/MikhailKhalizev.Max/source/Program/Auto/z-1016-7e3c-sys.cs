using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7e3c-8096d585")]
        public void /* sys */ Method_1016_7e3c()
        {
            ii(0x1016_7e3c, 5);  call(/* sys */ 0x1016_7dac, -0x95);   /* call 0x10167dac */
            ii(0x1016_7e41, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7e48, 2);  if(jz(0x1016_7e4e, 4)) goto l_0x1016_7e4e;/* jz 0x10167e4e */
            ii(0x1016_7e4a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_7e4c, 2);  if(jnz(0x1016_7e54, 6)) goto l_0x1016_7e54;/* jnz 0x10167e54 */
        l_0x1016_7e4e:
            ii(0x1016_7e4e, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1016_7e53, 1);  ret(); return;                        /* ret */
        l_0x1016_7e54:
            ii(0x1016_7e54, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1016_7e57, 1);  ret();                                /* ret */
        }
    }
}
