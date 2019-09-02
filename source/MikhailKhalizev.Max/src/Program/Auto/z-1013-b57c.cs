using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b57c-31fb63d9")]
        public void Method_1013_b57c()
        {
            ii(0x1013_b57c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_b581, 5); call(Definitions.sys_check_available_stack_size, 0x2_a7cc); /* call 0x10165d52 */
            ii(0x1013_b586, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b587, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b588, 1); push(esi);                              /* push esi */
            ii(0x1013_b589, 1); push(edi);                              /* push edi */
            ii(0x1013_b58a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b58b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b58d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b593, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b596, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_b599, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b59c, 5); call(0x1013_b70c, 0x16b);               /* call 0x1013b70c */
            ii(0x1013_b5a1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b5a4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b5a7, 6); mov(memd[ds, eax], 0x101b_6ef8);        /* mov dword [eax], 0x101b6ef8 */
            ii(0x1013_b5ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_b5b0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_b5b3, 3); mov(memd[ds, edx + 4], eax);            /* mov [edx+0x4], eax */
            ii(0x1013_b5b6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b5b9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_b5bc, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_b5bf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b5c1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b5c2, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b5c3, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b5c4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b5c5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b5c6, 1); ret();                                  /* ret */
        }
    }
}
