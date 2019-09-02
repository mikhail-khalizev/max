using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6630-ce399863")]
        public void Method_1007_6630()
        {
            ii(0x1007_6630, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_6635, 5); call(Definitions.sys_check_available_stack_size, 0xe_f718); /* call 0x10165d52 */
            ii(0x1007_663a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_663b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_663c, 1); push(esi);                              /* push esi */
            ii(0x1007_663d, 1); push(edi);                              /* push edi */
            ii(0x1007_663e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_663f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6641, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6647, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_664a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_664d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_6650, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_6653, 5); call(0x1013_ac7d, 0xc_4625);            /* call 0x1013ac7d */
            ii(0x1007_6658, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_665b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_665e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6660, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6661, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6662, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6663, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6664, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6665, 1); ret();                                  /* ret */
        }
    }
}
