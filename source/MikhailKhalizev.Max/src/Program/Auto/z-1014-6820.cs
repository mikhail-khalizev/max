using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6820-18c03a9e")]
        public void Method_1014_6820()
        {
            ii(0x1014_6820, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_6825, 5); call(Definitions.sys_check_available_stack_size, 0x1_f528); /* call 0x10165d52 */
            ii(0x1014_682a, 1); push(ebx);                              /* push ebx */
            ii(0x1014_682b, 1); push(ecx);                              /* push ecx */
            ii(0x1014_682c, 1); push(edx);                              /* push edx */
            ii(0x1014_682d, 1); push(esi);                              /* push esi */
            ii(0x1014_682e, 1); push(edi);                              /* push edi */
            ii(0x1014_682f, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6830, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6832, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_6838, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_683b, 5); mov(eax, memd[ds, 0x101c_7274]);        /* mov eax, [0x101c7274] */
            ii(0x1014_6840, 5); call(Definitions.my_1_get_count, -0x9_b36d); /* call 0x100ab4d8 */
            ii(0x1014_6845, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1014_6849, 2); if(jle(0x1014_6854, 9)) goto l_0x1014_6854; /* jle 0x10146854 */
            ii(0x1014_684b, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_6852, 2); jmp(0x1014_686d, 0x19); goto l_0x1014_686d; /* jmp 0x1014686d */
        l_0x1014_6854:
            ii(0x1014_6854, 5); mov(ecx, 0x255);                        /* mov ecx, 0x255 */
            ii(0x1014_6859, 5); mov(ebx, StringDefinitions.TextfileCpp); /* mov ebx, 0x101ad021 */
            ii(0x1014_685e, 5); mov(edx, StringDefinitions.ArgLessRegisteredClassesGetcount); /* mov edx, 0x101ad02e */
            ii(0x1014_6863, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_6865, 5); call(Definitions.sys_assert, 0x1_f528); /* call 0x10165d92 */
            ii(0x1014_686a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1014_686d:
            ii(0x1014_686d, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_6871, 5); mov(eax, memd[ds, 0x101c_7274]);        /* mov eax, [0x101c7274] */
            ii(0x1014_6876, 5); call(0x1013_c798, -0xa0e3);             /* call 0x1013c798 */
            ii(0x1014_687b, 5); call(0x1014_80e4, 0x1864);              /* call 0x101480e4 */
            ii(0x1014_6880, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_6883, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_6886, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6888, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_6889, 1); pop(edi);                               /* pop edi */
            ii(0x1014_688a, 1); pop(esi);                               /* pop esi */
            ii(0x1014_688b, 1); pop(edx);                               /* pop edx */
            ii(0x1014_688c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_688d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_688e, 1); ret();                                  /* ret */
        }
    }
}
