using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8902-9120eaac")]
        public void Method_100a_8902()
        {
            ii(0x100a_8902, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_8907, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d446); /* call 0x10165d52 */
            ii(0x100a_890c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_890d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_890e, 1); pushd(edx);                             /* push edx */
            ii(0x100a_890f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8910, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8911, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8912, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8914, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_891a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_891d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_891f, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_8924, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_8926, 2); if(jnzd(0x100a_893d, 0x15)) goto l_0x100a_893d; /* jnz 0x100a893d */
            ii(0x100a_8928, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_892b, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_892e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8931, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8933, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100a_8939, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_893b, 2); if(jnzd(0x100a_893f, 0x2)) goto l_0x100a_893f; /* jnz 0x100a893f */
        l_0x100a_893d:
            ii(0x100a_893d, 2); jmpd(0x100a_8944, 0x5); goto l_0x100a_8944; /* jmp 0x100a8944 */
        l_0x100a_893f:
            ii(0x100a_893f, 5); jmpd(0x100a_8a34, 0xf0); goto l_0x100a_8a34; /* jmp 0x100a8a34 */
        l_0x100a_8944:
            ii(0x100a_8944, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8946, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_894b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_894e, 6); if(jzd(0x100a_8a34, 0xe0)) goto l_0x100a_8a34; /* jz 0x100a8a34 */
            ii(0x100a_8954, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8957, 4); cmp(memb_a32[ds, eax + 0x13], 0x1);     /* cmp byte [eax+0x13], 0x1 */
            ii(0x100a_895b, 6); if(jzd(0x100a_8a34, 0xd3)) goto l_0x100a_8a34; /* jz 0x100a8a34 */
            ii(0x100a_8961, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8964, 4); cmp(memb_a32[ds, eax + 0x13], 0x3);     /* cmp byte [eax+0x13], 0x3 */
            ii(0x100a_8968, 6); if(jzd(0x100a_8a34, 0xc6)) goto l_0x100a_8a34; /* jz 0x100a8a34 */
            ii(0x100a_896e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8971, 4); cmp(memb_a32[ds, eax + 0x13], 0x4);     /* cmp byte [eax+0x13], 0x4 */
            ii(0x100a_8975, 2); if(jnzd(0x100a_89ec, 0x75)) goto l_0x100a_89ec; /* jnz 0x100a89ec */
            ii(0x100a_8977, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_897a, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x100a_897e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8980, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8983, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8986, 5); calld(0x1013_ad71, 0x9_23e6);           /* call 0x1013ad71 */
            ii(0x100a_898b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_898d, 2); if(jzd(0x100a_89ec, 0x5d)) goto l_0x100a_89ec; /* jz 0x100a89ec */
            ii(0x100a_898f, 5); calld(0x1008_ac50, -0x1_dd44);          /* call 0x1008ac50 */
            ii(0x100a_8994, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_8996, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_8998, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_899b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_899e, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_89a1, 5); calld(0x1007_6574, -0x3_2432);          /* call 0x10076574 */
            ii(0x100a_89a6, 5); calld(0x1015_2962, 0xa_9fb7);           /* call 0x10152962 */
            ii(0x100a_89ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_89ae, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_89b1, 5); calld(0x1007_6574, -0x3_2442);          /* call 0x10076574 */
            ii(0x100a_89b6, 5); calld(0x1015_26ac, 0xa_9cf1);           /* call 0x101526ac */
            ii(0x100a_89bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_89bd, 2); if(jnzd(0x100a_89df, 0x20)) goto l_0x100a_89df; /* jnz 0x100a89df */
            ii(0x100a_89bf, 5); calld(0x1008_a79c, -0x1_e228);          /* call 0x1008a79c */
            ii(0x100a_89c4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_89c6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_89c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_89cb, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_89ce, 5); calld(0x1007_65d0, -0x3_2403);          /* call 0x100765d0 */
            ii(0x100a_89d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_89d5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_89da, 5); calld(0x100a_53ac, -0x3633);            /* call 0x100a53ac */
        l_0x100a_89df:
            ii(0x100a_89df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_89e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_89e4, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_89e7, 5); calld(0x1007_6630, -0x3_23bc);          /* call 0x10076630 */
        l_0x100a_89ec:
            ii(0x100a_89ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_89ef, 4); cmp(memb_a32[ds, eax + 0x13], 0);       /* cmp byte [eax+0x13], 0x0 */
            ii(0x100a_89f3, 2); if(jnzd(0x100a_8a2c, 0x37)) goto l_0x100a_8a2c; /* jnz 0x100a8a2c */
        l_0x100a_89f5:
            ii(0x100a_89f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_89f8, 5); calld(0x100a_7a31, -0xfcc);             /* call 0x100a7a31 */
            ii(0x100a_89fd, 2); test(al, al);                           /* test al, al */
            ii(0x100a_89ff, 2); if(jnzd(0x100a_8a2c, 0x2b)) goto l_0x100a_8a2c; /* jnz 0x100a8a2c */
            ii(0x100a_8a01, 5); calld(0x1014_82f4, 0x9_f8ee);           /* call 0x101482f4 */
            ii(0x100a_8a06, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x100a_8a0c, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x100a_8a12, 2); if(jbed(0x100a_8a2a, 0x16)) goto l_0x100a_8a2a; /* jbe 0x100a8a2a */
            ii(0x100a_8a14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8a17, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x100a_8a1b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_8a20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8a23, 5); calld(0x100a_28ff, -0x6129);            /* call 0x100a28ff */
            ii(0x100a_8a28, 2); jmpd(0x100a_8a34, 0xa); goto l_0x100a_8a34; /* jmp 0x100a8a34 */
        l_0x100a_8a2a:
            ii(0x100a_8a2a, 2); jmpd(0x100a_89f5, -0x37); goto l_0x100a_89f5; /* jmp 0x100a89f5 */
        l_0x100a_8a2c:
            ii(0x100a_8a2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8a2f, 5); calld(0x100a_873d, -0x2f7);             /* call 0x100a873d */
        l_0x100a_8a34:
            ii(0x100a_8a34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8a36, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_8a37, 1); popd(edi);                              /* pop edi */
            ii(0x100a_8a38, 1); popd(esi);                              /* pop esi */
            ii(0x100a_8a39, 1); popd(edx);                              /* pop edx */
            ii(0x100a_8a3a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8a3b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8a3c, 1); retd(); return;                         /* ret */
        }
    }
}
