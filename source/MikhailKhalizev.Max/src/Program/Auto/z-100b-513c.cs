using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9b120098-48ce-4142-baaa-078b97ddacae")]
        public void Method_100b_513c()
        {
            ii(0x100b_513c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_5141, 5); calld(Definitions.sys_check_available_stack_size, 0xb_0c0c); /* call 0x10165d52 */
            ii(0x100b_5146, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5147, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5148, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5149, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_514a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_514c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_5152, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_5155, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_5158, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_515b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_515e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_5161, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_5164, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_5167, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_516a, 5); calld(0x1007_6668, -0x3_eb07);          /* call 0x10076668 */
            ii(0x100b_516f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5171, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5174, 5); calld(0x1013_ad11, 0x8_5b98);           /* call 0x1013ad11 */
            ii(0x100b_5179, 2); test(al, al);                           /* test al, al */
            ii(0x100b_517b, 2); if(jnzd(0x100b_518e, 0x11)) goto l_0x100b_518e; /* jnz 0x100b518e */
            ii(0x100b_517d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_517f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_5182, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_5185, 5); calld(0x1013_ad11, 0x8_5b87);           /* call 0x1013ad11 */
            ii(0x100b_518a, 2); test(al, al);                           /* test al, al */
            ii(0x100b_518c, 2); if(jzd(0x100b_519d, 0xf)) goto l_0x100b_519d; /* jz 0x100b519d */
        l_0x100b_518e:
            ii(0x100b_518e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5190, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5193, 5); calld(0x1007_5f2c, -0x3_f26c);          /* call 0x10075f2c */
            ii(0x100b_5198, 5); jmpd(0x100b_5245, 0xa8); goto l_0x100b_5245; /* jmp 0x100b5245 */
        l_0x100b_519d:
            ii(0x100b_519d, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_51a1, 2); if(jnzd(0x100b_51b9, 0x16)) goto l_0x100b_51b9; /* jnz 0x100b51b9 */
            ii(0x100b_51a3, 5); calld(0x1008_b0e4, -0x2_a0c4);          /* call 0x1008b0e4 */
            ii(0x100b_51a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_51aa, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_51ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_51af, 5); calld(0x100a_297d, -0x1_2837);          /* call 0x100a297d */
            ii(0x100b_51b4, 5); jmpd(0x100b_523b, 0x82); goto l_0x100b_523b; /* jmp 0x100b523b */
        l_0x100b_51b9:
            ii(0x100b_51b9, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100b_51bd, 6); if(jnzd(0x100b_523b, 0x78)) goto l_0x100b_523b; /* jnz 0x100b523b */
            ii(0x100b_51c3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_51c6, 5); calld(0x1007_6574, -0x3_ec57);          /* call 0x10076574 */
            ii(0x100b_51cb, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_51ce, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_51d3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_51d5, 2); if(jzd(0x100b_51eb, 0x14)) goto l_0x100b_51eb; /* jz 0x100b51eb */
            ii(0x100b_51d7, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_51da, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_51dd, 5); calld(0x1007_6574, -0x3_ec6e);          /* call 0x10076574 */
            ii(0x100b_51e2, 5); calld(0x1015_2a52, 0x9_d86b);           /* call 0x10152a52 */
            ii(0x100b_51e7, 2); test(al, al);                           /* test al, al */
            ii(0x100b_51e9, 2); if(jnzd(0x100b_51ed, 0x2)) goto l_0x100b_51ed; /* jnz 0x100b51ed */
        l_0x100b_51eb:
            ii(0x100b_51eb, 2); jmpd(0x100b_523b, 0x4e); goto l_0x100b_523b; /* jmp 0x100b523b */
        l_0x100b_51ed:
            ii(0x100b_51ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_51f0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_51f3, 5); calld(0x1007_6574, -0x3_ec84);          /* call 0x10076574 */
            ii(0x100b_51f8, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100b_51fc, 2); if(jnzd(0x100b_522e, 0x30)) goto l_0x100b_522e; /* jnz 0x100b522e */
            ii(0x100b_51fe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_5201, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_5204, 5); calld(0x1007_6574, -0x3_ec95);          /* call 0x10076574 */
            ii(0x100b_5209, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_520c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_5211, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_5213, 2); if(jzd(0x100b_522c, 0x17)) goto l_0x100b_522c; /* jz 0x100b522c */
            ii(0x100b_5215, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_5218, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_521b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_521e, 5); calld(0x1007_6574, -0x3_ecaf);          /* call 0x10076574 */
            ii(0x100b_5223, 5); calld(0x1015_2a52, 0x9_d82a);           /* call 0x10152a52 */
            ii(0x100b_5228, 2); test(al, al);                           /* test al, al */
            ii(0x100b_522a, 2); if(jnzd(0x100b_522e, 0x2)) goto l_0x100b_522e; /* jnz 0x100b522e */
        l_0x100b_522c:
            ii(0x100b_522c, 2); jmpd(0x100b_523b, 0xd); goto l_0x100b_523b; /* jmp 0x100b523b */
        l_0x100b_522e:
            ii(0x100b_522e, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100b_5233, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_5236, 5); calld(0x100b_4d93, -0x4a8);             /* call 0x100b4d93 */
        l_0x100b_523b:
            ii(0x100b_523b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_523d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5240, 5); calld(0x1007_5f2c, -0x3_f319);          /* call 0x10075f2c */
        l_0x100b_5245:
            ii(0x100b_5245, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5247, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5248, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5249, 1); popd(esi);                              /* pop esi */
            ii(0x100b_524a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_524b, 1); retd(); return;                         /* ret */
        }
    }
}
