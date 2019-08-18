using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("70ca073f-2c68-4930-9693-1610bfee364b")]
        public void Method_1007_ad1f()
        {
            ii(0x1007_ad1f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_ad24, 5); calld(Definitions.sys_check_available_stack_size, 0xe_b029); /* call 0x10165d52 */
            ii(0x1007_ad29, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ad2a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ad2b, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ad2c, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ad2d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ad2e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ad30, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_ad36, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_ad39, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_ad3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ad3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_ad41, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ad44, 5); calld(0x1013_ad11, 0xb_ffc8);           /* call 0x1013ad11 */
            ii(0x1007_ad49, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ad4b, 2); if(jnzd(0x1007_ad5f, 0x12)) goto l_0x1007_ad5f; /* jnz 0x1007ad5f */
            ii(0x1007_ad4d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ad50, 5); calld(0x1007_623c, -0x4b19);            /* call 0x1007623c */
            ii(0x1007_ad55, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_ad58, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_ad5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_ad5d, 2); if(jnzd(0x1007_ad61, 0x2)) goto l_0x1007_ad61; /* jnz 0x1007ad61 */
        l_0x1007_ad5f:
            ii(0x1007_ad5f, 2); jmpd(0x1007_ad7e, 0x1d); goto l_0x1007_ad7e; /* jmp 0x1007ad7e */
        l_0x1007_ad61:
            ii(0x1007_ad61, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ad64, 5); calld(0x1007_623c, -0x4b2d);            /* call 0x1007623c */
            ii(0x1007_ad69, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1007_ad6c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_ad6f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ad72, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1007_ad75, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_ad7a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_ad7c, 2); if(jged(0x1007_ad80, 0x2)) goto l_0x1007_ad80; /* jge 0x1007ad80 */
        l_0x1007_ad7e:
            ii(0x1007_ad7e, 2); jmpd(0x1007_ad92, 0x12); goto l_0x1007_ad92; /* jmp 0x1007ad92 */
        l_0x1007_ad80:
            ii(0x1007_ad80, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_ad83, 3); add(edx, 0x29);                         /* add edx, 0x29 */
            ii(0x1007_ad86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ad89, 5); calld(0x1007_6d98, -0x3ff6);            /* call 0x10076d98 */
            ii(0x1007_ad8e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ad90, 2); if(jzd(0x1007_ad98, 0x6)) goto l_0x1007_ad98; /* jz 0x1007ad98 */
        l_0x1007_ad92:
            ii(0x1007_ad92, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_ad96, 2); jmpd(0x1007_add7, 0x3f); goto l_0x1007_add7; /* jmp 0x1007add7 */
        l_0x1007_ad98:
            ii(0x1007_ad98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ad9b, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1007_ad9e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_ada1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_ada4, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_ada7, 5); calld(0x100b_87da, 0x3_da2e);           /* call 0x100b87da */
            ii(0x1007_adac, 1); cwde();                                 /* cwde */
            ii(0x1007_adad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_adaf, 2); if(jnzd(0x1007_adb7, 0x6)) goto l_0x1007_adb7; /* jnz 0x1007adb7 */
            ii(0x1007_adb1, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_adb5, 2); jmpd(0x1007_add7, 0x20); goto l_0x1007_add7; /* jmp 0x1007add7 */
        l_0x1007_adb7:
            ii(0x1007_adb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_adba, 4); mov(dx, memw_a32[ds, eax + 0x27]);      /* mov dx, [eax+0x27] */
            ii(0x1007_adbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_adc1, 4); cmp(dx, memw_a32[ds, eax + 0x25]);      /* cmp dx, [eax+0x25] */
            ii(0x1007_adc5, 2); if(jled(0x1007_adcd, 0x6)) goto l_0x1007_adcd; /* jle 0x1007adcd */
            ii(0x1007_adc7, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_adcb, 2); jmpd(0x1007_add1, 0x4); goto l_0x1007_add1; /* jmp 0x1007add1 */
        l_0x1007_adcd:
            ii(0x1007_adcd, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_add1:
            ii(0x1007_add1, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_add4, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1007_add7:
            ii(0x1007_add7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_adda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_addc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_addd, 1); popd(edi);                              /* pop edi */
            ii(0x1007_adde, 1); popd(esi);                              /* pop esi */
            ii(0x1007_addf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ade0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ade1, 1); retd(); return;                         /* ret */
        }
    }
}
