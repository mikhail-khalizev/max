using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("713770d3-2f2e-4dce-87e5-98529ed40eaf")]
        public void Method_1011_390d()
        {
            ii(0x1011_390d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_3912, 5); calld(Definitions.sys_check_available_stack_size, 0x5_243b); /* call 0x10165d52 */
            ii(0x1011_3917, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_3918, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_3919, 1); pushd(edx);                             /* push edx */
            ii(0x1011_391a, 1); pushd(esi);                             /* push esi */
            ii(0x1011_391b, 1); pushd(edi);                             /* push edi */
            ii(0x1011_391c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_391d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_391f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_3925, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_3928, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_392d, 5); calld(/* sys */ 0x1016_a24c, 0x5_691a); /* call 0x1016a24c */
            ii(0x1011_3932, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3935, 5); calld(0x1011_2b4c, -0xdee);             /* call 0x10112b4c */
            ii(0x1011_393a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_393d, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_3941, 2); if(jzd(0x1011_3955, 0x12)) goto l_0x1011_3955; /* jz 0x10113955 */
            ii(0x1011_3943, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3946, 5); calld(0x1011_2cdd, -0xc6e);             /* call 0x10112cdd */
            ii(0x1011_394b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_394e, 5); calld(0x1011_3211, -0x742);             /* call 0x10113211 */
            ii(0x1011_3953, 2); jmpd(0x1011_3981, 0x2c); goto l_0x1011_3981; /* jmp 0x10113981 */
        l_0x1011_3955:
            ii(0x1011_3955, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3958, 5); cmp(memw_a32[ds, eax + 0xc], 0);        /* cmp word [eax+0xc], 0x0 */
            ii(0x1011_395d, 2); if(jzd(0x1011_3971, 0x12)) goto l_0x1011_3971; /* jz 0x10113971 */
            ii(0x1011_395f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3962, 5); calld(0x1011_2cdd, -0xc8a);             /* call 0x10112cdd */
            ii(0x1011_3967, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_396a, 5); calld(0x1011_3211, -0x75e);             /* call 0x10113211 */
            ii(0x1011_396f, 2); jmpd(0x1011_3981, 0x10); goto l_0x1011_3981; /* jmp 0x10113981 */
        l_0x1011_3971:
            ii(0x1011_3971, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3974, 5); calld(0x1011_37f9, -0x180);             /* call 0x101137f9 */
            ii(0x1011_3979, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_397c, 5); calld(0x1011_3525, -0x45c);             /* call 0x10113525 */
        l_0x1011_3981:
            ii(0x1011_3981, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3984, 5); cmp(memw_a32[ds, eax + 0xc], 0);        /* cmp word [eax+0xc], 0x0 */
            ii(0x1011_3989, 2); if(jzd(0x1011_39a9, 0x1e)) goto l_0x1011_39a9; /* jz 0x101139a9 */
            ii(0x1011_398b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_398e, 6); mov(edx, memd_a32[ds, eax + 0x5d3]);    /* mov edx, [eax+0x5d3] */
            ii(0x1011_3994, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_3997, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_399a, 6); mov(al, memb_a32[ds, eax + 0x50e]);     /* mov al, [eax+0x50e] */
            ii(0x1011_39a0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_39a5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_39a7, 2); if(jnzd(0x1011_39ab, 0x2)) goto l_0x1011_39ab; /* jnz 0x101139ab */
        l_0x1011_39a9:
            ii(0x1011_39a9, 2); jmpd(0x1011_3a04, 0x59); goto l_0x1011_3a04; /* jmp 0x10113a04 */
        l_0x1011_39ab:
            ii(0x1011_39ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_39b0, 6); mov(dl, memb_a32[ds, eax + 0x50e]);     /* mov dl, [eax+0x50e] */
            ii(0x1011_39b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39b9, 7); mov(memw_a32[ds, eax + 0x5d5], dx);     /* mov [eax+0x5d5], dx */
            ii(0x1011_39c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39c3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_39c5, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1011_39c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_39cb, 7); imul(edx, memd_a32[ds, 0x101b_9e94]);   /* imul edx, [0x101b9e94] */
            ii(0x1011_39d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39d5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_39d7, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_39da, 6); add(eax, memd_a32[ds, 0x101b_9e90]);    /* add eax, [0x101b9e90] */
            ii(0x1011_39e0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_39e2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_39e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39e8, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_39ea, 3); mov(ebx, memd_a32[ds, ebx + 0xe]);      /* mov ebx, [ebx+0xe] */
            ii(0x1011_39ed, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_39f0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_39f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_39f6, 6); mov(eax, memd_a32[ds, eax + 0x5d3]);    /* mov eax, [eax+0x5d3] */
            ii(0x1011_39fc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_39ff, 5); calld(0x1010_c7dd, -0x7227);            /* call 0x1010c7dd */
        l_0x1011_3a04:
            ii(0x1011_3a04, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3a07, 5); calld(0x1011_3761, -0x2ab);             /* call 0x10113761 */
            ii(0x1011_3a0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3a0f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_3a11, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_3a14, 5); calld(Definitions.sys_display_draw_0, 0x5_3a6b); /* call 0x10167484 */
            ii(0x1011_3a19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3a1c, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_3a20, 2); if(jnzd(0x1011_3a30, 0xe)) goto l_0x1011_3a30; /* jnz 0x10113a30 */
            ii(0x1011_3a22, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3a25, 5); cmp(memw_a32[ds, eax + 0xc], 0);        /* cmp word [eax+0xc], 0x0 */
            ii(0x1011_3a2a, 6); if(jzd(0x1011_3ac1, 0x91)) goto l_0x1011_3ac1; /* jz 0x10113ac1 */
        l_0x1011_3a30:
            ii(0x1011_3a30, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_3a37, 2); jmpd(0x1011_3a3f, 0x6); goto l_0x1011_3a3f; /* jmp 0x10113a3f */
        l_0x1011_3a39:
            ii(0x1011_3a39, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_3a3c, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1011_3a3f:
            ii(0x1011_3a3f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_3a43, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_3a46, 2); if(jged(0x1011_3ac1, 0x79)) goto l_0x1011_3ac1; /* jge 0x10113ac1 */
            ii(0x1011_3a48, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3a4b, 2); add(al, 0xd);                           /* add al, 0xd */
            ii(0x1011_3a4d, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1011_3a50, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_3a54, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3a56, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3a59, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3a5f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3a62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3a64, 2); if(jzd(0x1011_3abc, 0x56)) goto l_0x1011_3abc; /* jz 0x10113abc */
            ii(0x1011_3a66, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_3a6b, 4); movsx(eax, memb_a32[ss, ebp - 0x10]);   /* movsx eax, byte [ebp-0x10] */
            ii(0x1011_3a6f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3a72, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3a75, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3a78, 5); calld(0x100c_fb73, -0x4_3f0a);          /* call 0x100cfb73 */
            ii(0x1011_3a7d, 5); calld(0x100d_51e4, -0x3_e89e);          /* call 0x100d51e4 */
            ii(0x1011_3a82, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_3a84, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_3a86, 5); calld(0x100d_5204, -0x3_e887);          /* call 0x100d5204 */
            ii(0x1011_3a8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_3a8d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_3a8f, 4); movsx(eax, memb_a32[ss, ebp - 0x10]);   /* movsx eax, byte [ebp-0x10] */
            ii(0x1011_3a93, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3a96, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3a99, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3a9c, 5); calld(0x100c_fa7c, -0x4_4025);          /* call 0x100cfa7c */
            ii(0x1011_3aa1, 5); calld(0x100d_51c4, -0x3_e8e2);          /* call 0x100d51c4 */
            ii(0x1011_3aa6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_3aa8, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_3aaa, 4); movsx(eax, memb_a32[ss, ebp - 0x10]);   /* movsx eax, byte [ebp-0x10] */
            ii(0x1011_3aae, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3ab1, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3ab4, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3ab7, 5); calld(0x100c_fb06, -0x4_3fb6);          /* call 0x100cfb06 */
        l_0x1011_3abc:
            ii(0x1011_3abc, 5); jmpd(0x1011_3a39, -0x88); goto l_0x1011_3a39; /* jmp 0x10113a39 */
        l_0x1011_3ac1:
            ii(0x1011_3ac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3ac3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_3ac4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3ac5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3ac6, 1); popd(edx);                              /* pop edx */
            ii(0x1011_3ac7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3ac8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3ac9, 1); retd(); return;                         /* ret */
        }
    }
}
