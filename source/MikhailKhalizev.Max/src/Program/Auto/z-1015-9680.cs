using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9680-db7b9f76")]
        public void Method_1015_9680()
        {
            ii(0x1015_9680, 5); push(0x1c4);                            /* push 0x1c4 */
            ii(0x1015_9685, 5); call(Definitions.sys_check_available_stack_size, 0xc6c8); /* call 0x10165d52 */
            ii(0x1015_968a, 1); push(ebx);                              /* push ebx */
            ii(0x1015_968b, 1); push(ecx);                              /* push ecx */
            ii(0x1015_968c, 1); push(esi);                              /* push esi */
            ii(0x1015_968d, 1); push(edi);                              /* push edi */
            ii(0x1015_968e, 1); push(ebp);                              /* push ebp */
            ii(0x1015_968f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9691, 6); sub(esp, 0x19c);                        /* sub esp, 0x19c */
            ii(0x1015_9697, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_969a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_969d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_96a0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_96a3, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_96a8, 5); call(0x100f_448c, -0x6_5221);           /* call 0x100f448c */
            ii(0x1015_96ad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_96af, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x1015_96b4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_96b7, 5); call(0x1016_3053, 0x9997);              /* call 0x10163053 */
            ii(0x1015_96bc, 5); mov(eax, StringDefinitions.On);         /* mov eax, 0x101b260d */
            ii(0x1015_96c1, 1); push(eax);                              /* push eax */
            ii(0x1015_96c2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_96c5, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_96c8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_96cb, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_96ce, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1015_96d4, 5); mov(eax, StringDefinitions.SPoweredS);  /* mov eax, 0x101b2610 */
            ii(0x1015_96d9, 1); push(eax);                              /* push eax */
            ii(0x1015_96da, 6); lea(eax, memd[ss, ebp - 0x19c]);        /* lea eax, [ebp-0x19c] */
            ii(0x1015_96e0, 1); push(eax);                              /* push eax */
            ii(0x1015_96e1, 5); call(Definitions.sys_sprintf, 0xc81b);  /* call 0x10165f01 */
            ii(0x1015_96e6, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_96e9, 5); call(0x100c_aa00, -0x8_ecee);           /* call 0x100caa00 */
            ii(0x1015_96ee, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_96f3, 1); push(eax);                              /* push eax */
            ii(0x1015_96f4, 5); call(0x100c_aa20, -0x8_ecd9);           /* call 0x100caa20 */
            ii(0x1015_96f9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_96fb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_96fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_96ff, 6); lea(eax, memd[ss, ebp - 0x19c]);        /* lea eax, [ebp-0x19c] */
            ii(0x1015_9705, 5); call(0x1011_5d23, -0x4_39e7);           /* call 0x10115d23 */
            ii(0x1015_970a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_970c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_970d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_970e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_970f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9710, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9711, 1); ret();                                  /* ret */
        }
    }
}
