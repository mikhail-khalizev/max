using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a112-b176540c")]
        public void Method_1013_a112()
        {
            ii(0x1013_a112, 5); push(0x30);                             /* push 0x30 */
            ii(0x1013_a117, 5); call(Definitions.sys_check_available_stack_size, 0x2_bc36); /* call 0x10165d52 */
            ii(0x1013_a11c, 1); push(ebx);                              /* push ebx */
            ii(0x1013_a11d, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a11e, 1); push(esi);                              /* push esi */
            ii(0x1013_a11f, 1); push(edi);                              /* push edi */
            ii(0x1013_a120, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a121, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a123, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_a129, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_a12c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_a12f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a132, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1013_a135, 5); call(0x1007_6d58, -0xc_33e2);           /* call 0x10076d58 */
            ii(0x1013_a13a, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1013_a13d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_a140, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_a143, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_a146, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a149, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1013_a14c, 5); call(0x1007_6d58, -0xc_33f9);           /* call 0x10076d58 */
            ii(0x1013_a151, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1013_a154, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_a157, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_a15a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_a15d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a160, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1013_a165, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_a168, 5); call(0x1007_6b58, -0xc_3615);           /* call 0x10076b58 */
            ii(0x1013_a16d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a16f, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_a172, 5); call(0x1007_6d14, -0xc_3463);           /* call 0x10076d14 */
            ii(0x1013_a177, 2); jmp(0x1013_a181, 8); goto l_0x1013_a181; /* jmp 0x1013a181 */
        l_0x1013_a179:
            ii(0x1013_a179, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_a17c, 5); call(0x1007_6bf8, -0xc_3589);           /* call 0x10076bf8 */
        l_0x1013_a181:
            ii(0x1013_a181, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a183, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_a186, 5); call(0x1013_ad71, 0xbe6);               /* call 0x1013ad71 */
            ii(0x1013_a18b, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a18d, 2); if(jz(0x1013_a1a3, 0x14)) goto l_0x1013_a1a3; /* jz 0x1013a1a3 */
            ii(0x1013_a18f, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_a192, 5); call(0x1007_6c30, -0xc_3567);           /* call 0x10076c30 */
            ii(0x1013_a197, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a199, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a19c, 5); call(0x1013_a2ab, 0x10a);               /* call 0x1013a2ab */
            ii(0x1013_a1a1, 2); jmp(0x1013_a179, -0x2a); goto l_0x1013_a179; /* jmp 0x1013a179 */
        l_0x1013_a1a3:
            ii(0x1013_a1a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a1a5, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_a1a8, 5); call(0x1007_5e24, -0xc_4389);           /* call 0x10075e24 */
            ii(0x1013_a1ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a1b0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_a1b3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_a1b6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a1b8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a1b9, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a1ba, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a1bb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a1bc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_a1bd, 1); ret();                                  /* ret */
        }
    }
}
