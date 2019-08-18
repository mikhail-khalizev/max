using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ef3560e-5b61-43c4-8dcd-e684cd696ed1")]
        public void Method_1009_285c()
        {
            ii(0x1009_285c, 5); pushd(0x7c);                            /* push 0x7c */
            ii(0x1009_2861, 5); calld(Definitions.sys_check_available_stack_size, 0xd_34ec); /* call 0x10165d52 */
            ii(0x1009_2866, 1); pushd(esi);                             /* push esi */
            ii(0x1009_2867, 1); pushd(edi);                             /* push edi */
            ii(0x1009_2868, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_2869, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_286b, 6); sub(esp, 0x64);                         /* sub esp, 0x64 */
            ii(0x1009_2871, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_2874, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_2877, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_287a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_287d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2880, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1009_2884, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2885, 1); cwde();                                 /* cwde */
            ii(0x1009_2886, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2887, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_288a, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_288d, 1); inc(eax);                               /* inc eax */
            ii(0x1009_288e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_2891, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2894, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1009_2896, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_2899, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_289c, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1009_289f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_28a2, 5); calld(0x1008_b148, -0x775f);            /* call 0x1008b148 */
            ii(0x1009_28a7, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_28ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_28af, 1); pushd(eax);                             /* push eax */
            ii(0x1009_28b0, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x1009_28b6, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_28b9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_28bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_28bd, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1009_28c0, 5); calld(0x1008_b148, -0x777d);            /* call 0x1008b148 */
            ii(0x1009_28c5, 5); cmp(memw_a32[ss, ebp - 0x4], 0x28);     /* cmp word [ebp-0x4], 0x28 */
            ii(0x1009_28ca, 2); if(jnzd(0x1009_28e7, 0x1b)) goto l_0x1009_28e7; /* jnz 0x100928e7 */
            ii(0x1009_28cc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_28cf, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_28d2, 5); calld(0x1007_5e64, -0x1_ca73);          /* call 0x10075e64 */
            ii(0x1009_28d7, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1009_28da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_28dc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_28de, 5); calld(0x1009_24b6, -0x42d);             /* call 0x100924b6 */
            ii(0x1009_28e3, 2); test(al, al);                           /* test al, al */
            ii(0x1009_28e5, 2); if(jzd(0x1009_28e9, 0x2)) goto l_0x1009_28e9; /* jz 0x100928e9 */
        l_0x1009_28e7:
            ii(0x1009_28e7, 2); jmpd(0x1009_28f2, 0x9); goto l_0x1009_28f2; /* jmp 0x100928f2 */
        l_0x1009_28e9:
            ii(0x1009_28e9, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_28ed, 5); jmpd(0x1009_2c17, 0x325); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_28f2:
            ii(0x1009_28f2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_28f6, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_28f9, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_2900, 2); if(jzd(0x1009_290e, 0xc)) goto l_0x1009_290e; /* jz 0x1009290e */
            ii(0x1009_2902, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_2905, 3); inc(memd_a32[ss, ebp - 0x30]);          /* inc dword [ebp-0x30] */
            ii(0x1009_2908, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_290b, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x1009_290e:
            ii(0x1009_290e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_2913, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2916, 3); cmp(eax, memd_a32[ss, ebp - 0x30]);     /* cmp eax, [ebp-0x30] */
            ii(0x1009_2919, 2); if(jld(0x1009_2928, 0xd)) goto l_0x1009_2928; /* jl 0x10092928 */
            ii(0x1009_291b, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_2920, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2923, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x1009_2926, 2); if(jged(0x1009_2931, 0x9)) goto l_0x1009_2931; /* jge 0x10092931 */
        l_0x1009_2928:
            ii(0x1009_2928, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_292c, 5); jmpd(0x1009_2c17, 0x2e6); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2931:
            ii(0x1009_2931, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_2934, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_2937, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_293a, 2); jmpd(0x1009_2942, 0x6); goto l_0x1009_2942; /* jmp 0x10092942 */
        l_0x1009_293c:
            ii(0x1009_293c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_293f, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
        l_0x1009_2942:
            ii(0x1009_2942, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2945, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2948, 3); cmp(eax, memd_a32[ss, ebp - 0x30]);     /* cmp eax, [ebp-0x30] */
            ii(0x1009_294b, 2); if(jged(0x1009_299e, 0x51)) goto l_0x1009_299e; /* jge 0x1009299e */
            ii(0x1009_294d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_2950, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_2953, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1009_2957, 2); jmpd(0x1009_2960, 0x7); goto l_0x1009_2960; /* jmp 0x10092960 */
        l_0x1009_2959:
            ii(0x1009_2959, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_295c, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
        l_0x1009_2960:
            ii(0x1009_2960, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2963, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2965, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2968, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x1009_296b, 2); if(jged(0x1009_299c, 0x2f)) goto l_0x1009_299c; /* jge 0x1009299c */
            ii(0x1009_296d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2970, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2973, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2976, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_2979, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_297b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_297e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2980, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2983, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2985, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_2987, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2989, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_298c, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_298f, 2); if(jled(0x1009_299a, 0x9)) goto l_0x1009_299a; /* jle 0x1009299a */
            ii(0x1009_2991, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2995, 5); jmpd(0x1009_2c17, 0x27d); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_299a:
            ii(0x1009_299a, 2); jmpd(0x1009_2959, -0x43); goto l_0x1009_2959; /* jmp 0x10092959 */
        l_0x1009_299c:
            ii(0x1009_299c, 2); jmpd(0x1009_293c, -0x62); goto l_0x1009_293c; /* jmp 0x1009293c */
        l_0x1009_299e:
            ii(0x1009_299e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1009_29a5, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_29a8, 1); dec(eax);                               /* dec eax */
            ii(0x1009_29a9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_29ac, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_29af, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_29b2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_29b5, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1009_29b9, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_29c0, 2); jmpd(0x1009_29c6, 0x4); goto l_0x1009_29c6; /* jmp 0x100929c6 */
        l_0x1009_29c2:
            ii(0x1009_29c2, 4); add(memd_a32[ss, ebp - 0x18], 0x2);     /* add dword [ebp-0x18], 0x2 */
        l_0x1009_29c6:
            ii(0x1009_29c6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_29ca, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_29cd, 6); if(jged(0x1009_2a96, 0xc3)) goto l_0x1009_2a96; /* jge 0x10092a96 */
            ii(0x1009_29d3, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1009_29da, 2); jmpd(0x1009_29e2, 0x6); goto l_0x1009_29e2; /* jmp 0x100929e2 */
        l_0x1009_29dc:
            ii(0x1009_29dc, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_29df, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x1009_29e2:
            ii(0x1009_29e2, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_29e5, 3); sub(eax, memd_a32[ss, ebp - 0x38]);     /* sub eax, [ebp-0x38] */
            ii(0x1009_29e8, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1009_29ec, 1); inc(eax);                               /* inc eax */
            ii(0x1009_29ed, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_29ef, 6); if(jged(0x1009_2a91, 0x9c)) goto l_0x1009_2a91; /* jge 0x10092a91 */
            ii(0x1009_29f5, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_29f9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_29fc, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_2a01, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_2a03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2a06, 5); calld(0x1008_b1a4, -0x7867);            /* call 0x1008b1a4 */
            ii(0x1009_2a0b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_2a0e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1009_2a11, 5); calld(0x1010_82ce, 0x7_58b8);           /* call 0x101082ce */
            ii(0x1009_2a16, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2a18, 2); if(jnzd(0x1009_2a23, 0x9)) goto l_0x1009_2a23; /* jnz 0x10092a23 */
            ii(0x1009_2a1a, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2a1e, 5); jmpd(0x1009_2c17, 0x1f4); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2a23:
            ii(0x1009_2a23, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2a26, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2a29, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2a2c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_2a2f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_2a31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2a34, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2a36, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2a39, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2a3b, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_2a3d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2a3f, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_2a42, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_2a45, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1009_2a49, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_2a4c, 2); if(jnzd(0x1009_2a55, 0x7)) goto l_0x1009_2a55; /* jnz 0x10092a55 */
            ii(0x1009_2a4e, 5); cmp(memw_a32[ss, ebp - 0x4], 0x28);     /* cmp word [ebp-0x4], 0x28 */
            ii(0x1009_2a53, 2); if(jnzd(0x1009_2a57, 0x2)) goto l_0x1009_2a57; /* jnz 0x10092a57 */
        l_0x1009_2a55:
            ii(0x1009_2a55, 2); jmpd(0x1009_2a60, 0x9); goto l_0x1009_2a60; /* jmp 0x10092a60 */
        l_0x1009_2a57:
            ii(0x1009_2a57, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2a5b, 5); jmpd(0x1009_2c17, 0x1b7); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2a60:
            ii(0x1009_2a60, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_2a64, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2a66, 2); if(jzd(0x1009_2a79, 0x11)) goto l_0x1009_2a79; /* jz 0x10092a79 */
            ii(0x1009_2a68, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_2a6c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2a6e, 5); mov(ax, memw_a32[ds, eax + ebp - 0x66]); /* mov ax, [eax+ebp-0x66] */
            ii(0x1009_2a73, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x1009_2a77, 2); if(jzd(0x1009_2a8c, 0x13)) goto l_0x1009_2a8c; /* jz 0x10092a8c */
        l_0x1009_2a79:
            ii(0x1009_2a79, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_2a7c, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x1009_2a7f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_2a82, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2a84, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_2a87, 5); mov(memw_a32[ds, edx + ebp - 0x64], ax); /* mov [edx+ebp-0x64], ax */
        l_0x1009_2a8c:
            ii(0x1009_2a8c, 5); jmpd(0x1009_29dc, -0xb5); goto l_0x1009_29dc; /* jmp 0x100929dc */
        l_0x1009_2a91:
            ii(0x1009_2a91, 5); jmpd(0x1009_29c2, -0xd4); goto l_0x1009_29c2; /* jmp 0x100929c2 */
        l_0x1009_2a96:
            ii(0x1009_2a96, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_2a9a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_2a9d, 2); if(jled(0x1009_2aaf, 0x10)) goto l_0x1009_2aaf; /* jle 0x10092aaf */
            ii(0x1009_2a9f, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1009_2aa3, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2aa5, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1009_2aa8, 5); cmp(ax, memw_a32[ds, edx + ebp - 0x66]); /* cmp ax, [edx+ebp-0x66] */
            ii(0x1009_2aad, 2); if(jzd(0x1009_2ab1, 0x2)) goto l_0x1009_2ab1; /* jz 0x10092ab1 */
        l_0x1009_2aaf:
            ii(0x1009_2aaf, 2); jmpd(0x1009_2ab7, 0x6); goto l_0x1009_2ab7; /* jmp 0x10092ab7 */
        l_0x1009_2ab1:
            ii(0x1009_2ab1, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_2ab4, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
        l_0x1009_2ab7:
            ii(0x1009_2ab7, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1009_2abe, 2); jmpd(0x1009_2ac6, 0x6); goto l_0x1009_2ac6; /* jmp 0x10092ac6 */
        l_0x1009_2ac0:
            ii(0x1009_2ac0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_2ac3, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x1009_2ac6:
            ii(0x1009_2ac6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_2aca, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1009_2ace, 1); dec(eax);                               /* dec eax */
            ii(0x1009_2acf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_2ad1, 2); if(jged(0x1009_2b22, 0x4f)) goto l_0x1009_2b22; /* jge 0x10092b22 */
            ii(0x1009_2ad3, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_2ad7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2ad9, 4); mov(eax, memd_a32[ds, eax + ebp - 0x66]); /* mov eax, [eax+ebp-0x66] */
            ii(0x1009_2add, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2ae0, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1009_2ae3, 2); if(jld(0x1009_2b20, 0x3b)) goto l_0x1009_2b20; /* jl 0x10092b20 */
            ii(0x1009_2ae5, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_2ae8, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2ae9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_2aec, 2); jmpd(0x1009_2af4, 0x6); goto l_0x1009_2af4; /* jmp 0x10092af4 */
        l_0x1009_2aee:
            ii(0x1009_2aee, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_2af1, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1009_2af4:
            ii(0x1009_2af4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_2af7, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x1009_2afb, 2); if(jged(0x1009_2b20, 0x23)) goto l_0x1009_2b20; /* jge 0x10092b20 */
            ii(0x1009_2afd, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_2b01, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2b03, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_2b07, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2b09, 5); mov(ax, memw_a32[ds, eax + ebp - 0x64]); /* mov ax, [eax+ebp-0x64] */
            ii(0x1009_2b0e, 5); cmp(ax, memw_a32[ds, edx + ebp - 0x64]); /* cmp ax, [edx+ebp-0x64] */
            ii(0x1009_2b13, 2); if(jnzd(0x1009_2b1e, 0x9)) goto l_0x1009_2b1e; /* jnz 0x10092b1e */
            ii(0x1009_2b15, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2b19, 5); jmpd(0x1009_2c17, 0xf9); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2b1e:
            ii(0x1009_2b1e, 2); jmpd(0x1009_2aee, -0x32); goto l_0x1009_2aee; /* jmp 0x10092aee */
        l_0x1009_2b20:
            ii(0x1009_2b20, 2); jmpd(0x1009_2ac0, -0x62); goto l_0x1009_2ac0; /* jmp 0x10092ac0 */
        l_0x1009_2b22:
            ii(0x1009_2b22, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1009_2b29, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_2b2c, 1); dec(eax);                               /* dec eax */
            ii(0x1009_2b2d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_2b30, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_2b33, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_2b36, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_2b39, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1009_2b3d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_2b44, 2); jmpd(0x1009_2b4a, 0x4); goto l_0x1009_2b4a; /* jmp 0x10092b4a */
        l_0x1009_2b46:
            ii(0x1009_2b46, 4); add(memd_a32[ss, ebp - 0x18], 0x2);     /* add dword [ebp-0x18], 0x2 */
        l_0x1009_2b4a:
            ii(0x1009_2b4a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_2b4e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_2b51, 6); if(jged(0x1009_2bcf, 0x78)) goto l_0x1009_2bcf; /* jge 0x10092bcf */
            ii(0x1009_2b57, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1009_2b5e, 2); jmpd(0x1009_2b66, 0x6); goto l_0x1009_2b66; /* jmp 0x10092b66 */
        l_0x1009_2b60:
            ii(0x1009_2b60, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_2b63, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x1009_2b66:
            ii(0x1009_2b66, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_2b69, 3); sub(eax, memd_a32[ss, ebp - 0x38]);     /* sub eax, [ebp-0x38] */
            ii(0x1009_2b6c, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1009_2b70, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_2b72, 2); if(jged(0x1009_2bb4, 0x40)) goto l_0x1009_2bb4; /* jge 0x10092bb4 */
            ii(0x1009_2b74, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_2b78, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2b7b, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_2b80, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_2b82, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2b85, 5); calld(0x1008_b1a4, -0x79e6);            /* call 0x1008b1a4 */
            ii(0x1009_2b8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2b8d, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1009_2b90, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_2b93, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_2b96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2b99, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2b9b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2b9e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2ba0, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_2ba2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2ba4, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2ba7, 3); cmp(eax, 0x7);                          /* cmp eax, 0x7 */
            ii(0x1009_2baa, 2); if(jged(0x1009_2bb2, 0x6)) goto l_0x1009_2bb2; /* jge 0x10092bb2 */
            ii(0x1009_2bac, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_2baf, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1009_2bb2:
            ii(0x1009_2bb2, 2); jmpd(0x1009_2b60, -0x54); goto l_0x1009_2b60; /* jmp 0x10092b60 */
        l_0x1009_2bb4:
            ii(0x1009_2bb4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_2bb8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2bbb, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_2bc0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_2bc2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2bc5, 5); calld(0x1008_b1a4, -0x7a26);            /* call 0x1008b1a4 */
            ii(0x1009_2bca, 5); jmpd(0x1009_2b46, -0x89); goto l_0x1009_2b46; /* jmp 0x10092b46 */
        l_0x1009_2bcf:
            ii(0x1009_2bcf, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_2bd3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2bd5, 2); if(jnzd(0x1009_2bdd, 0x6)) goto l_0x1009_2bdd; /* jnz 0x10092bdd */
            ii(0x1009_2bd7, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2bdb, 2); jmpd(0x1009_2c17, 0x3a); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2bdd:
            ii(0x1009_2bdd, 5); cmp(memw_a32[ss, ebp - 0x4], 0x28);     /* cmp word [ebp-0x4], 0x28 */
            ii(0x1009_2be2, 2); if(jzd(0x1009_2c13, 0x2f)) goto l_0x1009_2c13; /* jz 0x10092c13 */
            ii(0x1009_2be4, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_2be7, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2be8, 1); cwde();                                 /* cwde */
            ii(0x1009_2be9, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2bea, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_2bed, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2bee, 1); cwde();                                 /* cwde */
            ii(0x1009_2bef, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2bf0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_2bf3, 1); dec(eax);                               /* dec eax */
            ii(0x1009_2bf4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_2bf7, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_2bfa, 1); dec(eax);                               /* dec eax */
            ii(0x1009_2bfb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_2bfe, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_2c01, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_2c04, 5); calld(0x1009_262c, -0x5dd);             /* call 0x1009262c */
            ii(0x1009_2c09, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2c0b, 2); if(jzd(0x1009_2c13, 0x6)) goto l_0x1009_2c13; /* jz 0x10092c13 */
            ii(0x1009_2c0d, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2c11, 2); jmpd(0x1009_2c17, 0x4); goto l_0x1009_2c17; /* jmp 0x10092c17 */
        l_0x1009_2c13:
            ii(0x1009_2c13, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x1009_2c17:
            ii(0x1009_2c17, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_2c1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_2c1c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_2c1d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_2c1e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_2c1f, 1); retd(); return;                         /* ret */
        }
    }
}
