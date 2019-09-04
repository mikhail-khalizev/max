using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b0a5-6231f6fa")]
        public void Method_1013_b0a5()
        {
            ii(0x1013_b0a5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_b0aa, 5); call(Definitions.sys_check_available_stack_size, 0x2_aca3); /* call 0x10165d52 */
            ii(0x1013_b0af, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b0b0, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b0b1, 1); push(esi);                              /* push esi */
            ii(0x1013_b0b2, 1); push(edi);                              /* push edi */
            ii(0x1013_b0b3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b0b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b0b6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b0bc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b0bf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_b0c2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b0c5, 5); call(0x1013_b325, 0x25b);               /* call 0x1013b325 */
            ii(0x1013_b0ca, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b0cd, 4); cmp(memd[ds, eax + 6], 0);              /* cmp dword [eax+0x6], 0x0 */
            ii(0x1013_b0d1, 2); if(jz(0x1013_b0e8, 0x15)) goto l_0x1013_b0e8; /* jz 0x1013b0e8 */
            ii(0x1013_b0d3, 5); mov(edx, 0x101b_6edc);                  /* mov edx, 0x101b6edc */
            ii(0x1013_b0d8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b0db, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1013_b0de, 5); call(Definitions.sys_call_dtor_arr, 0x2_aed5); /* call 0x10165fb8 */
            ii(0x1013_b0e3, 5); call(Definitions.sys_delete_arr, 0x2_aef0); /* call 0x10165fd8 */
        l_0x1013_b0e8:
            ii(0x1013_b0e8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b0eb, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_b0ee, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_b0f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b0f3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b0f4, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b0f5, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b0f6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b0f7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b0f8, 1); ret();                                  /* ret */
        }
    }
}
