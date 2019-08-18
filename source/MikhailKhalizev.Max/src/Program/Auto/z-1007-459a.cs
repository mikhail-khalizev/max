using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8bb94bf1-a18a-4365-abe3-7d3ccf9f0333")]
        public void Method_1007_459a()
        {
            ii(0x1007_459a, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_459f, 5); calld(Definitions.sys_check_available_stack_size, 0xf_17ae); /* call 0x10165d52 */
            ii(0x1007_45a4, 1); pushd(esi);                             /* push esi */
            ii(0x1007_45a5, 1); pushd(edi);                             /* push edi */
            ii(0x1007_45a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_45a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_45a9, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_45af, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_45b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_45b5, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_45b8, 3); mov(memd_a32[ss, ebp - 0x10], ecx);     /* mov [ebp-0x10], ecx */
            ii(0x1007_45bb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_45bf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_45c1, 2); if(jld(0x1007_45cf, 0xc)) goto l_0x1007_45cf; /* jl 0x100745cf */
            ii(0x1007_45c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_45c6, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_45cd, 2); if(jld(0x1007_45d1, 0x2)) goto l_0x1007_45d1; /* jl 0x100745d1 */
        l_0x1007_45cf:
            ii(0x1007_45cf, 2); jmpd(0x1007_45d9, 0x8); goto l_0x1007_45d9; /* jmp 0x100745d9 */
        l_0x1007_45d1:
            ii(0x1007_45d1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_45d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_45d7, 2); if(jged(0x1007_45db, 0x2)) goto l_0x1007_45db; /* jge 0x100745db */
        l_0x1007_45d9:
            ii(0x1007_45d9, 2); jmpd(0x1007_45e7, 0xc); goto l_0x1007_45e7; /* jmp 0x100745e7 */
        l_0x1007_45db:
            ii(0x1007_45db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_45de, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_45e5, 2); if(jld(0x1007_45f3, 0xc)) goto l_0x1007_45f3; /* jl 0x100745f3 */
        l_0x1007_45e7:
            ii(0x1007_45e7, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_45ee, 5); jmpd(0x1007_46fc, 0x109); goto l_0x1007_46fc; /* jmp 0x100746fc */
        l_0x1007_45f3:
            ii(0x1007_45f3, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_45f7, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_45fb, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4600, 5); calld(0x1010_3541, 0x8_ef3c);           /* call 0x10103541 */
            ii(0x1007_4605, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4607, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_460a, 5); calld(0x1007_64b8, 0x1ea9);             /* call 0x100764b8 */
            ii(0x1007_460f, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1007_4616:
            ii(0x1007_4616, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4618, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_461b, 5); calld(0x1013_ad71, 0xc_6751);           /* call 0x1013ad71 */
            ii(0x1007_4620, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4622, 6); if(jzd(0x1007_46bb, 0x93)) goto l_0x1007_46bb; /* jz 0x100746bb */
            ii(0x1007_4628, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_462b, 5); calld(0x1007_63a0, 0x1d70);             /* call 0x100763a0 */
            ii(0x1007_4630, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4632, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_4635, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_4639, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_463b, 2); if(jzd(0x1007_465d, 0x20)) goto l_0x1007_465d; /* jz 0x1007465d */
            ii(0x1007_463d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_4641, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4644, 5); calld(0x1007_63a0, 0x1d57);             /* call 0x100763a0 */
            ii(0x1007_4649, 5); calld(0x1007_6074, 0x1a26);             /* call 0x10076074 */
            ii(0x1007_464e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4650, 2); if(jnzd(0x1007_465b, 0x9)) goto l_0x1007_465b; /* jnz 0x1007465b */
            ii(0x1007_4652, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1007_4659, 2); if(jzd(0x1007_465d, 0x2)) goto l_0x1007_465d; /* jz 0x1007465d */
        l_0x1007_465b:
            ii(0x1007_465b, 2); jmpd(0x1007_465f, 0x2); goto l_0x1007_465f; /* jmp 0x1007465f */
        l_0x1007_465d:
            ii(0x1007_465d, 2); jmpd(0x1007_466d, 0xe); goto l_0x1007_466d; /* jmp 0x1007466d */
        l_0x1007_465f:
            ii(0x1007_465f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4662, 5); calld(0x1007_63a0, 0x1d39);             /* call 0x100763a0 */
            ii(0x1007_4667, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_466b, 2); if(jnzd(0x1007_466f, 0x2)) goto l_0x1007_466f; /* jnz 0x1007466f */
        l_0x1007_466d:
            ii(0x1007_466d, 2); jmpd(0x1007_467f, 0x10); goto l_0x1007_467f; /* jmp 0x1007467f */
        l_0x1007_466f:
            ii(0x1007_466f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4672, 5); calld(0x1007_63a0, 0x1d29);             /* call 0x100763a0 */
            ii(0x1007_4677, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_467a, 3); test(memd_a32[ss, ebp - 0x10], eax);    /* test [ebp-0x10], eax */
            ii(0x1007_467d, 2); if(jnzd(0x1007_4681, 0x2)) goto l_0x1007_4681; /* jnz 0x10074681 */
        l_0x1007_467f:
            ii(0x1007_467f, 2); jmpd(0x1007_468f, 0xe); goto l_0x1007_468f; /* jmp 0x1007468f */
        l_0x1007_4681:
            ii(0x1007_4681, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4684, 5); calld(0x1007_63a0, 0x1d17);             /* call 0x100763a0 */
            ii(0x1007_4689, 4); cmp(memb_a32[ds, eax + 0x3d], 0x9);     /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1007_468d, 2); if(jnzd(0x1007_4691, 0x2)) goto l_0x1007_4691; /* jnz 0x10074691 */
        l_0x1007_468f:
            ii(0x1007_468f, 2); jmpd(0x1007_469f, 0xe); goto l_0x1007_469f; /* jmp 0x1007469f */
        l_0x1007_4691:
            ii(0x1007_4691, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4694, 5); calld(0x1007_63a0, 0x1d07);             /* call 0x100763a0 */
            ii(0x1007_4699, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x1007_469d, 2); if(jnzd(0x1007_46a1, 0x2)) goto l_0x1007_46a1; /* jnz 0x100746a1 */
        l_0x1007_469f:
            ii(0x1007_469f, 2); jmpd(0x1007_46ae, 0xd); goto l_0x1007_46ae; /* jmp 0x100746ae */
        l_0x1007_46a1:
            ii(0x1007_46a1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_46a4, 5); calld(0x1007_6408, 0x1d5f);             /* call 0x10076408 */
            ii(0x1007_46a9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_46ac, 2); jmpd(0x1007_46bb, 0xd); goto l_0x1007_46bb; /* jmp 0x100746bb */
        l_0x1007_46ae:
            ii(0x1007_46ae, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_46b1, 5); calld(0x1007_6bf8, 0x2542);             /* call 0x10076bf8 */
            ii(0x1007_46b6, 5); jmpd(0x1007_4616, -0xa5); goto l_0x1007_4616; /* jmp 0x10074616 */
        l_0x1007_46bb:
            ii(0x1007_46bb, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_46bf, 2); if(jzd(0x1007_46e0, 0x1f)) goto l_0x1007_46e0; /* jz 0x100746e0 */
            ii(0x1007_46c1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_46c4, 5); cmp(memw_a32[ds, eax + 0x8], 0xf);      /* cmp word [eax+0x8], 0xf */
            ii(0x1007_46c9, 2); if(jzd(0x1007_46d5, 0xa)) goto l_0x1007_46d5; /* jz 0x100746d5 */
            ii(0x1007_46cb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_46ce, 5); cmp(memw_a32[ds, eax + 0x8], 0x10);     /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_46d3, 2); if(jnzd(0x1007_46e0, 0xb)) goto l_0x1007_46e0; /* jnz 0x100746e0 */
        l_0x1007_46d5:
            ii(0x1007_46d5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_46d8, 5); calld(0x1007_611c, 0x1a3f);             /* call 0x1007611c */
            ii(0x1007_46dd, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1007_46e0:
            ii(0x1007_46e0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_46e3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_46e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_46e8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_46eb, 5); calld(0x1007_5f6c, 0x187c);             /* call 0x10075f6c */
            ii(0x1007_46f0, 2); jmpd(0x1007_46fc, 0xa); goto l_0x1007_46fc; /* jmp 0x100746fc */
        //    ii(0x1007_46f2, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1007_46f4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x1007_46f7, 5); calld(0x1007_5f6c, 0x1870);             /* call 0x10075f6c */
        l_0x1007_46fc:
            ii(0x1007_46fc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_46ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4701, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4702, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4703, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4704, 1); retd(); return;                         /* ret */
        }
    }
}
