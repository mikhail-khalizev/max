using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ed4e8edc-82f7-498e-b50e-67d5a27edcf3")]
        public void Method_1007_f017()
        {
            ii(0x1007_f017, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_f01c, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6d31); /* call 0x10165d52 */
            ii(0x1007_f021, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f022, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f023, 1); pushd(edx);                             /* push edx */
            ii(0x1007_f024, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f025, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f026, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f027, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f029, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f02f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_f032, 4); mov(memb_a32[ss, ebp - 0x8], 0x30);     /* mov byte [ebp-0x8], 0x30 */
            ii(0x1007_f036, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_f039, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f03b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f03c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f03d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f03e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_f03f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f040, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f041, 1); retd(); return;                         /* ret */
        }
    }
}
