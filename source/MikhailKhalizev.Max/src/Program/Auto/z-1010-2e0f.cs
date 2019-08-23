using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2e0f-8c27298a")]
        public void Method_1010_2e0f()
        {
            ii(0x1010_2e0f, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_2e14, 5); call(Definitions.sys_check_available_stack_size, 0x6_2f39); /* call 0x10165d52 */
            ii(0x1010_2e19, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2e1a, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2e1b, 1); push(edx);                              /* push edx */
            ii(0x1010_2e1c, 1); push(esi);                              /* push esi */
            ii(0x1010_2e1d, 1); push(edi);                              /* push edi */
            ii(0x1010_2e1e, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2e1f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2e21, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_2e27, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_2e2a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2e2d, 5); call(0x1007_6338, -0x8_cafa);           /* call 0x10076338 */
            ii(0x1010_2e32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_2e34, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e37, 5); call(0x1007_64b8, -0x8_c984);           /* call 0x100764b8 */
            ii(0x1010_2e3c, 2); jmp(0x1010_2e46, 0x8); goto l_0x1010_2e46; /* jmp 0x10102e46 */
        l_0x1010_2e3e:
            ii(0x1010_2e3e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e41, 5); call(0x1007_6bf8, -0x8_c24e);           /* call 0x10076bf8 */
        l_0x1010_2e46:
            ii(0x1010_2e46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2e48, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e4b, 5); call(0x1013_ad71, 0x3_7f21);            /* call 0x1013ad71 */
            ii(0x1010_2e50, 2); test(al, al);                           /* test al, al */
            ii(0x1010_2e52, 2); if(jz(0x1010_2e81, 0x2d)) goto l_0x1010_2e81; /* jz 0x10102e81 */
            ii(0x1010_2e54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2e56, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e59, 5); call(0x1007_63a0, -0x8_cabe);           /* call 0x100763a0 */
            ii(0x1010_2e5e, 5); call(0x1008_a998, -0x7_84cb);           /* call 0x1008a998 */
            ii(0x1010_2e63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2e65, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e68, 5); call(0x1007_63a0, -0x8_cacd);           /* call 0x100763a0 */
            ii(0x1010_2e6d, 5); call(0x1007_60ac, -0x8_cdc6);           /* call 0x100760ac */
            ii(0x1010_2e72, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e75, 5); call(0x1007_63a0, -0x8_cada);           /* call 0x100763a0 */
            ii(0x1010_2e7a, 5); call(0x1015_287d, 0x4_f9fe);            /* call 0x1015287d */
            ii(0x1010_2e7f, 2); jmp(0x1010_2e3e, -0x43); goto l_0x1010_2e3e; /* jmp 0x10102e3e */
        l_0x1010_2e81:
            ii(0x1010_2e81, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2e84, 5); call(0x1013_a6f4, 0x3_786b);            /* call 0x1013a6f4 */
            ii(0x1010_2e89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2e8b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_2e8e, 5); call(0x1007_5f6c, -0x8_cf27);           /* call 0x10075f6c */
            ii(0x1010_2e93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2e95, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2e96, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2e97, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2e98, 1); pop(edx);                               /* pop edx */
            ii(0x1010_2e99, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2e9a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2e9b, 1); ret();                                  /* ret */
        }
    }
}
