using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0b47-f705cfe4")]
        public void Method_100a_0b47()
        {
            ii(0x100a_0b47, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_0b4c, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5201); /* call 0x10165d52 */
            ii(0x100a_0b51, 1); pushd(esi);                             /* push esi */
            ii(0x100a_0b52, 1); pushd(edi);                             /* push edi */
            ii(0x100a_0b53, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_0b54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0b56, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_0b5c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_0b5f, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_0b62, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_0b65, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_0b68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0b6b, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100a_0b6e, 2); if(jzd(0x100a_0b76, 0x6)) goto l_0x100a_0b76; /* jz 0x100a0b76 */
            ii(0x100a_0b70, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_0b74, 2); if(jgd(0x100a_0b82, 0xc)) goto l_0x100a_0b82; /* jg 0x100a0b82 */
        l_0x100a_0b76:
            ii(0x100a_0b76, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_0b7d, 5); jmpd(0x100a_0d1c, 0x19a); goto l_0x100a_0d1c; /* jmp 0x100a0d1c */
        l_0x100a_0b82:
            ii(0x100a_0b82, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0b85, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_0b88, 2); jmpd(0x100a_0bf8, 0x6e); goto l_0x100a_0bf8; /* jmp 0x100a0bf8 */
        l_0x100a_0b8a:
            ii(0x100a_0b8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0b8d, 3); mov(ebx, memd_a32[ds, eax + 0x36]);     /* mov ebx, [eax+0x36] */
            ii(0x100a_0b90, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_0b93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0b96, 3); mov(edx, memd_a32[ds, eax + 0x1e]);     /* mov edx, [eax+0x1e] */
            ii(0x100a_0b99, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0b9c, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100a_0b9e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_0ba0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0ba3, 5); calld(Definitions.my_min, -0x1_7424);   /* call 0x10089784 */
            ii(0x100a_0ba8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0bab, 5); jmpd(0x100a_0c1b, 0x6b); goto l_0x100a_0c1b; /* jmp 0x100a0c1b */
        l_0x100a_0bb0:
            ii(0x100a_0bb0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0bb3, 3); mov(ebx, memd_a32[ds, eax + 0x38]);     /* mov ebx, [eax+0x38] */
            ii(0x100a_0bb6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_0bb9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0bbc, 3); mov(edx, memd_a32[ds, eax + 0x20]);     /* mov edx, [eax+0x20] */
            ii(0x100a_0bbf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0bc2, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100a_0bc4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_0bc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0bc9, 5); calld(Definitions.my_min, -0x1_744a);   /* call 0x10089784 */
            ii(0x100a_0bce, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0bd1, 2); jmpd(0x100a_0c1b, 0x48); goto l_0x100a_0c1b; /* jmp 0x100a0c1b */
        l_0x100a_0bd3:
            ii(0x100a_0bd3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0bd6, 3); mov(ebx, memd_a32[ds, eax + 0x34]);     /* mov ebx, [eax+0x34] */
            ii(0x100a_0bd9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_0bdc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0bdf, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x100a_0be2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0be5, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100a_0be7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_0be9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0bec, 5); calld(Definitions.my_min, -0x1_746d);   /* call 0x10089784 */
            ii(0x100a_0bf1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0bf4, 2); jmpd(0x100a_0c1b, 0x25); goto l_0x100a_0c1b; /* jmp 0x100a0c1b */
        l_0x100a_0bf6:
            ii(0x100a_0bf6, 2); jmpd(0x100a_0c1b, 0x23); goto l_0x100a_0c1b; /* jmp 0x100a0c1b */
        l_0x100a_0bf8:
            ii(0x100a_0bf8, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x40);    /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x100a_0bfc, 2); if(jbd(0x100a_0c13, 0x15)) goto l_0x100a_0c13; /* jb 0x100a0c13 */
            ii(0x100a_0bfe, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x40);    /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x100a_0c02, 2); if(jbed(0x100a_0bd3, -0x31)) goto l_0x100a_0bd3; /* jbe 0x100a0bd3 */
            ii(0x100a_0c04, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x80);    /* cmp dword [ebp-0x1c], 0x80 */
            ii(0x100a_0c0b, 6); if(jzd(0x100a_0b8a, -0x87)) goto l_0x100a_0b8a; /* jz 0x100a0b8a */
            ii(0x100a_0c11, 2); jmpd(0x100a_0bf6, -0x1d); goto l_0x100a_0bf6; /* jmp 0x100a0bf6 */
        l_0x100a_0c13:
            ii(0x100a_0c13, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x20);    /* cmp dword [ebp-0x1c], 0x20 */
            ii(0x100a_0c17, 2); if(jzd(0x100a_0bb0, -0x69)) goto l_0x100a_0bb0; /* jz 0x100a0bb0 */
            ii(0x100a_0c19, 2); jmpd(0x100a_0bf6, -0x25); goto l_0x100a_0bf6; /* jmp 0x100a0bf6 */
        l_0x100a_0c1b:
            ii(0x100a_0c1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0c1e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_0c21, 2); jmpd(0x100a_0c67, 0x44); goto l_0x100a_0c67; /* jmp 0x100a0c67 */
        l_0x100a_0c23:
            ii(0x100a_0c23, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0c26, 3); mov(edx, memd_a32[ds, eax + 0x1e]);     /* mov edx, [eax+0x1e] */
            ii(0x100a_0c29, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0c2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0c2f, 5); calld(Definitions.my_min, -0x1_74b0);   /* call 0x10089784 */
            ii(0x100a_0c34, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0c37, 2); jmpd(0x100a_0c86, 0x4d); goto l_0x100a_0c86; /* jmp 0x100a0c86 */
        l_0x100a_0c39:
            ii(0x100a_0c39, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0c3c, 3); mov(edx, memd_a32[ds, eax + 0x20]);     /* mov edx, [eax+0x20] */
            ii(0x100a_0c3f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0c42, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0c45, 5); calld(Definitions.my_min, -0x1_74c6);   /* call 0x10089784 */
            ii(0x100a_0c4a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0c4d, 2); jmpd(0x100a_0c86, 0x37); goto l_0x100a_0c86; /* jmp 0x100a0c86 */
        l_0x100a_0c4f:
            ii(0x100a_0c4f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0c52, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x100a_0c55, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0c58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0c5b, 5); calld(Definitions.my_min, -0x1_74dc);   /* call 0x10089784 */
            ii(0x100a_0c60, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0c63, 2); jmpd(0x100a_0c86, 0x21); goto l_0x100a_0c86; /* jmp 0x100a0c86 */
        l_0x100a_0c65:
            ii(0x100a_0c65, 2); jmpd(0x100a_0c86, 0x1f); goto l_0x100a_0c86; /* jmp 0x100a0c86 */
        l_0x100a_0c67:
            ii(0x100a_0c67, 4); cmp(memd_a32[ss, ebp - 0x20], 0x40);    /* cmp dword [ebp-0x20], 0x40 */
            ii(0x100a_0c6b, 2); if(jbd(0x100a_0c7e, 0x11)) goto l_0x100a_0c7e; /* jb 0x100a0c7e */
            ii(0x100a_0c6d, 4); cmp(memd_a32[ss, ebp - 0x20], 0x40);    /* cmp dword [ebp-0x20], 0x40 */
            ii(0x100a_0c71, 2); if(jbed(0x100a_0c4f, -0x24)) goto l_0x100a_0c4f; /* jbe 0x100a0c4f */
            ii(0x100a_0c73, 7); cmp(memd_a32[ss, ebp - 0x20], 0x80);    /* cmp dword [ebp-0x20], 0x80 */
            ii(0x100a_0c7a, 2); if(jzd(0x100a_0c23, -0x59)) goto l_0x100a_0c23; /* jz 0x100a0c23 */
            ii(0x100a_0c7c, 2); jmpd(0x100a_0c65, -0x19); goto l_0x100a_0c65; /* jmp 0x100a0c65 */
        l_0x100a_0c7e:
            ii(0x100a_0c7e, 4); cmp(memd_a32[ss, ebp - 0x20], 0x20);    /* cmp dword [ebp-0x20], 0x20 */
            ii(0x100a_0c82, 2); if(jzd(0x100a_0c39, -0x4b)) goto l_0x100a_0c39; /* jz 0x100a0c39 */
            ii(0x100a_0c84, 2); jmpd(0x100a_0c65, -0x21); goto l_0x100a_0c65; /* jmp 0x100a0c65 */
        l_0x100a_0c86:
            ii(0x100a_0c86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0c89, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100a_0c8c, 2); if(jzd(0x100a_0c94, 0x6)) goto l_0x100a_0c94; /* jz 0x100a0c94 */
            ii(0x100a_0c8e, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_0c92, 2); if(jgd(0x100a_0ca0, 0xc)) goto l_0x100a_0ca0; /* jg 0x100a0ca0 */
        l_0x100a_0c94:
            ii(0x100a_0c94, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_0c9b, 5); jmpd(0x100a_0d1c, 0x7c); goto l_0x100a_0d1c; /* jmp 0x100a0d1c */
        l_0x100a_0ca0:
            ii(0x100a_0ca0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_0ca3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_0ca6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0ca9, 5); calld(0x100a_0aa5, -0x209);             /* call 0x100a0aa5 */
            ii(0x100a_0cae, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_0cb1, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100a_0cb4, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_0cb7, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0cba, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0cbd, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_0cc0, 5); calld(0x1007_68e0, -0x2_a3e5);          /* call 0x100768e0 */
            ii(0x100a_0cc5, 5); calld(0x1014_37d1, 0xa_2b07);           /* call 0x101437d1 */
            ii(0x100a_0cca, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_0ccd, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x100a_0cd0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0cd3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0cd6, 5); calld(0x100a_0a0a, -0x2d1);             /* call 0x100a0a0a */
            ii(0x100a_0cdb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_0cde, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100a_0ce1, 2); if(jged(0x100a_0d16, 0x33)) goto l_0x100a_0d16; /* jge 0x100a0d16 */
            ii(0x100a_0ce3, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100a_0ce6, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_0ce9, 3); sub(ebx, memd_a32[ss, ebp - 0x14]);     /* sub ebx, [ebp-0x14] */
            ii(0x100a_0cec, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_0cef, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0cf2, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_0cf5, 5); calld(0x1007_68e0, -0x2_a41a);          /* call 0x100768e0 */
            ii(0x100a_0cfa, 5); calld(0x1014_37d1, 0xa_2ad2);           /* call 0x101437d1 */
            ii(0x100a_0cff, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_0d02, 3); sub(ebx, memd_a32[ss, ebp - 0x14]);     /* sub ebx, [ebp-0x14] */
            ii(0x100a_0d05, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_0d08, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_0d0b, 5); calld(0x100a_0a0a, -0x306);             /* call 0x100a0a0a */
            ii(0x100a_0d10, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_0d13, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100a_0d16:
            ii(0x100a_0d16, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0d19, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100a_0d1c:
            ii(0x100a_0d1c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_0d1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_0d21, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_0d22, 1); popd(edi);                              /* pop edi */
            ii(0x100a_0d23, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0d24, 1); retd(); return;                         /* ret */
        }
    }
}
