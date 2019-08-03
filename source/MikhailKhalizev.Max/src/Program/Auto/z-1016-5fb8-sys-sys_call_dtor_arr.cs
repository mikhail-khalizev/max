using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a60d1c61-77bd-4100-abab-938062540d48")]
        public void /* sys */ sys_call_dtor_arr()
        {
            ii(0x1016_5fb8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5fb9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5fba, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5fbb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5fbd, 2); if(jnzd(0x1016_5fc3, 0x4)) goto l_0x1016_5fc3; /* jnz 0x10165fc3 */
            ii(0x1016_5fbf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_5fc1, 2); jmpd(0x1016_5fd1, 0xe); goto l_0x1016_5fd1; /* jmp 0x10165fd1 */
        l_0x1016_5fc3:
            ii(0x1016_5fc3, 3); lea(ecx, eax - 0x4);                    /* lea ecx, [eax-0x4] */
            ii(0x1016_5fc6, 2); mov(esi, memd_a32[ds, ecx]);            /* mov esi, [ecx] */
            ii(0x1016_5fc8, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_5fca, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_5fcc, 5); calld(Definitions.sys_call_dtor_arr_v2, 0xf); /* call 0x10165fe0 */
        l_0x1016_5fd1:
            ii(0x1016_5fd1, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_5fd3, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5fd4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5fd5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5fd6, 1); retd(); return;                         /* ret */
        }
    }
}
