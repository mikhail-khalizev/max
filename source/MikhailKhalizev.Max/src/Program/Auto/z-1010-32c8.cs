using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_32c8-11d44971")]
        public void Method_1010_32c8()
        {
            ii(0x1010_32c8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_32cd, 5); call(Definitions.sys_check_available_stack_size, 0x6_2a80); /* call 0x10165d52 */
            ii(0x1010_32d2, 1); push(ebx);                              /* push ebx */
            ii(0x1010_32d3, 1); push(ecx);                              /* push ecx */
            ii(0x1010_32d4, 1); push(esi);                              /* push esi */
            ii(0x1010_32d5, 1); push(edi);                              /* push edi */
            ii(0x1010_32d6, 1); push(ebp);                              /* push ebp */
            ii(0x1010_32d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_32d9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_32df, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_32e2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_32e5, 5); mov(edx, 0x101b_63ec);                  /* mov edx, 0x101b63ec */
            ii(0x1010_32ea, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_32ed, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1010_32f0, 5); call(Definitions.sys_call_dtor_arr, 0x6_2cc3); /* call 0x10165fb8 */
            ii(0x1010_32f5, 5); call(Definitions.sys_delete_arr, 0x6_2cde); /* call 0x10165fd8 */
            ii(0x1010_32fa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_32fd, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_3300, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_3303, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3305, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_3306, 1); pop(edi);                               /* pop edi */
            ii(0x1010_3307, 1); pop(esi);                               /* pop esi */
            ii(0x1010_3308, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3309, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_330a, 1); ret();                                  /* ret */
        }
    }
}
