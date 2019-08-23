using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7e22-5ceeee0f")]
        public void /* sys */ Method_1018_7e22()
        {
            ii(0x1018_7e22, 1); pushd(edx);                             /* push edx */
            ii(0x1018_7e23, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_7e24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_7e26, 6); mov(edx, memd_a32[ds, 0x101b_e578]);    /* mov edx, [0x101be578] */
            ii(0x1018_7e2c, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1018_7e2f, 3); and(dl, 0xfc);                          /* and dl, 0xfc */
            ii(0x1018_7e32, 5); calld(/* sys */ 0x1019_470f, 0xc8d8);   /* call 0x1019470f */
            ii(0x1018_7e37, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1018_7e39, 2); if(jaed(0x1018_7e43, 0x8)) goto l_0x1018_7e43; /* jae 0x10187e43 */
            ii(0x1018_7e3b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_7e3d, 2); sub(esp, eax);                          /* sub esp, eax */
            ii(0x1018_7e3f, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1018_7e41, 2); jmpd(0x1018_7e45, 0x2); goto l_0x1018_7e45; /* jmp 0x10187e45 */
        l_0x1018_7e43:
            ii(0x1018_7e43, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_7e45:
            ii(0x1018_7e45, 6); mov(edx, memd_a32[ds, 0x101b_e578]);    /* mov edx, [0x101be578] */
            ii(0x1018_7e4b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_7e4d, 5); mov(memd_a32[ds, 0x101b_e57c], eax);    /* mov [0x101be57c], eax */
            ii(0x1018_7e52, 5); calld(/* sys */ 0x1019_aa08, 0x1_2bb1); /* call 0x1019aa08 */
            ii(0x1018_7e57, 6); mov(edx, memd_a32[ds, 0x1020_bd44]);    /* mov edx, [0x1020bd44] */
            ii(0x1018_7e5d, 5); mov(eax, memd_a32[ds, 0x1020_bd40]);    /* mov eax, [0x1020bd40] */
            ii(0x1018_7e62, 5); calld(Definitions.my_main, -0x7_f629);  /* call 0x1010883e */
            ii(0x1018_7e67, 5); calld(Definitions.sys_exit, -0x1_b80d); /* call 0x1016c65f */
            ii(0x1018_7e6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_7e6e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_7e6f, 1); popd(edx);                              /* pop edx */
            ii(0x1018_7e70, 1); retd();                                 /* ret */
        }
    }
}
