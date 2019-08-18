using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_0bcd-93da4334")]
        public void Method_1014_0bcd()
        {
            ii(0x1014_0bcd, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_0bd2, 5); calld(Definitions.sys_check_available_stack_size, 0x2_517b); /* call 0x10165d52 */
            ii(0x1014_0bd7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_0bd8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_0bd9, 1); pushd(esi);                             /* push esi */
            ii(0x1014_0bda, 1); pushd(edi);                             /* push edi */
            ii(0x1014_0bdb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_0bdc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_0bde, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_0be4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_0be7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_0bea, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1014_0bef, 5); calld(0x1008_a768, -0xb_648c);          /* call 0x1008a768 */
            ii(0x1014_0bf4, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1014_0bf7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0bf9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_0bfb, 5); calld(0x1008_ae70, -0xb_5d90);          /* call 0x1008ae70 */
            ii(0x1014_0c00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0c03, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0c06, 5); calld(0x1013_b325, -0x58e6);            /* call 0x1013b325 */
            ii(0x1014_0c0b, 5); calld(0x1014_1650, 0xa40);              /* call 0x10141650 */
            ii(0x1014_0c10, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0c13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0c15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0c18, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0c1b, 5); calld(0x1014_1564, 0x944);              /* call 0x10141564 */
            ii(0x1014_0c20, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_0c24, 2); if(jnzd(0x1014_0c34, 0xe)) goto l_0x1014_0c34; /* jnz 0x10140c34 */
            ii(0x1014_0c26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0c29, 6); mov(memw_a32[ds, eax + 0x28], 0);       /* mov word [eax+0x28], 0x0 */
            ii(0x1014_0c2f, 5); jmpd(0x1014_0cbd, 0x89); goto l_0x1014_0cbd; /* jmp 0x10140cbd */
        l_0x1014_0c34:
            ii(0x1014_0c34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_0c37, 5); calld(0x1008_ad58, -0xb_5ee4);          /* call 0x1008ad58 */
            ii(0x1014_0c3c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0c3e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0c41, 5); calld(0x1008_b060, -0xb_5be6);          /* call 0x1008b060 */
        l_0x1014_0c46:
            ii(0x1014_0c46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0c48, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0c4b, 5); calld(0x1013_ad71, -0x5edf);            /* call 0x1013ad71 */
            ii(0x1014_0c50, 2); test(al, al);                           /* test al, al */
            ii(0x1014_0c52, 2); if(jzd(0x1014_0c89, 0x35)) goto l_0x1014_0c89; /* jz 0x10140c89 */
            ii(0x1014_0c54, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_0c59, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0c5c, 5); calld(0x1008_afb4, -0xb_5cad);          /* call 0x1008afb4 */
            ii(0x1014_0c61, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1014_0c64, 3); add(ecx, 0x1c);                         /* add ecx, 0x1c */
            ii(0x1014_0c67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0c69, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1014_0c6b, 5); calld(0x1014_1564, 0x8f4);              /* call 0x10141564 */
            ii(0x1014_0c70, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0c73, 5); calld(0x1008_af28, -0xb_5d50);          /* call 0x1008af28 */
            ii(0x1014_0c78, 5); calld(0x1008_ad58, -0xb_5f25);          /* call 0x1008ad58 */
            ii(0x1014_0c7d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0c7f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0c82, 5); calld(0x1008_afe4, -0xb_5ca3);          /* call 0x1008afe4 */
            ii(0x1014_0c87, 2); jmpd(0x1014_0c46, -0x43); goto l_0x1014_0c46; /* jmp 0x10140c46 */
        l_0x1014_0c89:
            ii(0x1014_0c89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0c8c, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0c8f, 5); calld(Definitions.my_1_get_count, -0x9_57bc); /* call 0x100ab4d8 */
            ii(0x1014_0c94, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0c96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0c99, 4); mov(memw_a32[ds, eax + 0x28], dx);      /* mov [eax+0x28], dx */
            ii(0x1014_0c9d, 5); calld(0x1014_1650, 0x9ae);              /* call 0x10141650 */
            ii(0x1014_0ca2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0ca5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_0ca8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0cab, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0cae, 5); calld(0x1014_1564, 0x8b1);              /* call 0x10141564 */
            ii(0x1014_0cb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0cb5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_0cb8, 5); calld(0x1008_8b7c, -0xb_8141);          /* call 0x10088b7c */
        l_0x1014_0cbd:
            ii(0x1014_0cbd, 2); jmpd(0x1014_0cc7, 0x8); goto l_0x1014_0cc7; /* jmp 0x10140cc7 */
        l_0x1014_0cbf:
            ii(0x1014_0cbf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0cc2, 5); calld(0x1007_6bf8, -0xc_a0cf);          /* call 0x10076bf8 */
        l_0x1014_0cc7:
            ii(0x1014_0cc7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0cc9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0ccc, 5); calld(0x1013_ad71, -0x5f60);            /* call 0x1013ad71 */
            ii(0x1014_0cd1, 2); test(al, al);                           /* test al, al */
            ii(0x1014_0cd3, 2); if(jzd(0x1014_0d20, 0x4b)) goto l_0x1014_0d20; /* jz 0x10140d20 */
            ii(0x1014_0cd5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0cd8, 5); calld(0x1008_adc4, -0xb_5f19);          /* call 0x1008adc4 */
            ii(0x1014_0cdd, 5); calld(0x1008_ad90, -0xb_5f52);          /* call 0x1008ad90 */
            ii(0x1014_0ce2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0ce4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0ce7, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x1014_0ceb, 2); if(jnzd(0x1014_0cff, 0x12)) goto l_0x1014_0cff; /* jnz 0x10140cff */
            ii(0x1014_0ced, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0cf0, 5); calld(0x1008_adc4, -0xb_5f31);          /* call 0x1008adc4 */
            ii(0x1014_0cf5, 5); calld(0x1008_ad58, -0xb_5fa2);          /* call 0x1008ad58 */
            ii(0x1014_0cfa, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1014_0cfd, 2); if(jzd(0x1014_0d01, 0x2)) goto l_0x1014_0d01; /* jz 0x10140d01 */
        l_0x1014_0cff:
            ii(0x1014_0cff, 2); jmpd(0x1014_0d1e, 0x1d); goto l_0x1014_0d1e; /* jmp 0x10140d1e */
        l_0x1014_0d01:
            ii(0x1014_0d01, 5); calld(0x1014_1650, 0x94a);              /* call 0x10141650 */
            ii(0x1014_0d06, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0d09, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0d0c, 5); calld(0x1008_adf8, -0xb_5f19);          /* call 0x1008adf8 */
            ii(0x1014_0d11, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0d13, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0d16, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0d19, 5); calld(0x1014_1564, 0x846);              /* call 0x10141564 */
        l_0x1014_0d1e:
            ii(0x1014_0d1e, 2); jmpd(0x1014_0cbf, -0x61); goto l_0x1014_0cbf; /* jmp 0x10140cbf */
        l_0x1014_0d20:
            ii(0x1014_0d20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0d23, 3); mov(edx, memd_a32[ds, eax + 0x26]);     /* mov edx, [eax+0x26] */
            ii(0x1014_0d26, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0d29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0d2c, 5); calld(0x1014_0b0c, -0x225);             /* call 0x10140b0c */
            ii(0x1014_0d31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0d33, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_0d36, 5); calld(0x1008_8bbc, -0xb_817f);          /* call 0x10088bbc */
            ii(0x1014_0d3b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_0d3d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_0d3e, 1); popd(edi);                              /* pop edi */
            ii(0x1014_0d3f, 1); popd(esi);                              /* pop esi */
            ii(0x1014_0d40, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_0d41, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_0d42, 1); retd(); return;                         /* ret */
        }
    }
}
