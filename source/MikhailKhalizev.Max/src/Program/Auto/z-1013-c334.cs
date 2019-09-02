using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c334-f0b8b1b6")]
        public void Method_1013_c334()
        {
            ii(0x1013_c334, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c339, 5); call(Definitions.sys_check_available_stack_size, 0x2_9a14); /* call 0x10165d52 */
            ii(0x1013_c33e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c33f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c340, 1); push(esi);                              /* push esi */
            ii(0x1013_c341, 1); push(edi);                              /* push edi */
            ii(0x1013_c342, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c343, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c345, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c34b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c34e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c351, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c354, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c357, 5); call(0x1013_c2fc, -0x60);               /* call 0x1013c2fc */
            ii(0x1013_c35c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c35f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c362, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1013_c365, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c368, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x1013_c36b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c36e, 6); mov(memd[ds, eax], 0x101b_6ef8);        /* mov dword [eax], 0x101b6ef8 */
            ii(0x1013_c374, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c377, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_c37a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_c37d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c37f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c380, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c381, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c382, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c383, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c384, 1); ret();                                  /* ret */
        }
    }
}
