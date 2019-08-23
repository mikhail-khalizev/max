using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b16c-6231daed")]
        public void Method_1012_b16c()
        {
            ii(0x1012_b16c, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1012_b171, 5); calld(Definitions.sys_check_available_stack_size, 0x3_abdc); /* call 0x10165d52 */
            ii(0x1012_b176, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b177, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b178, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b179, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b17a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b17b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b17d, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1012_b183, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_b186, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1012_b189, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1012_b18e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_b191, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b197, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_b19d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b1a2, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_b1a5, 6); if(jzd(0x1012_b226, 0x7b)) goto l_0x1012_b226; /* jz 0x1012b226 */
            ii(0x1012_b1ab, 6); mov(ax, memw_a32[ds, 0x101c_8168]);     /* mov ax, [0x101c8168] */
            ii(0x1012_b1b1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1012_b1b4:
            ii(0x1012_b1b4, 6); mov(edx, memd_a32[ds, 0x101c_8166]);    /* mov edx, [0x101c8166] */
            ii(0x1012_b1ba, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_b1bd, 1); inc(edx);                               /* inc edx */
            ii(0x1012_b1be, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1012_b1c3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_b1c5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_b1c8, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_b1ca, 7); mov(memw_a32[ds, 0x101c_8168], dx);     /* mov [0x101c8168], dx */
            ii(0x1012_b1d1, 6); mov(ax, memw_a32[ds, 0x101c_8168]);     /* mov ax, [0x101c8168] */
            ii(0x1012_b1d7, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1012_b1db, 2); if(jzd(0x1012_b1fb, 0x1e)) goto l_0x1012_b1fb; /* jz 0x1012b1fb */
            ii(0x1012_b1dd, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1012_b1e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_b1e5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b1eb, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_b1f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b1f6, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_b1f9, 2); if(jnzd(0x1012_b1fd, 0x2)) goto l_0x1012_b1fd; /* jnz 0x1012b1fd */
        l_0x1012_b1fb:
            ii(0x1012_b1fb, 2); jmpd(0x1012_b1ff, 0x2); goto l_0x1012_b1ff; /* jmp 0x1012b1ff */
        l_0x1012_b1fd:
            ii(0x1012_b1fd, 2); jmpd(0x1012_b1b4, -0x4b); goto l_0x1012_b1b4; /* jmp 0x1012b1b4 */
        l_0x1012_b1ff:
            ii(0x1012_b1ff, 6); mov(ax, memw_a32[ds, 0x101c_8168]);     /* mov ax, [0x101c8168] */
            ii(0x1012_b205, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1012_b209, 2); if(jzd(0x1012_b226, 0x1b)) goto l_0x1012_b226; /* jz 0x1012b226 */
            ii(0x1012_b20b, 6); inc(memd_a32[ds, 0x101c_816c]);         /* inc dword [0x101c816c] */
            ii(0x1012_b211, 6); mov(ebx, memd_a32[ds, 0x101c_816c]);    /* mov ebx, [0x101c816c] */
            ii(0x1012_b217, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_b219, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1012_b21e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_b221, 5); calld(0x1012_b31a, 0xf4);               /* call 0x1012b31a */
        l_0x1012_b226:
            ii(0x1012_b226, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b22a, 6); inc(memb_a32[ds, eax + 0x101c_59d8]);   /* inc byte [eax+0x101c59d8] */
            ii(0x1012_b230, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x7);    /* mov byte [0x101c5c1c], 0x7 */
            ii(0x1012_b237, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b23a, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_b240, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x2);    /* mov word [0x101c5c1f], 0x2 */
            ii(0x1012_b249, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b24d, 6); mov(al, memb_a32[ds, eax + 0x101c_59d8]); /* mov al, [eax+0x101c59d8] */
            ii(0x1012_b253, 5); mov(memb_a32[ds, 0x101c_5c21], al);     /* mov [0x101c5c21], al */
            ii(0x1012_b258, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_b25b, 5); mov(memb_a32[ds, 0x101c_5c22], al);     /* mov [0x101c5c22], al */
            ii(0x1012_b260, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_b265, 5); calld(0x1012_5be9, -0x5681);            /* call 0x10125be9 */
            ii(0x1012_b26a, 5); calld(0x1014_82f4, 0x1_d085);           /* call 0x101482f4 */
            ii(0x1012_b26f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_b272, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_b276:
            ii(0x1012_b276, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_b27a, 2); if(jzd(0x1012_b285, 0x9)) goto l_0x1012_b285; /* jz 0x1012b285 */
            ii(0x1012_b27c, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_b283, 2); if(jnzd(0x1012_b28a, 0x5)) goto l_0x1012_b28a; /* jnz 0x1012b28a */
        l_0x1012_b285:
            ii(0x1012_b285, 5); jmpd(0x1012_b301, 0x77); goto l_0x1012_b301; /* jmp 0x1012b301 */
        l_0x1012_b28a:
            ii(0x1012_b28a, 5); calld(0x1012_75ed, -0x3ca2);            /* call 0x101275ed */
            ii(0x1012_b28f, 5); calld(0x100e_a7e7, -0x4_0aad);          /* call 0x100ea7e7 */
            ii(0x1012_b294, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_b298, 7); mov(memd_a32[ss, ebp - 0x18], 0x4);     /* mov dword [ebp-0x18], 0x4 */
        l_0x1012_b29f:
            ii(0x1012_b29f, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1012_b2a2, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x1012_b2a7, 2); if(jzd(0x1012_b2ee, 0x45)) goto l_0x1012_b2ee; /* jz 0x1012b2ee */
            ii(0x1012_b2a9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_b2ad, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b2b3, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_b2b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b2be, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_b2c1, 2); if(jnzd(0x1012_b2ec, 0x29)) goto l_0x1012_b2ec; /* jnz 0x1012b2ec */
            ii(0x1012_b2c3, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1012_b2c7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b2cb, 6); mov(dl, memb_a32[ds, edx + 0x101c_59d8]); /* mov dl, [edx+0x101c59d8] */
            ii(0x1012_b2d1, 6); cmp(dl, memb_a32[ds, eax + 0x101c_59d8]); /* cmp dl, [eax+0x101c59d8] */
            ii(0x1012_b2d7, 2); if(jaed(0x1012_b2ec, 0x13)) goto l_0x1012_b2ec; /* jae 0x1012b2ec */
            ii(0x1012_b2d9, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_b2dc, 5); calld(0x1014_85ad, 0x1_d2cc);           /* call 0x101485ad */
            ii(0x1012_b2e1, 5); cmp(eax, 0x1388);                       /* cmp eax, 0x1388 */
            ii(0x1012_b2e6, 2); if(jaed(0x1012_b2ec, 0x4)) goto l_0x1012_b2ec; /* jae 0x1012b2ec */
            ii(0x1012_b2e8, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_b2ec:
            ii(0x1012_b2ec, 2); jmpd(0x1012_b29f, -0x4f); goto l_0x1012_b29f; /* jmp 0x1012b29f */
        l_0x1012_b2ee:
            ii(0x1012_b2ee, 5); calld(/* sys */ 0x1016_b208, 0x3_ff15); /* call 0x1016b208 */
            ii(0x1012_b2f3, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_b2f6, 2); if(jnzd(0x1012_b2fc, 0x4)) goto l_0x1012_b2fc; /* jnz 0x1012b2fc */
            ii(0x1012_b2f8, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1012_b2fc:
            ii(0x1012_b2fc, 5); jmpd(0x1012_b276, -0x8b); goto l_0x1012_b276; /* jmp 0x1012b276 */
        l_0x1012_b301:
            ii(0x1012_b301, 7); mov(memb_a32[ds, 0x101c_5630], 0);      /* mov byte [0x101c5630], 0x0 */
            ii(0x1012_b308, 10); mov(memd_a32[ds, 0x101c_5624], 0);     /* mov dword [0x101c5624], 0x0 */
            ii(0x1012_b312, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b314, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b315, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b316, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b317, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b318, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b319, 1); retd();                                 /* ret */
        }
    }
}
