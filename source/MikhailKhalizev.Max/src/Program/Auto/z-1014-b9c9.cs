using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("87f8c6ee-519a-4593-9a80-6307854e5d53")]
        public void Method_1014_b9c9()
        {
            ii(0x1014_b9c9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_b9ce, 5); calld(Definitions.sys_check_available_stack_size, 0x1_a37f); /* call 0x10165d52 */
            ii(0x1014_b9d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_b9d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_b9d5, 1); pushd(esi);                             /* push esi */
            ii(0x1014_b9d6, 1); pushd(edi);                             /* push edi */
            ii(0x1014_b9d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_b9d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_b9da, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_b9e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_b9e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_b9e6, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_b9ed, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_b9f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b9f3, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_b9f6, 5); calld(0x1007_6e00, -0xd_4bfb);          /* call 0x10076e00 */
            ii(0x1014_b9fb, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b9fd, 6); if(jnzd(0x1014_bb90, 0x18d)) goto l_0x1014_bb90; /* jnz 0x1014bb90 */
            ii(0x1014_ba03, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ba06, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ba09, 5); calld(0x1016_4259, 0x1_884b);           /* call 0x10164259 */
            ii(0x1014_ba0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ba10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba13, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ba16, 5); calld(0x1013_ad71, -0x1_0caa);          /* call 0x1013ad71 */
            ii(0x1014_ba1b, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ba1d, 2); if(jzd(0x1014_ba32, 0x13)) goto l_0x1014_ba32; /* jz 0x1014ba32 */
            ii(0x1014_ba1f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ba22, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba25, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ba28, 5); calld(0x1007_6884, -0xd_51a9);          /* call 0x10076884 */
            ii(0x1014_ba2d, 5); calld(0x1016_4285, 0x1_8853);           /* call 0x10164285 */
        l_0x1014_ba32:
            ii(0x1014_ba32, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_ba35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba38, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ba3b, 5); calld(0x100a_b2a8, -0xa_0798);          /* call 0x100ab2a8 */
            ii(0x1014_ba40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba43, 4); test(memb_a32[ds, eax + 0x69], 0x1);    /* test byte [eax+0x69], 0x1 */
            ii(0x1014_ba47, 2); if(jzd(0x1014_ba6a, 0x21)) goto l_0x1014_ba6a; /* jz 0x1014ba6a */
            ii(0x1014_ba49, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_ba4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba51, 5); calld(0x1014_b7be, -0x298);             /* call 0x1014b7be */
            ii(0x1014_ba56, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_ba59, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_ba5d, 2); if(jzd(0x1014_ba6a, 0xb)) goto l_0x1014_ba6a; /* jz 0x1014ba6a */
            ii(0x1014_ba5f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_ba62, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_ba65, 5); calld(0x1014_b9c9, -0xa1);              /* call 0x1014b9c9 */
        l_0x1014_ba6a:
            ii(0x1014_ba6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba6d, 4); test(memb_a32[ds, eax + 0x69], 0x2);    /* test byte [eax+0x69], 0x2 */
            ii(0x1014_ba71, 2); if(jzd(0x1014_ba94, 0x21)) goto l_0x1014_ba94; /* jz 0x1014ba94 */
            ii(0x1014_ba73, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1014_ba78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba7b, 5); calld(0x1014_b7be, -0x2c2);             /* call 0x1014b7be */
            ii(0x1014_ba80, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_ba83, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_ba87, 2); if(jzd(0x1014_ba94, 0xb)) goto l_0x1014_ba94; /* jz 0x1014ba94 */
            ii(0x1014_ba89, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_ba8c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_ba8f, 5); calld(0x1014_b9c9, -0xcb);              /* call 0x1014b9c9 */
        l_0x1014_ba94:
            ii(0x1014_ba94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ba97, 4); test(memb_a32[ds, eax + 0x69], 0x4);    /* test byte [eax+0x69], 0x4 */
            ii(0x1014_ba9b, 2); if(jzd(0x1014_babe, 0x21)) goto l_0x1014_babe; /* jz 0x1014babe */
            ii(0x1014_ba9d, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1014_baa2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_baa5, 5); calld(0x1014_b7be, -0x2ec);             /* call 0x1014b7be */
            ii(0x1014_baaa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_baad, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bab1, 2); if(jzd(0x1014_babe, 0xb)) goto l_0x1014_babe; /* jz 0x1014babe */
            ii(0x1014_bab3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bab6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bab9, 5); calld(0x1014_b9c9, -0xf5);              /* call 0x1014b9c9 */
        l_0x1014_babe:
            ii(0x1014_babe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bac1, 4); test(memb_a32[ds, eax + 0x69], 0x8);    /* test byte [eax+0x69], 0x8 */
            ii(0x1014_bac5, 2); if(jzd(0x1014_bae8, 0x21)) goto l_0x1014_bae8; /* jz 0x1014bae8 */
            ii(0x1014_bac7, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1014_bacc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bacf, 5); calld(0x1014_b7be, -0x316);             /* call 0x1014b7be */
            ii(0x1014_bad4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_bad7, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_badb, 2); if(jzd(0x1014_bae8, 0xb)) goto l_0x1014_bae8; /* jz 0x1014bae8 */
            ii(0x1014_badd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bae0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bae3, 5); calld(0x1014_b9c9, -0x11f);             /* call 0x1014b9c9 */
        l_0x1014_bae8:
            ii(0x1014_bae8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_baeb, 4); test(memb_a32[ds, eax + 0x69], 0x20);   /* test byte [eax+0x69], 0x20 */
            ii(0x1014_baef, 2); if(jzd(0x1014_bb12, 0x21)) goto l_0x1014_bb12; /* jz 0x1014bb12 */
            ii(0x1014_baf1, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_baf6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_baf9, 5); calld(0x1014_b7be, -0x340);             /* call 0x1014b7be */
            ii(0x1014_bafe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_bb01, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bb05, 2); if(jzd(0x1014_bb12, 0xb)) goto l_0x1014_bb12; /* jz 0x1014bb12 */
            ii(0x1014_bb07, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bb0a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bb0d, 5); calld(0x1014_b9c9, -0x149);             /* call 0x1014b9c9 */
        l_0x1014_bb12:
            ii(0x1014_bb12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb15, 4); test(memb_a32[ds, eax + 0x69], 0x10);   /* test byte [eax+0x69], 0x10 */
            ii(0x1014_bb19, 2); if(jzd(0x1014_bb3c, 0x21)) goto l_0x1014_bb3c; /* jz 0x1014bb3c */
            ii(0x1014_bb1b, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_bb20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb23, 5); calld(0x1014_b7be, -0x36a);             /* call 0x1014b7be */
            ii(0x1014_bb28, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_bb2b, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bb2f, 2); if(jzd(0x1014_bb3c, 0xb)) goto l_0x1014_bb3c; /* jz 0x1014bb3c */
            ii(0x1014_bb31, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bb34, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bb37, 5); calld(0x1014_b9c9, -0x173);             /* call 0x1014b9c9 */
        l_0x1014_bb3c:
            ii(0x1014_bb3c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb3f, 4); test(memb_a32[ds, eax + 0x69], 0x80);   /* test byte [eax+0x69], 0x80 */
            ii(0x1014_bb43, 2); if(jzd(0x1014_bb66, 0x21)) goto l_0x1014_bb66; /* jz 0x1014bb66 */
            ii(0x1014_bb45, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_bb4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb4d, 5); calld(0x1014_b7be, -0x394);             /* call 0x1014b7be */
            ii(0x1014_bb52, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_bb55, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bb59, 2); if(jzd(0x1014_bb66, 0xb)) goto l_0x1014_bb66; /* jz 0x1014bb66 */
            ii(0x1014_bb5b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bb5e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bb61, 5); calld(0x1014_b9c9, -0x19d);             /* call 0x1014b9c9 */
        l_0x1014_bb66:
            ii(0x1014_bb66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb69, 4); test(memb_a32[ds, eax + 0x69], 0x40);   /* test byte [eax+0x69], 0x40 */
            ii(0x1014_bb6d, 2); if(jzd(0x1014_bb90, 0x21)) goto l_0x1014_bb90; /* jz 0x1014bb90 */
            ii(0x1014_bb6f, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_bb74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bb77, 5); calld(0x1014_b7be, -0x3be);             /* call 0x1014b7be */
            ii(0x1014_bb7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_bb7f, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bb83, 2); if(jzd(0x1014_bb90, 0xb)) goto l_0x1014_bb90; /* jz 0x1014bb90 */
            ii(0x1014_bb85, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_bb88, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_bb8b, 5); calld(0x1014_b9c9, -0x1c7);             /* call 0x1014b9c9 */
        l_0x1014_bb90:
            ii(0x1014_bb90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_bb92, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_bb93, 1); popd(edi);                              /* pop edi */
            ii(0x1014_bb94, 1); popd(esi);                              /* pop esi */
            ii(0x1014_bb95, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_bb96, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_bb97, 1); retd(); return;                         /* ret */
        }
    }
}
