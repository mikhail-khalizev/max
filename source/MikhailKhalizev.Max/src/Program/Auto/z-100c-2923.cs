using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18629821-7276-4177-a96e-7487f9e3506b")]
        public void Method_100c_2923()
        {
            ii(0x100c_2923, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100c_2928, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3425); /* call 0x10165d52 */
            ii(0x100c_292d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_292e, 1); pushd(esi);                             /* push esi */
            ii(0x100c_292f, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2930, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2931, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2933, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_2939, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_293c, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_293f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_2942, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x100c_2946, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2949, 5); calld(0x1007_64fc, -0x4_c452);          /* call 0x100764fc */
            ii(0x100c_294e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_2951, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100c_2955, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100c_2959, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_295c, 9); test(memw_a32[ds, eax + 0x101c_81c0], 0x180); /* test word [eax+0x101c81c0], 0x180 */
            ii(0x100c_2965, 2); if(jzd(0x100c_297f, 0x18)) goto l_0x100c_297f; /* jz 0x100c297f */
            ii(0x100c_2967, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_296c, 5); calld(0x1007_6338, -0x4_c639);          /* call 0x10076338 */
            ii(0x100c_2971, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100c_2974, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2976, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_2978, 5); calld(0x1007_643c, -0x4_c541);          /* call 0x1007643c */
            ii(0x100c_297d, 2); jmpd(0x100c_29bd, 0x3e); goto l_0x100c_29bd; /* jmp 0x100c29bd */
        l_0x100c_297f:
            ii(0x100c_297f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100c_2983, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_2986, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x40); /* test byte [eax+0x101c81c0], 0x40 */
            ii(0x100c_298d, 2); if(jzd(0x100c_29a7, 0x18)) goto l_0x100c_29a7; /* jz 0x100c29a7 */
            ii(0x100c_298f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100c_2994, 5); calld(0x1007_6338, -0x4_c661);          /* call 0x10076338 */
            ii(0x100c_2999, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100c_299c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_299e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_29a0, 5); calld(0x1007_643c, -0x4_c569);          /* call 0x1007643c */
            ii(0x100c_29a5, 2); jmpd(0x100c_29bd, 0x16); goto l_0x100c_29bd; /* jmp 0x100c29bd */
        l_0x100c_29a7:
            ii(0x100c_29a7, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_29ac, 5); calld(0x1007_6338, -0x4_c679);          /* call 0x10076338 */
            ii(0x100c_29b1, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100c_29b4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_29b6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_29b8, 5); calld(0x1007_643c, -0x4_c581);          /* call 0x1007643c */
        l_0x100c_29bd:
            ii(0x100c_29bd, 2); jmpd(0x100c_29c7, 0x8); goto l_0x100c_29c7; /* jmp 0x100c29c7 */
        l_0x100c_29bf:
            ii(0x100c_29bf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_29c2, 5); calld(0x1007_6bf8, -0x4_bdcf);          /* call 0x10076bf8 */
        l_0x100c_29c7:
            ii(0x100c_29c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_29c9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_29cc, 5); calld(0x1013_ad71, 0x7_83a0);           /* call 0x1013ad71 */
            ii(0x100c_29d1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_29d3, 6); if(jzd(0x100c_2a49, 0x70)) goto l_0x100c_2a49; /* jz 0x100c2a49 */
            ii(0x100c_29d9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_29dc, 5); calld(0x1007_63a0, -0x4_c641);          /* call 0x100763a0 */
            ii(0x100c_29e1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_29e3, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_29e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_29e9, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_29ec, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_29ee, 2); if(jnzd(0x100c_2a02, 0x12)) goto l_0x100c_2a02; /* jnz 0x100c2a02 */
            ii(0x100c_29f0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_29f3, 5); calld(0x1007_63a0, -0x4_c658);          /* call 0x100763a0 */
            ii(0x100c_29f8, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100c_29fc, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100c_2a00, 2); if(jzd(0x100c_2a04, 0x2)) goto l_0x100c_2a04; /* jz 0x100c2a04 */
        l_0x100c_2a02:
            ii(0x100c_2a02, 2); jmpd(0x100c_2a32, 0x2e); goto l_0x100c_2a32; /* jmp 0x100c2a32 */
        l_0x100c_2a04:
            ii(0x100c_2a04, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2a07, 5); calld(0x1007_63a0, -0x4_c66c);          /* call 0x100763a0 */
            ii(0x100c_2a0c, 5); calld(0x1015_26ac, 0x8_fc9b);           /* call 0x101526ac */
            ii(0x100c_2a11, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_2a13, 2); if(jzd(0x100c_2a30, 0x1b)) goto l_0x100c_2a30; /* jz 0x100c2a30 */
            ii(0x100c_2a15, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_2a19, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2a1c, 5); calld(0x1007_63a0, -0x4_c681);          /* call 0x100763a0 */
            ii(0x100c_2a21, 5); calld(0x1015_26ac, 0x8_fc86);           /* call 0x101526ac */
            ii(0x100c_2a26, 5); calld(0x100a_2bc4, -0x1_fe67);          /* call 0x100a2bc4 */
            ii(0x100c_2a2b, 1); cwde();                                 /* cwde */
            ii(0x100c_2a2c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_2a2e, 2); if(jled(0x100c_2a32, 0x2)) goto l_0x100c_2a32; /* jle 0x100c2a32 */
        l_0x100c_2a30:
            ii(0x100c_2a30, 2); jmpd(0x100c_2a34, 0x2); goto l_0x100c_2a34; /* jmp 0x100c2a34 */
        l_0x100c_2a32:
            ii(0x100c_2a32, 2); jmpd(0x100c_2a44, 0x10); goto l_0x100c_2a44; /* jmp 0x100c2a44 */
        l_0x100c_2a34:
            ii(0x100c_2a34, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_2a38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2a3a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2a3d, 5); calld(0x1007_5f6c, -0x4_cad6);          /* call 0x10075f6c */
            ii(0x100c_2a42, 2); jmpd(0x100c_2a63, 0x1f); goto l_0x100c_2a63; /* jmp 0x100c2a63 */
        l_0x100c_2a44:
            ii(0x100c_2a44, 5); jmpd(0x100c_29bf, -0x8a); goto l_0x100c_29bf; /* jmp 0x100c29bf */
        l_0x100c_2a49:
            ii(0x100c_2a49, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_2a4d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2a4f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2a52, 5); calld(0x1007_5f6c, -0x4_caeb);          /* call 0x10075f6c */
            ii(0x100c_2a57, 2); jmpd(0x100c_2a63, 0xa); goto l_0x100c_2a63; /* jmp 0x100c2a63 */
        //    ii(0x100c_2a59, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100c_2a5b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x100c_2a5e, 5); calld(0x1007_5f6c, -0x4_caf7);          /* call 0x10075f6c */
        l_0x100c_2a63:
            ii(0x100c_2a63, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100c_2a66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2a68, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2a69, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2a6a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2a6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_2a6c, 1); retd(); return;                         /* ret */
        }
    }
}
