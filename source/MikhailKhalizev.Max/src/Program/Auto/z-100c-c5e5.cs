using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_c5e5-102220d9")]
        public void Method_100c_c5e5()
        {
            ii(0x100c_c5e5, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_c5ea, 5); call(Definitions.sys_check_available_stack_size, 0x9_9763); /* call 0x10165d52 */
            ii(0x100c_c5ef, 1); push(ebx);                              /* push ebx */
            ii(0x100c_c5f0, 1); push(ecx);                              /* push ecx */
            ii(0x100c_c5f1, 1); push(edx);                              /* push edx */
            ii(0x100c_c5f2, 1); push(esi);                              /* push esi */
            ii(0x100c_c5f3, 1); push(edi);                              /* push edi */
            ii(0x100c_c5f4, 1); push(ebp);                              /* push ebp */
            ii(0x100c_c5f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c5f7, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_c5fd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_c600, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c602, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_c605, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c608, 5); call(0x1013_ad71, 0x6_e764);            /* call 0x1013ad71 */
            ii(0x100c_c60d, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c60f, 2); if(jz(0x100c_c626, 0x15)) goto l_0x100c_c626; /* jz 0x100cc626 */
            ii(0x100c_c611, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_c614, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c617, 5); call(0x1007_6574, -0x5_60a8);           /* call 0x10076574 */
            ii(0x100c_c61c, 5); call(0x1015_26ac, 0x8_608b);            /* call 0x101526ac */
            ii(0x100c_c621, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x100c_c624, 2); if(jz(0x100c_c628, 2)) goto l_0x100c_c628; /* jz 0x100cc628 */
        l_0x100c_c626:
            ii(0x100c_c626, 2); jmp(0x100c_c647, 0x1f); goto l_0x100c_c647; /* jmp 0x100cc647 */
        l_0x100c_c628:
            ii(0x100c_c628, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_c62b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_c62e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c631, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100c_c634, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_c637, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c63a, 5); call(0x1007_65d0, -0x5_606f);           /* call 0x100765d0 */
            ii(0x100c_c63f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c641, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c644, 3); call_abs(memd[ds, ebx + 68]);           /* call dword [ebx+0x44] */
        l_0x100c_c647:
            ii(0x100c_c647, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_c649, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_c64a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_c64b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_c64c, 1); pop(edx);                               /* pop edx */
            ii(0x100c_c64d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_c64e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_c64f, 1); ret();                                  /* ret */
        }
    }
}
