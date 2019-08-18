using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a8f2-5f55bd7f")]
        public void Method_1014_a8f2()
        {
            ii(0x1014_a8f2, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1014_a8f7, 5); calld(Definitions.sys_check_available_stack_size, 0x1_b456); /* call 0x10165d52 */
            ii(0x1014_a8fc, 1); pushd(esi);                             /* push esi */
            ii(0x1014_a8fd, 1); pushd(edi);                             /* push edi */
            ii(0x1014_a8fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_a8ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_a901, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1014_a907, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_a90a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_a90d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_a910, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_a913, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_a917, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_a91a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_a91d, 5); calld(0x1015_d211, 0x1_28ef);           /* call 0x1015d211 */
            ii(0x1014_a922, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_a925, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a928, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_a92b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a930, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_a932, 6); if(jled(0x1014_ac91, 0x359)) goto l_0x1014_ac91; /* jle 0x1014ac91 */
            ii(0x1014_a938, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a93b, 4); mov(memb_a32[ds, eax + 0x5a], 0x1);     /* mov byte [eax+0x5a], 0x1 */
            ii(0x1014_a93f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a942, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_a945, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a947, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_a94a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_a94d, 5); calld(0x1007_6074, -0xd_48de);          /* call 0x10076074 */
            ii(0x1014_a952, 2); test(al, al);                           /* test al, al */
            ii(0x1014_a954, 2); if(jnzd(0x1014_a969, 0x13)) goto l_0x1014_a969; /* jnz 0x1014a969 */
            ii(0x1014_a956, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a959, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_a95c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a95e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_a961, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_a964, 5); calld(0x100a_9060, -0xa_1909);          /* call 0x100a9060 */
        l_0x1014_a969:
            ii(0x1014_a969, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a96c, 7); dec(memw_a32[ds, eax + 0xa3]);          /* dec word [eax+0xa3] */
            ii(0x1014_a973, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a976, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x1014_a97c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_a97f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_a981, 2); if(jged(0x1014_a98f, 0xc)) goto l_0x1014_a98f; /* jge 0x1014a98f */
            ii(0x1014_a983, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a986, 9); mov(memw_a32[ds, eax + 0xa3], 0);       /* mov word [eax+0xa3], 0x0 */
        l_0x1014_a98f:
            ii(0x1014_a98f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a992, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_a995, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a99a, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_a99e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_a9a0, 2); if(jled(0x1014_a9ad, 0xb)) goto l_0x1014_a9ad; /* jle 0x1014a9ad */
            ii(0x1014_a9a2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_a9a4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_a9a7, 3); mov(al, memb_a32[ds, edx + 0x4d]);      /* mov al, [edx+0x4d] */
            ii(0x1014_a9aa, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1014_a9ad:
            ii(0x1014_a9ad, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1014_a9b0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_a9b3, 3); sub(memb_a32[ds, edx + 0x4d], al);      /* sub [edx+0x4d], al */
            ii(0x1014_a9b6, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_a9b9, 3); mov(dl, memb_a32[ds, edx + 0x4d]);      /* mov dl, [edx+0x4d] */
            ii(0x1014_a9bc, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_a9c2, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1014_a9c4, 2); if(jled(0x1014_a9fc, 0x36)) goto l_0x1014_a9fc; /* jle 0x1014a9fc */
            ii(0x1014_a9c6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_a9cb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a9ce, 5); calld(0x1015_2605, 0x7c32);             /* call 0x10152605 */
            ii(0x1014_a9d3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a9d6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_a9d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a9de, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_a9e4, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1014_a9ea, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a9ef, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1014_a9f2, 2); if(jnzd(0x1014_a9fc, 0x8)) goto l_0x1014_a9fc; /* jnz 0x1014a9fc */
            ii(0x1014_a9f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a9f7, 5); calld(0x100a_9eb9, -0xa_0b43);          /* call 0x100a9eb9 */
        l_0x1014_a9fc:
            ii(0x1014_a9fc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_a9ff, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_aa02, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_aa07, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_aa09, 6); if(jnzd(0x1014_aaa2, 0x93)) goto l_0x1014_aaa2; /* jnz 0x1014aaa2 */
            ii(0x1014_aa0f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa12, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x1014_aa16, 2); if(jzd(0x1014_aa3d, 0x25)) goto l_0x1014_aa3d; /* jz 0x1014aa3d */
            ii(0x1014_aa18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa1b, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_aa1e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_aa23, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1014_aa29, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa2c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_aa2f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_aa32, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_aa34, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_aa36, 7); inc(memw_a32[ds, eax + 0x101c_a5e9]);   /* inc word [eax+0x101ca5e9] */
        l_0x1014_aa3d:
            ii(0x1014_aa3d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_aa40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa43, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_aa46, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_aa4b, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1014_aa4e, 5); mov(ebx, 0x101c_9480);                  /* mov ebx, 0x101c9480 */
            ii(0x1014_aa53, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1014_aa55, 5); calld(0x1008_aab4, -0xb_ffa6);          /* call 0x1008aab4 */
            ii(0x1014_aa5a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_aa5d, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1014_aa62, 5); calld(0x1008_aab4, -0xb_ffb3);          /* call 0x1008aab4 */
            ii(0x1014_aa67, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa6a, 5); calld(0x1015_287d, 0x7e0e);             /* call 0x1015287d */
            ii(0x1014_aa6f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa72, 5); calld(0x1014_a86a, -0x20d);             /* call 0x1014a86a */
            ii(0x1014_aa77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa7a, 5); calld(0x100a_8e92, -0xa_1bed);          /* call 0x100a8e92 */
            ii(0x1014_aa7f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa82, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1014_aa87, 2); if(jzd(0x1014_aa93, 0xa)) goto l_0x1014_aa93; /* jz 0x1014aa93 */
            ii(0x1014_aa89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa8c, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_aa91, 2); if(jnzd(0x1014_aaa2, 0xf)) goto l_0x1014_aaa2; /* jnz 0x1014aaa2 */
        l_0x1014_aa93:
            ii(0x1014_aa93, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x1014_aa96, 3); add(dl, 0x5);                           /* add dl, 0x5 */
            ii(0x1014_aa99, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aa9c, 3); and(dl, 0x7);                           /* and dl, 0x7 */
            ii(0x1014_aa9f, 3); mov(memb_a32[ds, eax + 0x29], dl);      /* mov [eax+0x29], dl */
        l_0x1014_aaa2:
            ii(0x1014_aaa2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aaa5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_aaa7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1014_aaaa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_aaac, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_aab1, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_aab3, 2); if(jnzd(0x1014_aad5, 0x20)) goto l_0x1014_aad5; /* jnz 0x1014aad5 */
            ii(0x1014_aab5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_aab8, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1014_aabb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aabe, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1014_aac1, 2); if(jzd(0x1014_aad0, 0xd)) goto l_0x1014_aad0; /* jz 0x1014aad0 */
            ii(0x1014_aac3, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_aac8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aacb, 5); calld(0x100f_3c32, -0x5_6e9e);          /* call 0x100f3c32 */
        l_0x1014_aad0:
            ii(0x1014_aad0, 5); jmpd(0x1014_ab98, 0xc3); goto l_0x1014_ab98; /* jmp 0x1014ab98 */
        l_0x1014_aad5:
            ii(0x1014_aad5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_aad7, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_aadc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_aadf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aae2, 5); calld(0x1007_6074, -0xd_4a73);          /* call 0x10076074 */
            ii(0x1014_aae7, 2); test(al, al);                           /* test al, al */
            ii(0x1014_aae9, 2); if(jzd(0x1014_aafa, 0xf)) goto l_0x1014_aafa; /* jz 0x1014aafa */
            ii(0x1014_aaeb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aaee, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_aaf1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_aaf6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_aaf8, 2); if(jzd(0x1014_aaff, 0x5)) goto l_0x1014_aaff; /* jz 0x1014aaff */
        l_0x1014_aafa:
            ii(0x1014_aafa, 5); jmpd(0x1014_ab98, 0x99); goto l_0x1014_ab98; /* jmp 0x1014ab98 */
        l_0x1014_aaff:
            ii(0x1014_aaff, 3); lea(edi, ebp - 0x20);                   /* lea edi, [ebp-0x20] */
            ii(0x1014_ab02, 5); mov(esi, 0x101b_d8fc);                  /* mov esi, 0x101bd8fc */
            ii(0x1014_ab07, 1); movsd_a32();                            /* movsd */
            ii(0x1014_ab08, 1); movsd_a32();                            /* movsd */
            ii(0x1014_ab09, 1); movsd_a32();                            /* movsd */
            ii(0x1014_ab0a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ab0d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_ab10, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_ab13, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_ab16, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1014_ab1b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_ab1d, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1014_ab20, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1014_ab23, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1014_ab26, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_ab29, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ab2c, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1014_ab2f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ab32, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1014_ab35, 5); calld(0x1007_6aac, -0xd_408e);          /* call 0x10076aac */
            ii(0x1014_ab3a, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1014_ab3c, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1014_ab3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ab41, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ab44, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1014_ab47, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_ab4a, 1); inc(eax);                               /* inc eax */
            ii(0x1014_ab4b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_ab4c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ab4f, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_ab52, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_ab55, 1); inc(eax);                               /* inc eax */
            ii(0x1014_ab56, 1); pushd(eax);                             /* push eax */
            ii(0x1014_ab57, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_ab5a, 3); pushd(memd_a32[ds, eax + 0x17]);        /* push dword [eax+0x17] */
            ii(0x1014_ab5d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_ab60, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1014_ab63, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1014_ab66, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1014_ab69, 4); pushd(memd_a32[ds, eax + ebp - 0x20]);  /* push dword [eax+ebp-0x20] */
            ii(0x1014_ab6d, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1014_ab72, 1); pushd(eax);                             /* push eax */
            ii(0x1014_ab73, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1014_ab76, 5); calld(Definitions.my_string_ctor, -0x9093); /* call 0x10141ae8 */
            ii(0x1014_ab7b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_ab7c, 5); calld(0x1014_2037, -0x8b4a);            /* call 0x10142037 */
            ii(0x1014_ab81, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1014_ab84, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_13c1); /* call 0x100897c8 */
            ii(0x1014_ab89, 5); calld(0x1011_5b60, -0x3_502e);          /* call 0x10115b60 */
            ii(0x1014_ab8e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ab90, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1014_ab93, 5); calld(Definitions.my_string_dtor, -0x906e); /* call 0x10141b2a */
        l_0x1014_ab98:
            ii(0x1014_ab98, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ab9b, 5); calld(0x1016_15c9, 0x1_6a29);           /* call 0x101615c9 */
            ii(0x1014_aba0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_aba3, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_aba6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_abab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_abad, 2); if(jzd(0x1014_abc3, 0x14)) goto l_0x1014_abc3; /* jz 0x1014abc3 */
            ii(0x1014_abaf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_abb2, 4); cmp(memb_a32[ds, eax + 0x3d], 0x9);     /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1014_abb6, 2); if(jzd(0x1014_abc1, 0x9)) goto l_0x1014_abc1; /* jz 0x1014abc1 */
            ii(0x1014_abb8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_abbb, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x1014_abbf, 2); if(jnzd(0x1014_abc3, 0x2)) goto l_0x1014_abc3; /* jnz 0x1014abc3 */
        l_0x1014_abc1:
            ii(0x1014_abc1, 2); jmpd(0x1014_abd2, 0xf); goto l_0x1014_abd2; /* jmp 0x1014abd2 */
        l_0x1014_abc3:
            ii(0x1014_abc3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_abc5, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1014_abca, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_abcd, 5); calld(0x1016_2f96, 0x1_83c4);           /* call 0x10162f96 */
        l_0x1014_abd2:
            ii(0x1014_abd2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_abd5, 5); calld(0x1014_f12b, 0x4551);             /* call 0x1014f12b */
            ii(0x1014_abda, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_abdd, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_abe0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_abe5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_abeb, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1014_abf1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_abf6, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1014_abf9, 2); if(jzd(0x1014_ac1c, 0x21)) goto l_0x1014_ac1c; /* jz 0x1014ac1c */
            ii(0x1014_abfb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_abfe, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_ac01, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ac06, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_ac0c, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1014_ac12, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ac17, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1014_ac1a, 2); if(jnzd(0x1014_ac1e, 0x2)) goto l_0x1014_ac1e; /* jnz 0x1014ac1e */
        l_0x1014_ac1c:
            ii(0x1014_ac1c, 2); jmpd(0x1014_ac67, 0x49); goto l_0x1014_ac67; /* jmp 0x1014ac67 */
        l_0x1014_ac1e:
            ii(0x1014_ac1e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ac21, 5); calld(0x1007_623c, -0xd_49ea);          /* call 0x1007623c */
            ii(0x1014_ac26, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1014_ac29, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ac2c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_ac2f, 5); calld(0x1007_623c, -0xd_49f8);          /* call 0x1007623c */
            ii(0x1014_ac34, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1014_ac37, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_ac3a, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x1014_ac3d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ac40, 5); calld(0x1007_623c, -0xd_4a09);          /* call 0x1007623c */
            ii(0x1014_ac45, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1014_ac48, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ac4b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1014_ac4f, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_ac52, 3); lea(edx, eax + eax * 4);                /* lea edx, [eax+eax*4] */
            ii(0x1014_ac55, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_ac57, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_ac5a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_ac5c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_ac5f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_ac62, 5); calld(0x1014_a582, -0x6e5);             /* call 0x1014a582 */
        l_0x1014_ac67:
            ii(0x1014_ac67, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_ac6c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ac6f, 5); calld(0x1007_6d98, -0xd_3edc);          /* call 0x10076d98 */
            ii(0x1014_ac74, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ac76, 2); if(jzd(0x1014_ac87, 0xf)) goto l_0x1014_ac87; /* jz 0x1014ac87 */
            ii(0x1014_ac78, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ac7b, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_ac7e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ac83, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_ac85, 2); if(jgd(0x1014_ac89, 0x2)) goto l_0x1014_ac89; /* jg 0x1014ac89 */
        l_0x1014_ac87:
            ii(0x1014_ac87, 2); jmpd(0x1014_ac91, 0x8); goto l_0x1014_ac91; /* jmp 0x1014ac91 */
        l_0x1014_ac89:
            ii(0x1014_ac89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ac8c, 5); calld(0x1010_094d, -0x4_a344);          /* call 0x1010094d */
        l_0x1014_ac91:
            ii(0x1014_ac91, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_ac93, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_ac94, 1); popd(edi);                              /* pop edi */
            ii(0x1014_ac95, 1); popd(esi);                              /* pop esi */
            ii(0x1014_ac96, 1); retd(); return;                         /* ret */
        }
    }
}
