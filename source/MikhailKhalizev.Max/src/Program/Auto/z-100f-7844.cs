using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7844-d7159b6c")]
        public void Method_100f_7844()
        {
            ii(0x100f_7844, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100f_7849, 5); calld(Definitions.sys_check_available_stack_size, 0x6_e504); /* call 0x10165d52 */
            ii(0x100f_784e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_784f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_7850, 1); pushd(esi);                             /* push esi */
            ii(0x100f_7851, 1); pushd(edi);                             /* push edi */
            ii(0x100f_7852, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_7853, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7855, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100f_785b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_785e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_7861, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100f_7865, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_7868, 5); calld(0x1007_64fc, -0x8_1371);          /* call 0x100764fc */
            ii(0x100f_786d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_7870, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100f_7874, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100f_7878, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_787b, 5); calld(0x1007_6998, -0x8_0ee8);          /* call 0x10076998 */
            ii(0x100f_7880, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_7883, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100f_7887, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_788a, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_788d, 2); if(jnzd(0x100f_78af, 0x20)) goto l_0x100f_78af; /* jnz 0x100f78af */
            ii(0x100f_788f, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100f_7896, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_7898, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_789b, 5); calld(0x1007_5eac, -0x8_19f4);          /* call 0x10075eac */
            ii(0x100f_78a0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_78a2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_78a5, 5); calld(0x1007_5f6c, -0x8_193e);          /* call 0x10075f6c */
            ii(0x100f_78aa, 5); jmpd(0x100f_79c9, 0x11a); goto l_0x100f_79c9; /* jmp 0x100f79c9 */
        l_0x100f_78af:
            ii(0x100f_78af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_78b2, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100f_78b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_78b8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_78bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_78be, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_78c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_78c4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_78c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_78ca, 5); calld(0x1007_6204, -0x8_16cb);          /* call 0x10076204 */
            ii(0x100f_78cf, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100f_78d2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_78d4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_78d6, 5); calld(0x100a_b2a8, -0x4_c633);          /* call 0x100ab2a8 */
            ii(0x100f_78db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_78dd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_78e0, 5); calld(0x1013_ad11, 0x4_342c);           /* call 0x1013ad11 */
            ii(0x100f_78e5, 2); test(al, al);                           /* test al, al */
            ii(0x100f_78e7, 2); if(jzd(0x100f_7915, 0x2c)) goto l_0x100f_7915; /* jz 0x100f7915 */
            ii(0x100f_78e9, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100f_78ed, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_78f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_78f4, 5); calld(0x100f_1f41, -0x59b8);            /* call 0x100f1f41 */
            ii(0x100f_78f9, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_78fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_78fe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_7901, 5); calld(0x1007_5eac, -0x8_1a5a);          /* call 0x10075eac */
            ii(0x100f_7906, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_7908, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_790b, 5); calld(0x1007_5f6c, -0x8_19a4);          /* call 0x10075f6c */
            ii(0x100f_7910, 5); jmpd(0x100f_79c9, 0xb4); goto l_0x100f_79c9; /* jmp 0x100f79c9 */
        l_0x100f_7915:
            ii(0x100f_7915, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_791a, 5); calld(0x1007_6338, -0x8_15e7);          /* call 0x10076338 */
            ii(0x100f_791f, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100f_7922, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_7924, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_7926, 5); calld(0x1007_643c, -0x8_14ef);          /* call 0x1007643c */
        l_0x100f_792b:
            ii(0x100f_792b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_792d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_7930, 5); calld(0x1013_ad71, 0x4_343c);           /* call 0x1013ad71 */
            ii(0x100f_7935, 2); test(al, al);                           /* test al, al */
            ii(0x100f_7937, 2); if(jzd(0x100f_7998, 0x5f)) goto l_0x100f_7998; /* jz 0x100f7998 */
            ii(0x100f_7939, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_793c, 5); calld(0x1007_63a0, -0x8_15a1);          /* call 0x100763a0 */
            ii(0x100f_7941, 5); calld(0x1007_6204, -0x8_1742);          /* call 0x10076204 */
            ii(0x100f_7946, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100f_7949, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_794b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_794d, 5); calld(0x1007_6e00, -0x8_0b52);          /* call 0x10076e00 */
            ii(0x100f_7952, 2); test(al, al);                           /* test al, al */
            ii(0x100f_7954, 2); if(jzd(0x100f_796f, 0x19)) goto l_0x100f_796f; /* jz 0x100f796f */
            ii(0x100f_7956, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100f_795a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_795e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_7961, 5); calld(0x1007_6408, -0x8_155e);          /* call 0x10076408 */
            ii(0x100f_7966, 5); calld(0x100f_1f41, -0x5a2a);            /* call 0x100f1f41 */
            ii(0x100f_796b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_796d, 2); if(jnzd(0x100f_7971, 0x2)) goto l_0x100f_7971; /* jnz 0x100f7971 */
        l_0x100f_796f:
            ii(0x100f_796f, 2); jmpd(0x100f_798e, 0x1d); goto l_0x100f_798e; /* jmp 0x100f798e */
        l_0x100f_7971:
            ii(0x100f_7971, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x100f_7978, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_797a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_797d, 5); calld(0x1007_5eac, -0x8_1ad6);          /* call 0x10075eac */
            ii(0x100f_7982, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_7984, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_7987, 5); calld(0x1007_5f6c, -0x8_1a20);          /* call 0x10075f6c */
            ii(0x100f_798c, 2); jmpd(0x100f_79c9, 0x3b); goto l_0x100f_79c9; /* jmp 0x100f79c9 */
        l_0x100f_798e:
            ii(0x100f_798e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_7991, 5); calld(0x1007_6bf8, -0x8_0d9e);          /* call 0x10076bf8 */
            ii(0x100f_7996, 2); jmpd(0x100f_792b, -0x6d); goto l_0x100f_792b; /* jmp 0x100f792b */
        l_0x100f_7998:
            ii(0x100f_7998, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100f_799f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_79a1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_79a4, 5); calld(0x1007_5eac, -0x8_1afd);          /* call 0x10075eac */
            ii(0x100f_79a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_79ab, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_79ae, 5); calld(0x1007_5f6c, -0x8_1a47);          /* call 0x10075f6c */
            ii(0x100f_79b3, 2); jmpd(0x100f_79c9, 0x14); goto l_0x100f_79c9; /* jmp 0x100f79c9 */
        //    ii(0x100f_79b5, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100f_79b7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100f_79ba, 5); calld(0x1007_5eac, -0x8_1b13);          /* call 0x10075eac */
        //    ii(0x100f_79bf, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100f_79c1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //    ii(0x100f_79c4, 5); calld(0x1007_5f6c, -0x8_1a5d);          /* call 0x10075f6c */
        l_0x100f_79c9:
            ii(0x100f_79c9, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_79cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_79ce, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_79cf, 1); popd(edi);                              /* pop edi */
            ii(0x100f_79d0, 1); popd(esi);                              /* pop esi */
            ii(0x100f_79d1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_79d2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_79d3, 1); retd(); return;                         /* ret */
        }
    }
}
