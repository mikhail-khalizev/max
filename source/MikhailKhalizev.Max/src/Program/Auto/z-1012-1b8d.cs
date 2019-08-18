using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_1b8d-6585c20d")]
        public void Method_1012_1b8d()
        {
            ii(0x1012_1b8d, 5); pushd(0x104);                           /* push 0x104 */
            ii(0x1012_1b92, 5); calld(Definitions.sys_check_available_stack_size, 0x4_41bb); /* call 0x10165d52 */
            ii(0x1012_1b97, 1); pushd(esi);                             /* push esi */
            ii(0x1012_1b98, 1); pushd(edi);                             /* push edi */
            ii(0x1012_1b99, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_1b9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_1b9c, 6); sub(esp, 0xe0);                         /* sub esp, 0xe0 */
            ii(0x1012_1ba2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_1ba5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_1ba8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_1bab, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_1bae, 5); mov(edx, 0x101c_4e54);                  /* mov edx, 0x101c4e54 */
            ii(0x1012_1bb3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1012_1bb6, 5); calld(0x100d_4d78, -0x4_ce43);          /* call 0x100d4d78 */
            ii(0x1012_1bbb, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1bbf, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1bc2, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_1bc8, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1012_1bcb, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1012_1bce, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1012_1bd1, 5); jmpd(0x1012_1ca0, 0xca); goto l_0x1012_1ca0; /* jmp 0x10121ca0 */
        l_0x1012_1bd6:
            ii(0x1012_1bd6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1bda, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1bdd, 6); mov(edx, memd_a32[ds, eax + 0x101b_b05d]); /* mov edx, [eax+0x101bb05d] */
            ii(0x1012_1be3, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x1012_1be9, 5); calld(Definitions.sys_strcpy, 0x4_42e1); /* call 0x10165ecf */
            ii(0x1012_1bee, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1012_1bf3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1012_1bf6, 5); calld(0x1012_3334, 0x1739);             /* call 0x10123334 */
            ii(0x1012_1bfb, 5); jmpd(0x1012_1cf1, 0xf1); goto l_0x1012_1cf1; /* jmp 0x10121cf1 */
        l_0x1012_1c00:
            ii(0x1012_1c00, 4); movsx(eax, memb_a32[ss, ebp - 0x18]);   /* movsx eax, byte [ebp-0x18] */
            ii(0x1012_1c04, 5); calld(0x1007_5fdc, -0xa_bc2d);          /* call 0x10075fdc */
            ii(0x1012_1c09, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_1c0c, 6); pushd(memd_a32[ds, eax + 0x101b_b3f8]); /* push dword [eax+0x101bb3f8] */
            ii(0x1012_1c12, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1c16, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1c19, 6); pushd(memd_a32[ds, eax + 0x101b_b05d]); /* push dword [eax+0x101bb05d] */
            ii(0x1012_1c1f, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x1012_1c25, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1c26, 5); calld(Definitions.sys_sprintf, 0x4_42d6); /* call 0x10165f01 */
            ii(0x1012_1c2b, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_1c2e, 5); jmpd(0x1012_1cf1, 0xbe); goto l_0x1012_1cf1; /* jmp 0x10121cf1 */
        l_0x1012_1c33:
            ii(0x1012_1c33, 4); movsx(eax, memb_a32[ss, ebp - 0x18]);   /* movsx eax, byte [ebp-0x18] */
            ii(0x1012_1c37, 5); calld(0x1007_5fdc, -0xa_bc60);          /* call 0x10075fdc */
            ii(0x1012_1c3c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_1c3f, 6); pushd(memd_a32[ds, eax + 0x101b_b400]); /* push dword [eax+0x101bb400] */
            ii(0x1012_1c45, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1c49, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1c4c, 6); pushd(memd_a32[ds, eax + 0x101b_b05d]); /* push dword [eax+0x101bb05d] */
            ii(0x1012_1c52, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x1012_1c58, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1c59, 5); calld(Definitions.sys_sprintf, 0x4_42a3); /* call 0x10165f01 */
            ii(0x1012_1c5e, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_1c61, 5); jmpd(0x1012_1cf1, 0x8b); goto l_0x1012_1cf1; /* jmp 0x10121cf1 */
        l_0x1012_1c66:
            ii(0x1012_1c66, 5); mov(eax, memd_a32[ds, 0x101c_3964]);    /* mov eax, [0x101c3964] */
            ii(0x1012_1c6b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_1c6e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_1c71, 6); pushd(memd_a32[ds, eax + 0x101b_b418]); /* push dword [eax+0x101bb418] */
            ii(0x1012_1c77, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x1012_1c7c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_1c7f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1c80, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1c84, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1c87, 6); pushd(memd_a32[ds, eax + 0x101b_b05d]); /* push dword [eax+0x101bb05d] */
            ii(0x1012_1c8d, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x1012_1c93, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1c94, 5); calld(Definitions.sys_sprintf, 0x4_4268); /* call 0x10165f01 */
            ii(0x1012_1c99, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_1c9c, 2); jmpd(0x1012_1cf1, 0x53); goto l_0x1012_1cf1; /* jmp 0x10121cf1 */
        l_0x1012_1c9e:
            ii(0x1012_1c9e, 2); jmpd(0x1012_1cf1, 0x51); goto l_0x1012_1cf1; /* jmp 0x10121cf1 */
        l_0x1012_1ca0:
            ii(0x1012_1ca0, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1012_1ca3, 6); mov(memb_a32[ss, ebp - 0xdc], al);      /* mov [ebp-0xdc], al */
            ii(0x1012_1ca9, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x49);    /* cmp byte [ebp-0xdc], 0x49 */
            ii(0x1012_1cb0, 2); if(jbd(0x1012_1ce2, 0x30)) goto l_0x1012_1ce2; /* jb 0x10121ce2 */
            ii(0x1012_1cb2, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x49);    /* cmp byte [ebp-0xdc], 0x49 */
            ii(0x1012_1cb9, 6); if(jbed(0x1012_1c00, -0xbf)) goto l_0x1012_1c00; /* jbe 0x10121c00 */
            ii(0x1012_1cbf, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x4b);    /* cmp byte [ebp-0xdc], 0x4b */
            ii(0x1012_1cc6, 2); if(jbd(0x1012_1ce0, 0x18)) goto l_0x1012_1ce0; /* jb 0x10121ce0 */
            ii(0x1012_1cc8, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x4b);    /* cmp byte [ebp-0xdc], 0x4b */
            ii(0x1012_1ccf, 2); if(jbed(0x1012_1c66, -0x6b)) goto l_0x1012_1c66; /* jbe 0x10121c66 */
            ii(0x1012_1cd1, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x4c);    /* cmp byte [ebp-0xdc], 0x4c */
            ii(0x1012_1cd8, 6); if(jzd(0x1012_1c33, -0xab)) goto l_0x1012_1c33; /* jz 0x10121c33 */
            ii(0x1012_1cde, 2); jmpd(0x1012_1c9e, -0x42); goto l_0x1012_1c9e; /* jmp 0x10121c9e */
        l_0x1012_1ce0:
            ii(0x1012_1ce0, 2); jmpd(0x1012_1c9e, -0x44); goto l_0x1012_1c9e; /* jmp 0x10121c9e */
        l_0x1012_1ce2:
            ii(0x1012_1ce2, 7); cmp(memb_a32[ss, ebp - 0xdc], 0x36);    /* cmp byte [ebp-0xdc], 0x36 */
            ii(0x1012_1ce9, 6); if(jzd(0x1012_1bd6, -0x119)) goto l_0x1012_1bd6; /* jz 0x10121bd6 */
            ii(0x1012_1cef, 2); jmpd(0x1012_1c9e, -0x53); goto l_0x1012_1c9e; /* jmp 0x10121c9e */
        l_0x1012_1cf1:
            ii(0x1012_1cf1, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1012_1cf4, 6); lea(eax, ebp - 0xe0);                   /* lea eax, [ebp-0xe0] */
            ii(0x1012_1cfa, 5); calld(0x100d_4d78, -0x4_cf87);          /* call 0x100d4d78 */
            ii(0x1012_1cff, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d00, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_1d05, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d06, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_1d08, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d09, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1d0e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d0f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1d12, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x1012_1d15, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_1d18, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d19, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_1d1d, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_1d21, 6); lea(edx, ebp - 0xd8);                   /* lea edx, [ebp-0xd8] */
            ii(0x1012_1d27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1d2a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_1d2d, 5); calld(0x100e_ab9d, -0x3_7195);          /* call 0x100eab9d */
            ii(0x1012_1d32, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_1d34, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_1d35, 1); popd(edi);                              /* pop edi */
            ii(0x1012_1d36, 1); popd(esi);                              /* pop esi */
            ii(0x1012_1d37, 1); retd(); return;                         /* ret */
        }
    }
}
