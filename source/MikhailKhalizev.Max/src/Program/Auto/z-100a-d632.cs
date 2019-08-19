using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d632-f7be6484")]
        public void Method_100a_d632()
        {
            ii(0x100a_d632, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_d637, 5); calld(Definitions.sys_check_available_stack_size, 0xb_8716); /* call 0x10165d52 */
            ii(0x100a_d63c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_d63d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d63e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d63f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d640, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d642, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_d648, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_d64b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_d64e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_d651, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d654, 5); calld(0x1007_6338, -0x3_7321);          /* call 0x10076338 */
            ii(0x100a_d659, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d65b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d65e, 5); calld(0x1007_64b8, -0x3_71ab);          /* call 0x100764b8 */
            ii(0x100a_d663, 2); jmpd(0x100a_d66d, 0x8); goto l_0x100a_d66d; /* jmp 0x100ad66d */
        l_0x100a_d665:
            ii(0x100a_d665, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d668, 5); calld(0x1007_6bf8, -0x3_6a75);          /* call 0x10076bf8 */
        l_0x100a_d66d:
            ii(0x100a_d66d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d66f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d672, 5); calld(0x1013_ad71, 0x8_d6fa);           /* call 0x1013ad71 */
            ii(0x100a_d677, 2); test(al, al);                           /* test al, al */
            ii(0x100a_d679, 2); if(jzd(0x100a_d6bd, 0x42)) goto l_0x100a_d6bd; /* jz 0x100ad6bd */
            ii(0x100a_d67b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d67e, 5); calld(0x1007_63a0, -0x3_72e3);          /* call 0x100763a0 */
            ii(0x100a_d683, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d685, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_d688, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_d68c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_d68e, 2); if(jnzd(0x100a_d6a2, 0x12)) goto l_0x100a_d6a2; /* jnz 0x100ad6a2 */
            ii(0x100a_d690, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d693, 5); calld(0x1007_63a0, -0x3_72f8);          /* call 0x100763a0 */
            ii(0x100a_d698, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100a_d69c, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100a_d6a0, 2); if(jzd(0x100a_d6a4, 0x2)) goto l_0x100a_d6a4; /* jz 0x100ad6a4 */
        l_0x100a_d6a2:
            ii(0x100a_d6a2, 2); jmpd(0x100a_d6bb, 0x17); goto l_0x100a_d6bb; /* jmp 0x100ad6bb */
        l_0x100a_d6a4:
            ii(0x100a_d6a4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d6a7, 5); calld(0x1007_63d4, -0x3_72d8);          /* call 0x100763d4 */
            ii(0x100a_d6ac, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_d6af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d6b1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d6b4, 5); calld(0x1007_5f6c, -0x3_774d);          /* call 0x10075f6c */
            ii(0x100a_d6b9, 2); jmpd(0x100a_d6da, 0x1f); goto l_0x100a_d6da; /* jmp 0x100ad6da */
        l_0x100a_d6bb:
            ii(0x100a_d6bb, 2); jmpd(0x100a_d665, -0x58); goto l_0x100a_d665; /* jmp 0x100ad665 */
        l_0x100a_d6bd:
            ii(0x100a_d6bd, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_d6c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d6c6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_d6c9, 5); calld(0x1007_5f6c, -0x3_7762);          /* call 0x10075f6c */
            ii(0x100a_d6ce, 2); jmpd(0x100a_d6da, 0xa); goto l_0x100a_d6da; /* jmp 0x100ad6da */
        //  ii(0x100a_d6d0, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_d6d2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //  ii(0x100a_d6d5, 5); calld(0x1007_5f6c, -0x3_776e);          /* call 0x10075f6c */
        l_0x100a_d6da:
            ii(0x100a_d6da, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_d6dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d6df, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_d6e0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_d6e1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_d6e2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_d6e3, 1); retd(); return;                         /* ret */
        }
    }
}
