using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6bd7-d3a8473e")]
        public void Method_1014_6bd7()
        {
            ii(0x1014_6bd7, 5); pushd(0x70);                            /* push 0x70 */
            ii(0x1014_6bdc, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f171); /* call 0x10165d52 */
            ii(0x1014_6be1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_6be2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6be3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6be4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6be5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6be7, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1014_6bed, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_6bf0, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_6bf3, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_6bf6, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_6bfa, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6bfd, 5); calld(Definitions.my_string_ctor, -0x511a); /* call 0x10141ae8 */
            ii(0x1014_6c02, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_6c05, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_6c09, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_6c0c, 3); add(edx, 0x12);                         /* add edx, 0x12 */
            ii(0x1014_6c0f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1014_6c12, 5); calld(0x1014_77f0, 0xbd9);              /* call 0x101477f0 */
            ii(0x1014_6c17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c1a, 5); calld(0x1014_68e2, -0x33d);             /* call 0x101468e2 */
            ii(0x1014_6c1f, 2); test(al, al);                           /* test al, al */
            ii(0x1014_6c21, 2); if(jnzd(0x1014_6c46, 0x23)) goto l_0x1014_6c46; /* jnz 0x10146c46 */
            ii(0x1014_6c23, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6c25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6c28, 5); calld(0x1014_7f44, 0x1317);             /* call 0x10147f44 */
            ii(0x1014_6c2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6c2f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1014_6c32, 5); calld(0x1013_9d0c, -0xcf2b);            /* call 0x10139d0c */
            ii(0x1014_6c37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6c39, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6c3c, 5); calld(Definitions.my_string_dtor, -0x5117); /* call 0x10141b2a */
            ii(0x1014_6c41, 5); jmpd(0x1014_6ea3, 0x25d); goto l_0x1014_6ea3; /* jmp 0x10146ea3 */
        l_0x1014_6c46:
            ii(0x1014_6c46, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c49, 4); cmp(memd_a32[ds, eax + 0x1c], 0x22);    /* cmp dword [eax+0x1c], 0x22 */
            ii(0x1014_6c4d, 6); if(jnzd(0x1014_6d18, 0xc5)) goto l_0x1014_6d18; /* jnz 0x10146d18 */
            ii(0x1014_6c53, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c56, 5); calld(0x1014_6722, -0x539);             /* call 0x10146722 */
        l_0x1014_6c5b:
            ii(0x1014_6c5b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c5e, 4); cmp(memd_a32[ds, eax + 0x1c], 0x22);    /* cmp dword [eax+0x1c], 0x22 */
            ii(0x1014_6c62, 2); if(jzd(0x1014_6c6d, 0x9)) goto l_0x1014_6c6d; /* jz 0x10146c6d */
            ii(0x1014_6c64, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c67, 4); cmp(memd_a32[ds, eax + 0x1c], -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xffffffff */
            ii(0x1014_6c6b, 2); if(jnzd(0x1014_6c6f, 0x2)) goto l_0x1014_6c6f; /* jnz 0x10146c6f */
        l_0x1014_6c6d:
            ii(0x1014_6c6d, 2); jmpd(0x1014_6c78, 0x9); goto l_0x1014_6c78; /* jmp 0x10146c78 */
        l_0x1014_6c6f:
            ii(0x1014_6c6f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c72, 4); cmp(memd_a32[ds, eax + 0x1c], 0xa);     /* cmp dword [eax+0x1c], 0xa */
            ii(0x1014_6c76, 2); if(jnzd(0x1014_6c7a, 0x2)) goto l_0x1014_6c7a; /* jnz 0x10146c7a */
        l_0x1014_6c78:
            ii(0x1014_6c78, 2); jmpd(0x1014_6c94, 0x1a); goto l_0x1014_6c94; /* jmp 0x10146c94 */
        l_0x1014_6c7a:
            ii(0x1014_6c7a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c7d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6c7f, 3); mov(dl, memb_a32[ds, eax + 0x1c]);      /* mov dl, [eax+0x1c] */
            ii(0x1014_6c82, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6c85, 5); calld(Definitions.my_string_append_char, -0x4ea0); /* call 0x10141dea */
            ii(0x1014_6c8a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c8d, 5); calld(0x1014_6722, -0x570);             /* call 0x10146722 */
            ii(0x1014_6c92, 2); jmpd(0x1014_6c5b, -0x39); goto l_0x1014_6c5b; /* jmp 0x10146c5b */
        l_0x1014_6c94:
            ii(0x1014_6c94, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6c97, 4); cmp(memd_a32[ds, eax + 0x1c], 0x22);    /* cmp dword [eax+0x1c], 0x22 */
            ii(0x1014_6c9b, 2); if(jnzd(0x1014_6ca7, 0xa)) goto l_0x1014_6ca7; /* jnz 0x10146ca7 */
            ii(0x1014_6c9d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6ca0, 5); calld(0x1014_6722, -0x583);             /* call 0x10146722 */
            ii(0x1014_6ca5, 2); jmpd(0x1014_6cb9, 0x12); goto l_0x1014_6cb9; /* jmp 0x10146cb9 */
        l_0x1014_6ca7:
            ii(0x1014_6ca7, 5); mov(eax, StringDefinitions.ExpectingAnEndQuote); /* mov eax, 0x101ad065 */
            ii(0x1014_6cac, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6cad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6cb0, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6cb1, 5); calld(0x1014_6a6d, -0x249);             /* call 0x10146a6d */
            ii(0x1014_6cb6, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1014_6cb9:
            ii(0x1014_6cb9, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1014_6cbe, 5); calld(Definitions.sys_new, 0x1_f13d);   /* call 0x10165e00 */
            ii(0x1014_6cc3, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1014_6cc6, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1014_6cc9, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1014_6ccc, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1014_6cd0, 2); if(jzd(0x1014_6cee, 0x1c)) goto l_0x1014_6cee; /* jz 0x10146cee */
            ii(0x1014_6cd2, 3); lea(ecx, ebp - 0x24);                   /* lea ecx, [ebp-0x24] */
            ii(0x1014_6cd5, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x1014_6cd8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_6cdb, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1014_6cde, 5); calld(0x1014_542f, -0x18b4);            /* call 0x1014542f */
            ii(0x1014_6ce3, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1014_6ce6, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1014_6ce9, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1014_6cec, 2); jmpd(0x1014_6cf4, 0x6); goto l_0x1014_6cf4; /* jmp 0x10146cf4 */
        l_0x1014_6cee:
            ii(0x1014_6cee, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_6cf1, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x1014_6cf4:
            ii(0x1014_6cf4, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x1014_6cf7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6cfa, 5); calld(0x1014_7f44, 0x1245);             /* call 0x10147f44 */
            ii(0x1014_6cff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6d01, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1014_6d04, 5); calld(0x1013_9d0c, -0xcffd);            /* call 0x10139d0c */
            ii(0x1014_6d09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6d0b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6d0e, 5); calld(Definitions.my_string_dtor, -0x51e9); /* call 0x10141b2a */
            ii(0x1014_6d13, 5); jmpd(0x1014_6ea3, 0x18b); goto l_0x1014_6ea3; /* jmp 0x10146ea3 */
        l_0x1014_6d18:
            ii(0x1014_6d18, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6d1b, 3); mov(al, memb_a32[ds, eax + 0x1c]);      /* mov al, [eax+0x1c] */
            ii(0x1014_6d1e, 2); inc(al);                                /* inc al */
            ii(0x1014_6d20, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_6d25, 7); test(memb_a32[ds, eax + 0x101b_75c0], 0xc0); /* test byte [eax+0x101b75c0], 0xc0 */
            ii(0x1014_6d2c, 6); if(jzd(0x1014_6db2, 0x80)) goto l_0x1014_6db2; /* jz 0x10146db2 */
            ii(0x1014_6d32, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1014_6d35, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6d38, 5); calld(0x1014_6b38, -0x205);             /* call 0x10146b38 */
            ii(0x1014_6d3d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_6d3f, 2); if(jnzd(0x1014_6d53, 0x12)) goto l_0x1014_6d53; /* jnz 0x10146d53 */
            ii(0x1014_6d41, 5); mov(eax, StringDefinitions.ExpectingAWord); /* mov eax, 0x101ad082 */
            ii(0x1014_6d46, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6d47, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6d4a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6d4b, 5); calld(0x1014_6a6d, -0x2e3);             /* call 0x10146a6d */
            ii(0x1014_6d50, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1014_6d53:
            ii(0x1014_6d53, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1014_6d58, 5); calld(Definitions.sys_new, 0x1_f0a3);   /* call 0x10165e00 */
            ii(0x1014_6d5d, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1014_6d60, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1014_6d63, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1014_6d66, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1014_6d6a, 2); if(jzd(0x1014_6d88, 0x1c)) goto l_0x1014_6d88; /* jz 0x10146d88 */
            ii(0x1014_6d6c, 3); lea(ecx, ebp - 0x24);                   /* lea ecx, [ebp-0x24] */
            ii(0x1014_6d6f, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x1014_6d72, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_6d75, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1014_6d78, 5); calld(0x1014_54db, -0x18a2);            /* call 0x101454db */
            ii(0x1014_6d7d, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1014_6d80, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_6d83, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1014_6d86, 2); jmpd(0x1014_6d8e, 0x6); goto l_0x1014_6d8e; /* jmp 0x10146d8e */
        l_0x1014_6d88:
            ii(0x1014_6d88, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1014_6d8b, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x1014_6d8e:
            ii(0x1014_6d8e, 3); mov(edx, memd_a32[ss, ebp - 0x50]);     /* mov edx, [ebp-0x50] */
            ii(0x1014_6d91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6d94, 5); calld(0x1014_7f44, 0x11ab);             /* call 0x10147f44 */
            ii(0x1014_6d99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6d9b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1014_6d9e, 5); calld(0x1013_9d0c, -0xd097);            /* call 0x10139d0c */
            ii(0x1014_6da3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6da5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6da8, 5); calld(Definitions.my_string_dtor, -0x5283); /* call 0x10141b2a */
            ii(0x1014_6dad, 5); jmpd(0x1014_6ea3, 0xf1); goto l_0x1014_6ea3; /* jmp 0x10146ea3 */
        l_0x1014_6db2:
            ii(0x1014_6db2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6db5, 4); cmp(memd_a32[ds, eax + 0x1c], 0x2d);    /* cmp dword [eax+0x1c], 0x2d */
            ii(0x1014_6db9, 2); if(jnzd(0x1014_6dd3, 0x18)) goto l_0x1014_6dd3; /* jnz 0x10146dd3 */
            ii(0x1014_6dbb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6dbe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6dc0, 3); mov(dl, memb_a32[ds, eax + 0x1c]);      /* mov dl, [eax+0x1c] */
            ii(0x1014_6dc3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6dc6, 5); calld(Definitions.my_string_append_char, -0x4fe1); /* call 0x10141dea */
            ii(0x1014_6dcb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6dce, 5); calld(0x1014_6722, -0x6b1);             /* call 0x10146722 */
        l_0x1014_6dd3:
            ii(0x1014_6dd3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6dd6, 4); cmp(memd_a32[ds, eax + 0x1c], 0x30);    /* cmp dword [eax+0x1c], 0x30 */
            ii(0x1014_6dda, 2); if(jld(0x1014_6de5, 0x9)) goto l_0x1014_6de5; /* jl 0x10146de5 */
            ii(0x1014_6ddc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6ddf, 4); cmp(memd_a32[ds, eax + 0x1c], 0x39);    /* cmp dword [eax+0x1c], 0x39 */
            ii(0x1014_6de3, 2); if(jled(0x1014_6df7, 0x12)) goto l_0x1014_6df7; /* jle 0x10146df7 */
        l_0x1014_6de5:
            ii(0x1014_6de5, 5); mov(eax, StringDefinitions.ExpectingANumberOrString); /* mov eax, 0x101ad093 */
            ii(0x1014_6dea, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6deb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6dee, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6def, 5); calld(0x1014_69b5, -0x43f);             /* call 0x101469b5 */
            ii(0x1014_6df4, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1014_6df7:
            ii(0x1014_6df7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6dfa, 4); cmp(memd_a32[ds, eax + 0x1c], 0x30);    /* cmp dword [eax+0x1c], 0x30 */
            ii(0x1014_6dfe, 2); if(jld(0x1014_6e09, 0x9)) goto l_0x1014_6e09; /* jl 0x10146e09 */
            ii(0x1014_6e00, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6e03, 4); cmp(memd_a32[ds, eax + 0x1c], 0x39);    /* cmp dword [eax+0x1c], 0x39 */
            ii(0x1014_6e07, 2); if(jled(0x1014_6e0b, 0x2)) goto l_0x1014_6e0b; /* jle 0x10146e0b */
        l_0x1014_6e09:
            ii(0x1014_6e09, 2); jmpd(0x1014_6e25, 0x1a); goto l_0x1014_6e25; /* jmp 0x10146e25 */
        l_0x1014_6e0b:
            ii(0x1014_6e0b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6e0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6e10, 3); mov(dl, memb_a32[ds, eax + 0x1c]);      /* mov dl, [eax+0x1c] */
            ii(0x1014_6e13, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6e16, 5); calld(Definitions.my_string_append_char, -0x5031); /* call 0x10141dea */
            ii(0x1014_6e1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6e1e, 5); calld(0x1014_6722, -0x701);             /* call 0x10146722 */
            ii(0x1014_6e23, 2); jmpd(0x1014_6df7, -0x2e); goto l_0x1014_6df7; /* jmp 0x10146df7 */
        l_0x1014_6e25:
            ii(0x1014_6e25, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1014_6e2a, 5); calld(Definitions.sys_new, 0x1_efd1);   /* call 0x10165e00 */
            ii(0x1014_6e2f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_6e32, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_6e35, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_6e38, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1014_6e3c, 2); if(jzd(0x1014_6e68, 0x2a)) goto l_0x1014_6e68; /* jz 0x10146e68 */
            ii(0x1014_6e3e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6e41, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_d67e); /* call 0x100897c8 */
            ii(0x1014_6e46, 5); calld(/* sys */ 0x1017_90ce, 0x3_2283); /* call 0x101790ce */
            ii(0x1014_6e4b, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x1014_6e4e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_6e51, 3); mov(esi, memd_a32[ss, ebp - 0x14]);     /* mov esi, [ebp-0x14] */
            ii(0x1014_6e54, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1014_6e56, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_6e58, 5); calld(0x1014_53a5, -0x1ab8);            /* call 0x101453a5 */
            ii(0x1014_6e5d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_6e60, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_6e63, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1014_6e66, 2); jmpd(0x1014_6e6e, 0x6); goto l_0x1014_6e6e; /* jmp 0x10146e6e */
        l_0x1014_6e68:
            ii(0x1014_6e68, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_6e6b, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x1014_6e6e:
            ii(0x1014_6e6e, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x1014_6e71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6e74, 5); calld(0x1014_7f44, 0x10cb);             /* call 0x10147f44 */
            ii(0x1014_6e79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6e7b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1014_6e7e, 5); calld(0x1013_9d0c, -0xd177);            /* call 0x10139d0c */
            ii(0x1014_6e83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6e85, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_6e88, 5); calld(Definitions.my_string_dtor, -0x5363); /* call 0x10141b2a */
            ii(0x1014_6e8d, 2); jmpd(0x1014_6ea3, 0x14); goto l_0x1014_6ea3; /* jmp 0x10146ea3 */
        //  ii(0x1014_6e8f, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_6e91, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
        //  ii(0x1014_6e94, 5); calld(0x1013_9d0c, -0xd18d);            /* call 0x10139d0c */
        //  ii(0x1014_6e99, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_6e9b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x1014_6e9e, 5); calld(Definitions.my_string_dtor, -0x5379); /* call 0x10141b2a */
        l_0x1014_6ea3:
            ii(0x1014_6ea3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6ea6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6ea8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_6ea9, 1); popd(edi);                              /* pop edi */
            ii(0x1014_6eaa, 1); popd(esi);                              /* pop esi */
            ii(0x1014_6eab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6eac, 1); retd(); return;                         /* ret */
        }
    }
}
