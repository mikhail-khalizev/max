using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6e86-7cc7d06c")]
        public void Method_1010_6e86()
        {
            ii(0x1010_6e86, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_6e8b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_eec2); /* call 0x10165d52 */
            ii(0x1010_6e90, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6e91, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6e92, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6e93, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6e94, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6e95, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6e96, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6e98, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_6e9e, 5); calld(/* sys */ 0x1016_c3f0, 0x6_554d); /* call 0x1016c3f0 */
            ii(0x1010_6ea3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_6ea6, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_6eaa, 2); if(jnzd(0x1010_6eb6, 0xa)) goto l_0x1010_6eb6; /* jnz 0x10106eb6 */
            ii(0x1010_6eac, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1010_6eb1, 5); calld(0x100e_f3a0, -0x1_7b16);          /* call 0x100ef3a0 */
        l_0x1010_6eb6:
            ii(0x1010_6eb6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6eb8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6eb9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6eba, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6ebb, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6ebc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6ebd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6ebe, 1); retd(); return;                         /* ret */
        }
    }
}
