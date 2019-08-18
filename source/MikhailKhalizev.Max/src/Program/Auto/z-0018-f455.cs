using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f455-71481b22")]
        public void Method_0018_f455()
        {
            ii(0x18_f455, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x18_f457, 4); mov(ch, memb_a16[ds, 0xe00]);             /* mov ch, [0xe00] */
            ii(0x18_f45b, 2); if(jcxzw(0x18_f474, 0x17)) goto l_0x18_f474; /* jcxz 0xf474 */
            ii(0x18_f45d, 4); cmp(memb_a16[ds, 0xdff], cl);             /* cmp [0xdff], cl */
            ii(0x18_f461, 2); if(jzw(0x18_f466, 0x3)) goto l_0x18_f466; /* jz 0xf466 */
            ii(0x18_f463, 3); mov(cx, 0xfff8);                          /* mov cx, 0xfff8 */
        l_0x18_f466:
            ii(0x18_f466, 2); pushd(eax);                               /* push eax */
            ii(0x18_f468, 4); mov(eax, memd_a16[ds, 0xac]);             /* mov eax, [0xac] */
            ii(0x18_f46c, 4); shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0x18_f470, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x18_f472, 2); popd(eax);                                /* pop eax */
        l_0x18_f474:
            ii(0x18_f474, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x18_f475, 1); retw(); return;                           /* ret */
        }
    }
}
