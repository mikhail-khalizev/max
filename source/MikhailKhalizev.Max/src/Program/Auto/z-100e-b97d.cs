using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b97d-a6c6f37a")]
        public void Method_100e_b97d()
        {
            ii(0x100e_b97d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b982, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a3cb); /* call 0x10165d52 */
            ii(0x100e_b987, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b988, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b989, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b98a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b98b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b98c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b98e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_b994, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b997, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b99a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b99d, 4); cmp(memb_a32[ds, eax + 0x32], 0);       /* cmp byte [eax+0x32], 0x0 */
            ii(0x100e_b9a1, 2); if(jzd(0x100e_b9ab, 0x8)) goto l_0x100e_b9ab; /* jz 0x100eb9ab */
            ii(0x100e_b9a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b9a6, 5); calld(0x100e_b58f, -0x41c);             /* call 0x100eb58f */
        l_0x100e_b9ab:
            ii(0x100e_b9ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b9ae, 4); mov(memb_a32[ds, eax + 0x32], 0);       /* mov byte [eax+0x32], 0x0 */
            ii(0x100e_b9b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b9b5, 4); cmp(memb_a32[ds, eax + 0x35], 0x1);     /* cmp byte [eax+0x35], 0x1 */
            ii(0x100e_b9b9, 2); if(jnzd(0x100e_b9ce, 0x13)) goto l_0x100e_b9ce; /* jnz 0x100eb9ce */
            ii(0x100e_b9bb, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_b9be, 2); inc(al);                                /* inc al */
            ii(0x100e_b9c0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_b9c5, 7); test(memb_a32[ds, eax + 0x101b_75c0], 0x20); /* test byte [eax+0x101b75c0], 0x20 */
            ii(0x100e_b9cc, 2); if(jzd(0x100e_b9d0, 0x2)) goto l_0x100e_b9d0; /* jz 0x100eb9d0 */
        l_0x100e_b9ce:
            ii(0x100e_b9ce, 2); jmpd(0x100e_b9d5, 0x5); goto l_0x100e_b9d5; /* jmp 0x100eb9d5 */
        l_0x100e_b9d0:
            ii(0x100e_b9d0, 5); jmpd(0x100e_bae7, 0x112); goto l_0x100e_bae7; /* jmp 0x100ebae7 */
        l_0x100e_b9d5:
            ii(0x100e_b9d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b9d8, 4); cmp(memb_a32[ds, eax + 0x35], 0x2);     /* cmp byte [eax+0x35], 0x2 */
            ii(0x100e_b9dc, 2); if(jnzd(0x100e_b9f1, 0x13)) goto l_0x100e_b9f1; /* jnz 0x100eb9f1 */
            ii(0x100e_b9de, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_b9e1, 2); inc(al);                                /* inc al */
            ii(0x100e_b9e3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_b9e8, 7); test(memb_a32[ds, eax + 0x101b_75c0], 0x10); /* test byte [eax+0x101b75c0], 0x10 */
            ii(0x100e_b9ef, 2); if(jzd(0x100e_b9f3, 0x2)) goto l_0x100e_b9f3; /* jz 0x100eb9f3 */
        l_0x100e_b9f1:
            ii(0x100e_b9f1, 2); jmpd(0x100e_b9f8, 0x5); goto l_0x100e_b9f8; /* jmp 0x100eb9f8 */
        l_0x100e_b9f3:
            ii(0x100e_b9f3, 5); jmpd(0x100e_bae7, 0xef); goto l_0x100e_bae7; /* jmp 0x100ebae7 */
        l_0x100e_b9f8:
            ii(0x100e_b9f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b9fb, 3); mov(edx, memd_a32[ds, eax + 0x2c]);     /* mov edx, [eax+0x2c] */
            ii(0x100e_b9fe, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ba01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba04, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_ba07, 5); calld(Definitions.sys_strlen, 0x8_64bb); /* call 0x10171ec7 */
            ii(0x100e_ba0c, 1); dec(edx);                               /* dec edx */
            ii(0x100e_ba0d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_ba0f, 6); if(jaed(0x100e_bae7, 0xd2)) goto l_0x100e_bae7; /* jae 0x100ebae7 */
            ii(0x100e_ba15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba18, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_ba1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba1f, 5); calld(0x100e_b6bf, -0x365);             /* call 0x100eb6bf */
            ii(0x100e_ba24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba27, 3); mov(ebx, memd_a32[ds, eax + 0x2a]);     /* mov ebx, [eax+0x2a] */
            ii(0x100e_ba2a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_ba2d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba30, 3); mov(edx, memd_a32[ds, eax + 0x23]);     /* mov edx, [eax+0x23] */
            ii(0x100e_ba33, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba36, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_ba39, 5); calld(Definitions.sys_strncpy, 0x8_64a2); /* call 0x10171ee0 */
            ii(0x100e_ba3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba41, 3); mov(edx, memd_a32[ds, eax + 0x2a]);     /* mov edx, [eax+0x2a] */
            ii(0x100e_ba44, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ba47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba4a, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_ba4d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_ba4f, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_ba52, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100e_ba54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba57, 3); mov(edx, memd_a32[ds, eax + 0x2a]);     /* mov edx, [eax+0x2a] */
            ii(0x100e_ba5a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ba5d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba60, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_ba63, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_ba65, 4); mov(memb_a32[ds, eax + 0x1], 0);        /* mov byte [eax+0x1], 0x0 */
            ii(0x100e_ba69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba6c, 3); mov(edx, memd_a32[ds, eax + 0x2a]);     /* mov edx, [eax+0x2a] */
            ii(0x100e_ba6f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ba72, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba75, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_ba78, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_ba7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba7d, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_ba80, 5); calld(Definitions.sys_strcat, 0x7_a4ac); /* call 0x10165f31 */
            ii(0x100e_ba85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ba88, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_ba8b, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_ba91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_ba93, 5); mov(eax, StringDefinitions.Control19);  /* mov eax, 0x101a1f00 */
            ii(0x100e_ba98, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_ba9e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_baa0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_baa3, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_baa6, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_baa9, 2); sub(eax, memd_a32[ds, ebx]);            /* sub eax, [ebx] */
            ii(0x100e_baab, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_baad, 2); if(jgd(0x100e_bae7, 0x38)) goto l_0x100e_bae7; /* jg 0x100ebae7 */
            ii(0x100e_baaf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_bab2, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x100e_bab5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_bab8, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_babb, 5); calld(Definitions.sys_strcpy, 0x7_a40f); /* call 0x10165ecf */
            ii(0x100e_bac0, 5); calld(0x100d_6104, -0x1_59c1);          /* call 0x100d6104 */
            ii(0x100e_bac5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bac7, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_bac9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_bacc, 5); calld(0x100e_b5e1, -0x4f0);             /* call 0x100eb5e1 */
            ii(0x100e_bad1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_bad4, 4); inc(memw_a32[ds, eax + 0x2c]);          /* inc word [eax+0x2c] */
            ii(0x100e_bad8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_badb, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_badf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_bae2, 5); calld(0x100e_b6bf, -0x428);             /* call 0x100eb6bf */
        l_0x100e_bae7:
            ii(0x100e_bae7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_bae9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_baea, 1); popd(edi);                              /* pop edi */
            ii(0x100e_baeb, 1); popd(esi);                              /* pop esi */
            ii(0x100e_baec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_baed, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_baee, 1); retd();                                 /* ret */
        }
    }
}
