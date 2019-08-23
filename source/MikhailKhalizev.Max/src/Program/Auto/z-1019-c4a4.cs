using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c4a4-46ccf2ce")]
        public void Method_1019_c4a4()
        {
            ii(0x1019_c4a4, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c4a5, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1019_c4a8, 5); mov(eax, memd_a32[ds, 0x1020_a20c]);    /* mov eax, [0x1020a20c] */
            ii(0x1019_c4ad, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1019_c4b0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c4b2, 2); if(jnzd(0x1019_c4d6, 0x22)) goto l_0x1019_c4d6; /* jnz 0x1019c4d6 */
            ii(0x1019_c4b4, 5); mov(edx, 0x1020_a1f8);                  /* mov edx, 0x1020a1f8 */
            ii(0x1019_c4b9, 7); cmp(memd_a32[ds, 0x1020_a204], 0);      /* cmp dword [0x1020a204], 0x0 */
            ii(0x1019_c4c0, 2); if(jnzd(0x1019_c4cc, 0xa)) goto l_0x1019_c4cc; /* jnz 0x1019c4cc */
            ii(0x1019_c4c2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_c4c7, 5); if(jmpd_func(0x1016_c993, -0x2_fb39)) return; /* jmp 0x1016c993 */
        l_0x1019_c4cc:
            ii(0x1019_c4cc, 3); mov(eax, memd_a32[ds, edx + 0xc]);      /* mov eax, [edx+0xc] */
            ii(0x1019_c4cf, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_c4d4, 2); jmpd(0x1019_c4e3, 0xd); goto l_0x1019_c4e3; /* jmp 0x1019c4e3 */
        l_0x1019_c4d6:
            ii(0x1019_c4d6, 3); calld_abs(memd_a32[ss, esp]);           /* call dword [esp] */
            ii(0x1019_c4d9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_c4de, 5); mov(eax, StringDefinitions.ReturnFromTerminateFunction); /* mov eax, 0x101b3800 */
        l_0x1019_c4e3:
            ii(0x1019_c4e3, 5); calld(/* sys */ 0x1018_0fe0, -0x1_b508); /* call 0x10180fe0 */
            ii(0x1019_c4e8, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_c4eb, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c4ec, 1); retd();                                 /* ret */
        }
    }
}
