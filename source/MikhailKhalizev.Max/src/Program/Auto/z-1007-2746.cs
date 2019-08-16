using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9c5edb7-131f-4f64-bf53-2b0f5ae60927")]
        public void Method_1007_2746()
        {
            ii(0x1007_2746, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_274b, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3602); /* call 0x10165d52 */
            ii(0x1007_2750, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_2751, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2752, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2753, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2754, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2755, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2757, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_275d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_2760, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_2763, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_2766, 5); calld(0x1007_6338, 0x3bcd);             /* call 0x10076338 */
            ii(0x1007_276b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_276d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_2770, 5); calld(0x1007_64b8, 0x3d43);             /* call 0x100764b8 */
        l_0x1007_2775:
            ii(0x1007_2775, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2777, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_277a, 5); calld(0x1013_ad71, 0xc_85f2);           /* call 0x1013ad71 */
            ii(0x1007_277f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2781, 2); if(jzd(0x1007_27b5, 0x32)) goto l_0x1007_27b5; /* jz 0x100727b5 */
            ii(0x1007_2783, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_2786, 5); calld(0x1007_63a0, 0x3c15);             /* call 0x100763a0 */
            ii(0x1007_278b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_278d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_2790, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_2794, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_2796, 2); if(jnzd(0x1007_27ab, 0x13)) goto l_0x1007_27ab; /* jnz 0x100727ab */
            ii(0x1007_2798, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x1007_279f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_27a1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_27a4, 5); calld(0x1007_5f6c, 0x37c3);             /* call 0x10075f6c */
            ii(0x1007_27a9, 2); jmpd(0x1007_27d2, 0x27); goto l_0x1007_27d2; /* jmp 0x100727d2 */
        l_0x1007_27ab:
            ii(0x1007_27ab, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_27ae, 5); calld(0x1007_6bf8, 0x4445);             /* call 0x10076bf8 */
            ii(0x1007_27b3, 2); jmpd(0x1007_2775, -0x40); goto l_0x1007_2775; /* jmp 0x10072775 */
        l_0x1007_27b5:
            ii(0x1007_27b5, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_27bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_27be, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_27c1, 5); calld(0x1007_5f6c, 0x37a6);             /* call 0x10075f6c */
            ii(0x1007_27c6, 2); jmpd(0x1007_27d2, 0xa); goto l_0x1007_27d2; /* jmp 0x100727d2 */
        //    ii(0x1007_27c8, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1007_27ca, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x1007_27cd, 5); calld(0x1007_5f6c, 0x379a);             /* call 0x10075f6c */
        l_0x1007_27d2:
            ii(0x1007_27d2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_27d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_27d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_27d8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_27d9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_27da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_27db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_27dc, 1); retd(); return;                         /* ret */
        }
    }
}