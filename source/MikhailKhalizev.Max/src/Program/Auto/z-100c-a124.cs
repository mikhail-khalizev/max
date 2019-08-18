using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a124-ef7250e")]
        public void Method_100c_a124()
        {
            ii(0x100c_a124, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a129, 5); calld(Definitions.sys_check_available_stack_size, 0x9_bc24); /* call 0x10165d52 */
            ii(0x100c_a12e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a12f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a130, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a131, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a132, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a133, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a135, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a13b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a13e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a141, 5); mov(ebx, 0x101b_3b58);                  /* mov ebx, 0x101b3b58 */
            ii(0x100c_a146, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100c_a14b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a14e, 5); calld(Definitions.sys_call_dtor_arr_v2, 0x9_be8d); /* call 0x10165fe0 */
            ii(0x100c_a153, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a156, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a159, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a15b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a15c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a15d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a15e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a15f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a160, 1); retd(); return;                         /* ret */
        }
    }
}
