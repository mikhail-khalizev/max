using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7e7a-72893bdd")]
        public void Method_100a_7e7a()
        {
            ii(0x100a_7e7a, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_7e7f, 5); call(Definitions.sys_check_available_stack_size, 0xb_dece); /* call 0x10165d52 */
            ii(0x100a_7e84, 1); push(ebx);                              /* push ebx */
            ii(0x100a_7e85, 1); push(ecx);                              /* push ecx */
            ii(0x100a_7e86, 1); push(esi);                              /* push esi */
            ii(0x100a_7e87, 1); push(edi);                              /* push edi */
            ii(0x100a_7e88, 1); push(ebp);                              /* push ebp */
            ii(0x100a_7e89, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7e8b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_7e91, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_7e94, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_7e97, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_7e9e, 2); jmp(0x100a_7ea6, 0x6); goto l_0x100a_7ea6; /* jmp 0x100a7ea6 */
        l_0x100a_7ea0:
            ii(0x100a_7ea0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7ea3, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100a_7ea6:
            ii(0x100a_7ea6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7ea9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7eac, 5); call(Definitions.my_3_get_count, -0x1_ca31); /* call 0x1008b480 */
            ii(0x100a_7eb1, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100a_7eb5, 2); if(jle(0x100a_7ede, 0x27)) goto l_0x100a_7ede; /* jle 0x100a7ede */
            ii(0x100a_7eb7, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100a_7ebb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7ebe, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7ec1, 5); call(0x100a_aa28, 0x2b62);              /* call 0x100aaa28 */
            ii(0x100a_7ec6, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100a_7ec9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7ecb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_7ecd, 5); call(0x100a_b434, 0x3562);              /* call 0x100ab434 */
            ii(0x100a_7ed2, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7ed4, 2); if(jz(0x100a_7edc, 0x6)) goto l_0x100a_7edc; /* jz 0x100a7edc */
            ii(0x100a_7ed6, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_7eda, 2); jmp(0x100a_7f29, 0x4d); goto l_0x100a_7f29; /* jmp 0x100a7f29 */
        l_0x100a_7edc:
            ii(0x100a_7edc, 2); jmp(0x100a_7ea0, -0x3e); goto l_0x100a_7ea0; /* jmp 0x100a7ea0 */
        l_0x100a_7ede:
            ii(0x100a_7ede, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_7ee5, 2); jmp(0x100a_7eed, 0x6); goto l_0x100a_7eed; /* jmp 0x100a7eed */
        l_0x100a_7ee7:
            ii(0x100a_7ee7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7eea, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100a_7eed:
            ii(0x100a_7eed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7ef0, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_7ef3, 5); call(Definitions.my_3_get_count, -0x1_ca78); /* call 0x1008b480 */
            ii(0x100a_7ef8, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100a_7efc, 2); if(jle(0x100a_7f25, 0x27)) goto l_0x100a_7f25; /* jle 0x100a7f25 */
            ii(0x100a_7efe, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100a_7f02, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7f05, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_7f08, 5); call(0x100a_a700, 0x27f3);              /* call 0x100aa700 */
            ii(0x100a_7f0d, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100a_7f10, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7f12, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_7f14, 5); call(0x100a_b434, 0x351b);              /* call 0x100ab434 */
            ii(0x100a_7f19, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7f1b, 2); if(jz(0x100a_7f23, 0x6)) goto l_0x100a_7f23; /* jz 0x100a7f23 */
            ii(0x100a_7f1d, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_7f21, 2); jmp(0x100a_7f29, 0x6); goto l_0x100a_7f29; /* jmp 0x100a7f29 */
        l_0x100a_7f23:
            ii(0x100a_7f23, 2); jmp(0x100a_7ee7, -0x3e); goto l_0x100a_7ee7; /* jmp 0x100a7ee7 */
        l_0x100a_7f25:
            ii(0x100a_7f25, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x100a_7f29:
            ii(0x100a_7f29, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100a_7f2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7f2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_7f2f, 1); pop(edi);                               /* pop edi */
            ii(0x100a_7f30, 1); pop(esi);                               /* pop esi */
            ii(0x100a_7f31, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_7f32, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_7f33, 1); ret();                                  /* ret */
        }
    }
}
