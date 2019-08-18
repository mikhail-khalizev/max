using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa8779a4-09f0-4051-bf68-98c555fe1329")]
        public void Method_1016_44b4()
        {
            ii(0x1016_44b4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_44b9, 5); calld(Definitions.sys_check_available_stack_size, 0x1894); /* call 0x10165d52 */
            ii(0x1016_44be, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_44bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_44c0, 1); pushd(esi);                             /* push esi */
            ii(0x1016_44c1, 1); pushd(edi);                             /* push edi */
            ii(0x1016_44c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_44c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_44c5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_44cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_44ce, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_44d1, 5); mov(ebx, 0x101b_74f0);                  /* mov ebx, 0x101b74f0 */
            ii(0x1016_44d6, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1016_44db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_44de, 5); calld(Definitions.sys_call_dtor_arr_v2, 0x1afd); /* call 0x10165fe0 */
            ii(0x1016_44e3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_44e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_44e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_44eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_44ec, 1); popd(edi);                              /* pop edi */
            ii(0x1016_44ed, 1); popd(esi);                              /* pop esi */
            ii(0x1016_44ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_44ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_44f0, 1); retd(); return;                         /* ret */
        }
    }
}
