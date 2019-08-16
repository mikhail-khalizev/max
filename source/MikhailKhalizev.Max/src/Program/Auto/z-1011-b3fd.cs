using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ebf144a-fe72-4d23-ab5e-ed79f5c39fe2")]
        public void Method_1011_b3fd()
        {
            ii(0x1011_b3fd, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1011_b402, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a94b); /* call 0x10165d52 */
            ii(0x1011_b407, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_b408, 1); pushd(esi);                             /* push esi */
            ii(0x1011_b409, 1); pushd(edi);                             /* push edi */
            ii(0x1011_b40a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_b40b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b40d, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1011_b413, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_b416, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_b419, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_b41c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b41f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1011_b422, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_b425, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b428, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1011_b42b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b42e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_b431, 5); calld(0x1007_6aac, -0xa_498a);          /* call 0x10076aac */
            ii(0x1011_b436, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b439, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1011_b43c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_b43e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_b441, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_b444, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b447, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1011_b44b, 2); if(jzd(0x1011_b456, 0x9)) goto l_0x1011_b456; /* jz 0x1011b456 */
            ii(0x1011_b44d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b450, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1011_b454, 2); if(jnzd(0x1011_b458, 0x2)) goto l_0x1011_b458; /* jnz 0x1011b458 */
        l_0x1011_b456:
            ii(0x1011_b456, 2); jmpd(0x1011_b460, 0x8); goto l_0x1011_b460; /* jmp 0x1011b460 */
        l_0x1011_b458:
            ii(0x1011_b458, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_b45c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b45e, 2); if(jgd(0x1011_b465, 0x5)) goto l_0x1011_b465; /* jg 0x1011b465 */
        l_0x1011_b460:
            ii(0x1011_b460, 5); jmpd(0x1011_b5e3, 0x17e); goto l_0x1011_b5e3; /* jmp 0x1011b5e3 */
        l_0x1011_b465:
            ii(0x1011_b465, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_b467, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_b46a, 3); mov(al, memb_a32[ds, edx + 0x64]);      /* mov al, [edx+0x64] */
            ii(0x1011_b46d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_b470, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1011_b473, 5); calld(Definitions.my_ctor_0x101b_4184, -0xa_4988); /* call 0x10076af0 */
            ii(0x1011_b478, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b47b, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1011_b47f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_b482, 2); jmpd(0x1011_b48a, 0x6); goto l_0x1011_b48a; /* jmp 0x1011b48a */
        l_0x1011_b484:
            ii(0x1011_b484, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_b487, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x1011_b48a:
            ii(0x1011_b48a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b48d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b490, 5); calld(0x100b_82bc, -0x6_31d9);          /* call 0x100b82bc */
            ii(0x1011_b495, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x1011_b499, 6); if(jled(0x1011_b5e3, 0x144)) goto l_0x1011_b5e3; /* jle 0x1011b5e3 */
            ii(0x1011_b49f, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b4a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b4a6, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b4a9, 5); calld(0x100b_827c, -0x6_3232);          /* call 0x100b827c */
            ii(0x1011_b4ae, 4); movsx(ebx, memb_a32[ds, eax + 0x1]);    /* movsx ebx, byte [eax+0x1] */
            ii(0x1011_b4b2, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b4b6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b4b9, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b4bc, 5); calld(0x100b_827c, -0x6_3245);          /* call 0x100b827c */
            ii(0x1011_b4c1, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x1011_b4c4, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1011_b4c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b4c8, 6); if(jzd(0x1011_b5de, 0x110)) goto l_0x1011_b5de; /* jz 0x1011b5de */
            ii(0x1011_b4ce, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b4d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b4d5, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b4d8, 5); calld(0x100b_827c, -0x6_3261);          /* call 0x100b827c */
            ii(0x1011_b4dd, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x1011_b4e1, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1011_b4e4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_b4e6, 4); mov(memw_a32[ss, ebp - 0x20], dx);      /* mov [ebp-0x20], dx */
            ii(0x1011_b4ea, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b4ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b4f1, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b4f4, 5); calld(0x100b_827c, -0x6_327d);          /* call 0x100b827c */
            ii(0x1011_b4f9, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x1011_b4fe, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x1011_b501, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_b503, 4); mov(memw_a32[ss, ebp - 0x1e], dx);      /* mov [ebp-0x1e], dx */
            ii(0x1011_b507, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_b50b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b50d, 2); if(jld(0x1011_b51b, 0xc)) goto l_0x1011_b51b; /* jl 0x1011b51b */
            ii(0x1011_b50f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_b512, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_b519, 2); if(jld(0x1011_b51d, 0x2)) goto l_0x1011_b51d; /* jl 0x1011b51d */
        l_0x1011_b51b:
            ii(0x1011_b51b, 2); jmpd(0x1011_b525, 0x8); goto l_0x1011_b525; /* jmp 0x1011b525 */
        l_0x1011_b51d:
            ii(0x1011_b51d, 4); movsx(eax, memw_a32[ss, ebp - 0x1e]);   /* movsx eax, word [ebp-0x1e] */
            ii(0x1011_b521, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b523, 2); if(jged(0x1011_b527, 0x2)) goto l_0x1011_b527; /* jge 0x1011b527 */
        l_0x1011_b525:
            ii(0x1011_b525, 2); jmpd(0x1011_b533, 0xc); goto l_0x1011_b533; /* jmp 0x1011b533 */
        l_0x1011_b527:
            ii(0x1011_b527, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x1011_b52a, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1011_b531, 2); if(jld(0x1011_b538, 0x5)) goto l_0x1011_b538; /* jl 0x1011b538 */
        l_0x1011_b533:
            ii(0x1011_b533, 5); jmpd(0x1011_b5de, 0xa6); goto l_0x1011_b5de; /* jmp 0x1011b5de */
        l_0x1011_b538:
            ii(0x1011_b538, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_b53a, 1); pushd(eax);                             /* push eax */
            ii(0x1011_b53b, 4); movsx(ecx, memw_a32[ss, ebp - 0x1e]);   /* movsx ecx, word [ebp-0x1e] */
            ii(0x1011_b53f, 4); movsx(ebx, memw_a32[ss, ebp - 0x20]);   /* movsx ebx, word [ebp-0x20] */
            ii(0x1011_b543, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b546, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_b549, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_b54b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_b54e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b551, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1011_b554, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_b557, 5); calld(0x1007_02b9, -0xa_b2a3);          /* call 0x100702b9 */
            ii(0x1011_b55c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_b55f, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b563, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b566, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b569, 5); calld(0x100b_827c, -0x6_32f2);          /* call 0x100b827c */
            ii(0x1011_b56e, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x1011_b571, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b573, 2); if(jzd(0x1011_b58c, 0x17)) goto l_0x1011_b58c; /* jz 0x1011b58c */
            ii(0x1011_b575, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_b579, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b57c, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b57f, 5); calld(0x100b_827c, -0x6_3308);          /* call 0x100b827c */
            ii(0x1011_b584, 4); movsx(eax, memb_a32[ds, eax + 0x1]);    /* movsx eax, byte [eax+0x1] */
            ii(0x1011_b588, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b58a, 2); if(jnzd(0x1011_b58e, 0x2)) goto l_0x1011_b58e; /* jnz 0x1011b58e */
        l_0x1011_b58c:
            ii(0x1011_b58c, 2); jmpd(0x1011_b5a1, 0x13); goto l_0x1011_b5a1; /* jmp 0x1011b5a1 */
        l_0x1011_b58e:
            ii(0x1011_b58e, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_b592, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1011_b595, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_b597, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_b59a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_b59c, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_b59e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1011_b5a1:
            ii(0x1011_b5a1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_b5a4, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1011_b5a8, 2); if(jled(0x1011_b5b0, 0x6)) goto l_0x1011_b5b0; /* jle 0x1011b5b0 */
            ii(0x1011_b5aa, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_b5ad, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1011_b5b0:
            ii(0x1011_b5b0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_b5b3, 3); sub(memd_a32[ss, ebp - 0x18], eax);     /* sub [ebp-0x18], eax */
            ii(0x1011_b5b6, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1011_b5bd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_b5c0, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1011_b5c4, 2); if(jled(0x1011_b5d3, 0xd)) goto l_0x1011_b5d3; /* jle 0x1011b5d3 */
            ii(0x1011_b5c6, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1011_b5c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b5cc, 5); calld(0x1007_5e64, -0xa_576d);          /* call 0x10075e64 */
            ii(0x1011_b5d1, 2); jmpd(0x1011_b5ee, 0x1b); goto l_0x1011_b5ee; /* jmp 0x1011b5ee */
        l_0x1011_b5d3:
            ii(0x1011_b5d3, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1011_b5d6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_b5d9, 5); calld(0x1008_8b44, -0x9_2a9a);          /* call 0x10088b44 */
        l_0x1011_b5de:
            ii(0x1011_b5de, 5); jmpd(0x1011_b484, -0x15f); goto l_0x1011_b484; /* jmp 0x1011b484 */
        l_0x1011_b5e3:
            ii(0x1011_b5e3, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1011_b5e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b5e9, 5); calld(0x1007_5e64, -0xa_578a);          /* call 0x10075e64 */
        l_0x1011_b5ee:
            ii(0x1011_b5ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b5f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b5f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_b5f4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_b5f5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_b5f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_b5f7, 1); retd(); return;                         /* ret */
        }
    }
}