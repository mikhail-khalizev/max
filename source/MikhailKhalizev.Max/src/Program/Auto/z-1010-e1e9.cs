using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d07f1f3-c3d8-4003-94a6-004190356aa5")]
        public void Method_1010_e1e9()
        {
            ii(0x1010_e1e9, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1010_e1ee, 5); calld(Definitions.sys_check_available_stack_size, 0x57b5f); /* call 0x10165d52 */
            ii(0x1010_e1f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_e1f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_e1f5, 1); pushd(edx);                             /* push edx */
            ii(0x1010_e1f6, 1); pushd(esi);                             /* push esi */
            ii(0x1010_e1f7, 1); pushd(edi);                             /* push edi */
            ii(0x1010_e1f8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_e1f9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e1fb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1010_e201, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_e204, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e206, 5); calld(0x100e_883d, -0x259ce);           /* call 0x100e883d */
            ii(0x1010_e20b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_e20d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e210, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1010_e212, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e215, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1010_e21c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e21f, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x1010_e226, 5); calld(/* sys */ 0x1016_be34, 0x5dc09);  /* call 0x1016be34 */
            ii(0x1010_e22b, 5); calld(0x100d_533c, -0x38ef4);           /* call 0x100d533c */
            ii(0x1010_e230, 1); cwde();                                 /* cwde */
            ii(0x1010_e231, 1); pushd(eax);                             /* push eax */
            ii(0x1010_e232, 5); calld(0x100d_5360, -0x38ed7);           /* call 0x100d5360 */
            ii(0x1010_e237, 1); cwde();                                 /* cwde */
            ii(0x1010_e238, 1); pushd(eax);                             /* push eax */
            ii(0x1010_e239, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e23b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_e23c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_e23e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e241, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_e243, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1010_e246, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_e249, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e24c, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_e24e, 5); mov(eax, 0x6ee);                        /* mov eax, 0x6ee */
            ii(0x1010_e253, 5); calld(0x100e_8c51, -0x25607);           /* call 0x100e8c51 */
            ii(0x1010_e258, 7); mov(memd_a32[ss, ebp - 0xc], 0x13);     /* mov dword [ebp-0xc], 0x13 */
        l_0x1010_e25f:
            ii(0x1010_e25f, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_e262, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_e267, 2); if(jzd(0x1010_e2a0, 0x37)) goto l_0x1010_e2a0; /* jz 0x1010e2a0 */
            ii(0x1010_e269, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_e26d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_e270, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_e273, 7); mov(memd_a32[ds, eax + 0x14], 0);       /* mov dword [eax+0x14], 0x0 */
            ii(0x1010_e27a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_e27e, 3); cmp(eax, 0xc);                          /* cmp eax, 0xc */
            ii(0x1010_e281, 2); if(jged(0x1010_e289, 0x6)) goto l_0x1010_e289; /* jge 0x1010e289 */
            ii(0x1010_e283, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_e287, 2); jmpd(0x1010_e28d, 0x4); goto l_0x1010_e28d; /* jmp 0x1010e28d */
        l_0x1010_e289:
            ii(0x1010_e289, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1010_e28d:
            ii(0x1010_e28d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_e28f, 3); mov(bl, memb_a32[ss, ebp - 0x10]);      /* mov bl, [ebp-0x10] */
            ii(0x1010_e292, 4); movsx(edx, memb_a32[ss, ebp - 0xc]);    /* movsx edx, byte [ebp-0xc] */
            ii(0x1010_e296, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e299, 5); calld(0x1010_daa7, -0x7f7);             /* call 0x1010daa7 */
            ii(0x1010_e29e, 2); jmpd(0x1010_e25f, -0x41); goto l_0x1010_e25f; /* jmp 0x1010e25f */
        l_0x1010_e2a0:
            ii(0x1010_e2a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e2a3, 5); calld(0x1010_de32, -0x476);             /* call 0x1010de32 */
            ii(0x1010_e2a8, 4); mov(memb_a32[ss, ebp - 0x8], 0x4);      /* mov byte [ebp-0x8], 0x4 */
            ii(0x1010_e2ac, 6); mov(memw_a32[ss, ebp - 0xc], 0);        /* mov word [ebp-0xc], 0x0 */
            ii(0x1010_e2b2, 2); jmpd(0x1010_e2bb, 0x7); goto l_0x1010_e2bb; /* jmp 0x1010e2bb */
        l_0x1010_e2b4:
            ii(0x1010_e2b4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_e2b7, 4); inc(memw_a32[ss, ebp - 0xc]);           /* inc word [ebp-0xc] */
        l_0x1010_e2bb:
            ii(0x1010_e2bb, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_e2bf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e2c1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1010_e2c4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_e2c6, 2); if(jged(0x1010_e32f, 0x67)) goto l_0x1010_e32f; /* jge 0x1010e32f */
            ii(0x1010_e2c8, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1010_e2cc, 2); jmpd(0x1010_e2d4, 0x6); goto l_0x1010_e2d4; /* jmp 0x1010e2d4 */
        l_0x1010_e2ce:
            ii(0x1010_e2ce, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_e2d1, 3); inc(memb_a32[ss, ebp - 0x14]);          /* inc byte [ebp-0x14] */
        l_0x1010_e2d4:
            ii(0x1010_e2d4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e2d6, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_e2d9, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1010_e2dc, 2); if(jged(0x1010_e30f, 0x31)) goto l_0x1010_e30f; /* jge 0x1010e30f */
            ii(0x1010_e2de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e2e0, 3); mov(dl, memb_a32[ss, ebp - 0x14]);      /* mov dl, [ebp-0x14] */
            ii(0x1010_e2e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e2e5, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1010_e2e8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_e2eb, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_e2ef, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_e2f1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_e2f4, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_e2f7, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_e2fa, 5); calld(0x100d_5104, -0x391fb);           /* call 0x100d5104 */
            ii(0x1010_e2ff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_e301, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e303, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_e306, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_e309, 4); mov(memd_a32[ds, eax + ebp - 0x20], edx); /* mov [eax+ebp-0x20], edx */
            ii(0x1010_e30d, 2); jmpd(0x1010_e2ce, -0x41); goto l_0x1010_e2ce; /* jmp 0x1010e2ce */
        l_0x1010_e30f:
            ii(0x1010_e30f, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1010_e312, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1010_e317, 5); calld(/* sys */ 0x1016_9a78, 0x5b75c);  /* call 0x10169a78 */
            ii(0x1010_e31c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1010_e321, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_e325, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e328, 5); calld(0x1010_dfd1, -0x35c);             /* call 0x1010dfd1 */
            ii(0x1010_e32d, 2); jmpd(0x1010_e2b4, -0x7b); goto l_0x1010_e2b4; /* jmp 0x1010e2b4 */
        l_0x1010_e32f:
            ii(0x1010_e32f, 5); calld(/* sys */ 0x1016_bcc4, 0x5d990);  /* call 0x1016bcc4 */
            ii(0x1010_e334, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e336, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_e337, 1); popd(edi);                              /* pop edi */
            ii(0x1010_e338, 1); popd(esi);                              /* pop esi */
            ii(0x1010_e339, 1); popd(edx);                              /* pop edx */
            ii(0x1010_e33a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_e33b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_e33c, 1); retd(); return;                         /* ret */
        }
    }
}