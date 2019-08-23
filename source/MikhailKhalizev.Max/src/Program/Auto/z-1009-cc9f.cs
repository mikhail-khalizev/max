using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cc9f-8305ab7f")]
        public void Method_1009_cc9f()
        {
            ii(0x1009_cc9f, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_cca4, 5); call(Definitions.sys_check_available_stack_size, 0xc_90a9); /* call 0x10165d52 */
            ii(0x1009_cca9, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ccaa, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ccab, 1); push(edx);                              /* push edx */
            ii(0x1009_ccac, 1); push(esi);                              /* push esi */
            ii(0x1009_ccad, 1); push(edi);                              /* push edi */
            ii(0x1009_ccae, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ccaf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ccb1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_ccb7, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_ccba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ccbd, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ccc0, 5); call(0x1007_6338, -0x2_698d);           /* call 0x10076338 */
            ii(0x1009_ccc5, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1009_ccc8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_ccca, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_cccc, 5); call(0x1007_64b8, -0x2_6819);           /* call 0x100764b8 */
            ii(0x1009_ccd1, 2); jmp(0x1009_ccdb, 0x8); goto l_0x1009_ccdb; /* jmp 0x1009ccdb */
        l_0x1009_ccd3:
            ii(0x1009_ccd3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_ccd6, 5); call(0x1007_6bf8, -0x2_60e3);           /* call 0x10076bf8 */
        l_0x1009_ccdb:
            ii(0x1009_ccdb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_ccdd, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_cce0, 5); call(0x1013_ad71, 0x9_e08c);            /* call 0x1013ad71 */
            ii(0x1009_cce5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_cce7, 2); if(jz(0x1009_cd08, 0x1f)) goto l_0x1009_cd08; /* jz 0x1009cd08 */
            ii(0x1009_cce9, 5); call(0x1008_a79c, -0x1_2552);           /* call 0x1008a79c */
            ii(0x1009_ccee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_ccf0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_ccf2, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_ccf5, 5); call(0x1007_63d4, -0x2_6926);           /* call 0x100763d4 */
            ii(0x1009_ccfa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_ccfc, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_cd01, 5); call(0x100a_53ac, 0x86a6);              /* call 0x100a53ac */
            ii(0x1009_cd06, 2); jmp(0x1009_ccd3, -0x35); goto l_0x1009_ccd3; /* jmp 0x1009ccd3 */
        l_0x1009_cd08:
            ii(0x1009_cd08, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_cd0b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_cd0e, 5); call(0x1013_a6f4, 0x9_d9e1);            /* call 0x1013a6f4 */
            ii(0x1009_cd13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cd15, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_cd18, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_cd1b, 5); call(0x1008_afe4, -0x1_1d3c);           /* call 0x1008afe4 */
            ii(0x1009_cd20, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_cd23, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_cd28, 5); call(0x100a_5e27, 0x90fa);              /* call 0x100a5e27 */
            ii(0x1009_cd2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cd2f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_cd32, 5); call(0x1007_5f6c, -0x2_6dcb);           /* call 0x10075f6c */
            ii(0x1009_cd37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cd39, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_cd3a, 1); pop(edi);                               /* pop edi */
            ii(0x1009_cd3b, 1); pop(esi);                               /* pop esi */
            ii(0x1009_cd3c, 1); pop(edx);                               /* pop edx */
            ii(0x1009_cd3d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_cd3e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_cd3f, 1); ret();                                  /* ret */
        }
    }
}
