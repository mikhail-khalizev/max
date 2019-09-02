using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c4f8-916ccda6")]
        public void Method_1013_c4f8()
        {
            ii(0x1013_c4f8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c4fd, 5); call(Definitions.sys_check_available_stack_size, 0x2_9850); /* call 0x10165d52 */
            ii(0x1013_c502, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c503, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c504, 1); push(esi);                              /* push esi */
            ii(0x1013_c505, 1); push(edi);                              /* push edi */
            ii(0x1013_c506, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c507, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c509, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c50f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c512, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c515, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c518, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c51b, 5); call(0x1007_6cd0, -0xc_5850);           /* call 0x10076cd0 */
            ii(0x1013_c520, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c523, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_c526, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c529, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c52c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_c52f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c532, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c534, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c535, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c536, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c537, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c538, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c539, 1); ret();                                  /* ret */
        }
    }
}
