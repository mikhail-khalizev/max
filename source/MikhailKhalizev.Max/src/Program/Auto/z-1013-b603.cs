using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b603-717be9a6")]
        public void Method_1013_b603()
        {
            ii(0x1013_b603, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_b608, 5); call(Definitions.sys_check_available_stack_size, 0x2_a745); /* call 0x10165d52 */
            ii(0x1013_b60d, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b60e, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b60f, 1); push(esi);                              /* push esi */
            ii(0x1013_b610, 1); push(edi);                              /* push edi */
            ii(0x1013_b611, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b612, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b614, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b61a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b61d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_b620, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b623, 5); call(0x1013_b70c, 0xe4);                /* call 0x1013b70c */
            ii(0x1013_b628, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b62b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_b62e, 6); mov(memd[ds, edx], 0x101b_6ef4);        /* mov dword [edx], 0x101b6ef4 */
            ii(0x1013_b634, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_b637, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_b63a, 4); mov(memw[ds, edx + 4], ax);             /* mov [edx+0x4], ax */
            ii(0x1013_b63e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b641, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_b644, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b647, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b649, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b64a, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b64b, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b64c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b64d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b64e, 1); ret();                                  /* ret */
        }
    }
}
