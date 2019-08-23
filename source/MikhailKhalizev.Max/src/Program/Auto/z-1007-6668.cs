using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6668-f3554f55")]
        public void Method_1007_6668()
        {
            ii(0x1007_6668, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_666d, 5); call(Definitions.sys_check_available_stack_size, 0xe_f6e0); /* call 0x10165d52 */
            ii(0x1007_6672, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6673, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6674, 1); push(esi);                              /* push esi */
            ii(0x1007_6675, 1); push(edi);                              /* push edi */
            ii(0x1007_6676, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6677, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6679, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_667f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6682, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6685, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_6688, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_668b, 5); call(0x1013_ac03, 0xc_4573);            /* call 0x1013ac03 */
            ii(0x1007_6690, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6693, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_6696, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_6699, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_669c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_669f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_66a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_66a4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_66a5, 1); pop(edi);                               /* pop edi */
            ii(0x1007_66a6, 1); pop(esi);                               /* pop esi */
            ii(0x1007_66a7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_66a8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_66a9, 1); ret();                                  /* ret */
        }
    }
}
