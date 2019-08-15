using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7dd7493b-8025-461c-8e72-bc7f54fd36b4")]
        public void Method_100a_63bc()
        {
            ii(0x100a_63bc, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_63c1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f98c); /* call 0x10165d52 */
            ii(0x100a_63c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_63c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_63c8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_63c9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_63ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_63cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_63cd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_63d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_63d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_63d9, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100a_63dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_63df, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_63e2, 5); calld(0x1008_b2a8, -0x1_b13f);          /* call 0x1008b2a8 */
            ii(0x100a_63e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_63e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_63ea, 1); popd(edi);                              /* pop edi */
            ii(0x100a_63eb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_63ec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_63ed, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_63ee, 1); retd(); return;                         /* ret */
        }
    }
}
