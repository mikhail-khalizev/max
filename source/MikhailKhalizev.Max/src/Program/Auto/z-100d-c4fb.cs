using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c0d5cc1-cab2-4bf3-99d7-043e39154abc")]
        public void Method_100d_c4fb()
        {
            ii(0x100d_c4fb, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x100d_c500, 5); calld(Definitions.sys_check_available_stack_size, 0x8984d); /* call 0x10165d52 */
            ii(0x100d_c505, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_c506, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_c507, 1); pushd(edx);                             /* push edx */
            ii(0x100d_c508, 1); pushd(esi);                             /* push esi */
            ii(0x100d_c509, 1); pushd(edi);                             /* push edi */
            ii(0x100d_c50a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_c50b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_c50d, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100d_c513, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_c516, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c51a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100d_c51d, 9); mov(memw_a32[ds, eax + 0x101c_35c4], 0); /* mov word [eax+0x101c35c4], 0x0 */
            ii(0x100d_c526, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c52a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_c530, 9); mov(memw_a32[ds, eax + 0x101c_a583], 0); /* mov word [eax+0x101ca583], 0x0 */
            ii(0x100d_c539, 5); calld(0x1009_cb74, -0x3f9ca);           /* call 0x1009cb74 */
            ii(0x100d_c53e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_c540, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_c542, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_c546, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100d_c549, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100d_c54e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_c550, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c553, 5); calld(0x1009_cab0, -0x3faa8);           /* call 0x1009cab0 */
            ii(0x100d_c558, 5); calld(0x100e_0a00, 0x44a3);             /* call 0x100e0a00 */
            ii(0x100d_c55d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_c55f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_c561, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_c565, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100d_c568, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100d_c56d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_c56f, 3); lea(edx, eax + 0x4);                    /* lea edx, [eax+0x4] */
            ii(0x100d_c572, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c575, 5); calld(0x100e_0970, 0x43f6);             /* call 0x100e0970 */
            ii(0x100d_c57a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c57d, 5); calld(0x1009_caf8, -0x3fa8a);           /* call 0x1009caf8 */
            ii(0x100d_c582, 7); mov(memd_a32[ss, ebp - 0xc], 0x31);     /* mov dword [ebp-0xc], 0x31 */
            ii(0x100d_c589, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100d_c58c, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c58f, 5); calld(0x1008_b2a8, -0x512ec);           /* call 0x1008b2a8 */
            ii(0x100d_c594, 7); mov(memd_a32[ss, ebp - 0x20], 0x3d);    /* mov dword [ebp-0x20], 0x3d */
            ii(0x100d_c59b, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_c59e, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c5a1, 5); calld(0x1008_b2a8, -0x512fe);           /* call 0x1008b2a8 */
            ii(0x100d_c5a6, 7); mov(memd_a32[ss, ebp - 0x24], 0x39);    /* mov dword [ebp-0x24], 0x39 */
            ii(0x100d_c5ad, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100d_c5b0, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c5b3, 5); calld(0x1008_b2a8, -0x51310);           /* call 0x1008b2a8 */
            ii(0x100d_c5b8, 5); calld(0x1009_cb74, -0x3fa49);           /* call 0x1009cb74 */
            ii(0x100d_c5bd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_c5bf, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_c5c1, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100d_c5c4, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100d_c5c7, 5); calld(0x1009_cab0, -0x3fb1c);           /* call 0x1009cab0 */
            ii(0x100d_c5cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_c5ce, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c5d2, 5); calld(0x100d_c405, -0x1d2);             /* call 0x100dc405 */
            ii(0x100d_c5d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_c5d9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100d_c5dc, 5); calld(0x1008_8b04, -0x53add);           /* call 0x10088b04 */
            ii(0x100d_c5e1, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c5e4, 5); calld(Definitions.my_2_get_count, -0x51281); /* call 0x1008b368 */
            ii(0x100d_c5e9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_c5ec, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c5ef, 5); calld(0x100c_aac8, -0x11b2c);           /* call 0x100caac8 */
            ii(0x100d_c5f4, 7); mov(memd_a32[ss, ebp - 0x8], 0x28);     /* mov dword [ebp-0x8], 0x28 */
            ii(0x100d_c5fb, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x100d_c5fe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c601, 5); calld(0x100c_aa44, -0x11bc2);           /* call 0x100caa44 */
            ii(0x100d_c606, 7); mov(memd_a32[ss, ebp - 0x1c], 0x14);    /* mov dword [ebp-0x1c], 0x14 */
            ii(0x100d_c60d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100d_c610, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c613, 5); calld(0x100c_aa44, -0x11bd4);           /* call 0x100caa44 */
            ii(0x100d_c618, 7); mov(memd_a32[ss, ebp - 0x18], 0x2);     /* mov dword [ebp-0x18], 0x2 */
            ii(0x100d_c61f, 2); jmpd(0x100d_c627, 0x6); goto l_0x100d_c627; /* jmp 0x100dc627 */
        l_0x100d_c621:
            ii(0x100d_c621, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_c624, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100d_c627:
            ii(0x100d_c627, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_c62a, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100d_c62e, 2); if(jged(0x100d_c644, 0x14)) goto l_0x100d_c644; /* jge 0x100dc644 */
            ii(0x100d_c630, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100d_c637, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100d_c63a, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c63d, 5); calld(0x100c_aa44, -0x11bfe);           /* call 0x100caa44 */
            ii(0x100d_c642, 2); jmpd(0x100d_c621, -0x23); goto l_0x100d_c621; /* jmp 0x100dc621 */
        l_0x100d_c644:
            ii(0x100d_c644, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c647, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_c64a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_c64c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_c64f, 5); calld(0x100e_0244, 0x3bf0);             /* call 0x100e0244 */
            ii(0x100d_c654, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_c656, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_c659, 5); calld(0x1008_8b04, -0x53b5a);           /* call 0x10088b04 */
            ii(0x100d_c65e, 2); jmpd(0x100d_c674, 0x14); goto l_0x100d_c674; /* jmp 0x100dc674 */
        //  ii(0x100d_c660, 20); Недостижимый код.
l_0x100d_c674:
            ii(0x100d_c674, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_c677, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_c679, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_c67a, 1); popd(edi);                              /* pop edi */
            ii(0x100d_c67b, 1); popd(esi);                              /* pop esi */
            ii(0x100d_c67c, 1); popd(edx);                              /* pop edx */
            ii(0x100d_c67d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_c67e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_c67f, 1); retd(); return;                         /* ret */
        }
    }
}
