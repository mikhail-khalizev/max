using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f455-ff11186e")]
        public void my_fseek()
        {
            ii(0x100e_f455, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_f45a, 5); calld(Definitions.sys_check_available_stack_size, 0x7_68f3); /* call 0x10165d52 */
            ii(0x100e_f45f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_f460, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f461, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f462, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f463, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f465, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_f46b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_f46e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_f471, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_f474, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100e_f477, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_f47a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_f47d, 5); calld(Definitions.sys_fseek, 0x8_2fee); /* call 0x10172470 */
            ii(0x100e_f482, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_f485, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_f488, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f48a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f48b, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f48c, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f48d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_f48e, 1); retd(); return;                         /* ret */
        }
    }
}
