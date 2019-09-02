using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_47f8-7cbc0e6b")]
        public void Method_1016_47f8()
        {
            ii(0x1016_47f8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1016_47fd, 5); call(Definitions.sys_check_available_stack_size, 0x1550); /* call 0x10165d52 */
            ii(0x1016_4802, 1); push(ebx);                              /* push ebx */
            ii(0x1016_4803, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4804, 1); push(esi);                              /* push esi */
            ii(0x1016_4805, 1); push(edi);                              /* push edi */
            ii(0x1016_4806, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4807, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4809, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_480f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_4812, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_4815, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1016_481a, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1016_481e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4821, 5); call(0x100c_d7e8, -0x9_703e);           /* call 0x100cd7e8 */
            ii(0x1016_4826, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_4829, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1016_482c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_482f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4832, 7); mov(memd[ds, eax + 0xc], 0x101b_753c);  /* mov dword [eax+0xc], 0x101b753c */
            ii(0x1016_4839, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_483c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_483f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_4842, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4844, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4845, 1); pop(edi);                               /* pop edi */
            ii(0x1016_4846, 1); pop(esi);                               /* pop esi */
            ii(0x1016_4847, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_4848, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_4849, 1); ret();                                  /* ret */
        }
    }
}
