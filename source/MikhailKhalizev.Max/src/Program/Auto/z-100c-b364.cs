using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b364-ce8ea4a9")]
        public void Method_100c_b364()
        {
            ii(0x100c_b364, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b369, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a9e4); /* call 0x10165d52 */
            ii(0x100c_b36e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b36f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b370, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b371, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b372, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b373, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b375, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b37b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b37e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b381, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b384, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b387, 5); calld(0x100c_b850, 0x4c4);              /* call 0x100cb850 */
            ii(0x100c_b38c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b38f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b392, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b394, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b395, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b396, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b397, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b398, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b399, 1); retd(); return;                         /* ret */
        }
    }
}
