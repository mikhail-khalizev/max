using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7905bcae-6302-4435-b619-549de29eabe2")]
        public void Method_1011_8af8()
        {
            ii(0x1011_8af8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_8afd, 5); calld(Definitions.sys_check_available_stack_size, 0x4_d250); /* call 0x10165d52 */
            ii(0x1011_8b02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_8b03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_8b04, 1); pushd(esi);                             /* push esi */
            ii(0x1011_8b05, 1); pushd(edi);                             /* push edi */
            ii(0x1011_8b06, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8b07, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8b09, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_8b0f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_8b12, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_8b15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8b18, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1011_8b1b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8b1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8b20, 6); if(jzd(0x1011_8cc5, 0x19f)) goto l_0x1011_8cc5; /* jz 0x10118cc5 */
            ii(0x1011_8b26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8b2b, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1011_8b2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8b31, 3); mov(al, memb_a32[ds, eax + 0x18]);      /* mov al, [eax+0x18] */
            ii(0x1011_8b34, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_8b39, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_8b3b, 2); if(jzd(0x1011_8b68, 0x2b)) goto l_0x1011_8b68; /* jz 0x10118b68 */
            ii(0x1011_8b3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b40, 5); calld(0x1015_48ba, 0x3_bd75);           /* call 0x101548ba */
            ii(0x1011_8b45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8b47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b4a, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_8b4d, 5); calld(0x1007_6a34, -0xa_211e);          /* call 0x10076a34 */
            ii(0x1011_8b52, 5); calld(0x1012_0a90, 0x7f39);             /* call 0x10120a90 */
            ii(0x1011_8b57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8b59, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_8b5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b5e, 5); calld(0x1014_f017, 0x3_64b4);           /* call 0x1014f017 */
            ii(0x1011_8b63, 5); jmpd(0x1011_8cc5, 0x15d); goto l_0x1011_8cc5; /* jmp 0x10118cc5 */
        l_0x1011_8b68:
            ii(0x1011_8b68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8b6b, 4); cmp(memd_a32[ds, eax + 0x25], 0);       /* cmp dword [eax+0x25], 0x0 */
            ii(0x1011_8b6f, 2); if(jgd(0x1011_8b88, 0x17)) goto l_0x1011_8b88; /* jg 0x10118b88 */
            ii(0x1011_8b71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b74, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1011_8b77, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8b7a, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8b7d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8b7f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8b82, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1011_8b86, 2); jmpd(0x1011_8ba0, 0x18); goto l_0x1011_8ba0; /* jmp 0x10118ba0 */
        l_0x1011_8b88:
            ii(0x1011_8b88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8b8b, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1011_8b8e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8b91, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1011_8b94, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8b97, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8b99, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8b9c, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
        l_0x1011_8ba0:
            ii(0x1011_8ba0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8ba3, 4); cmp(memd_a32[ds, eax + 0x29], 0);       /* cmp dword [eax+0x29], 0x0 */
            ii(0x1011_8ba7, 2); if(jgd(0x1011_8bc0, 0x17)) goto l_0x1011_8bc0; /* jg 0x10118bc0 */
            ii(0x1011_8ba9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8bac, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_8baf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8bb2, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8bb5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8bb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8bba, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1011_8bbe, 2); jmpd(0x1011_8bd8, 0x18); goto l_0x1011_8bd8; /* jmp 0x10118bd8 */
        l_0x1011_8bc0:
            ii(0x1011_8bc0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8bc3, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_8bc6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8bc9, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1011_8bcc, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1011_8bcf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8bd1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8bd4, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
        l_0x1011_8bd8:
            ii(0x1011_8bd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8bdb, 4); mov(dx, memw_a32[ds, eax + 0x16]);      /* mov dx, [eax+0x16] */
            ii(0x1011_8bdf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8be2, 4); mov(memw_a32[ds, eax + 0x19], dx);      /* mov [eax+0x19], dx */
            ii(0x1011_8be6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8be9, 4); mov(dx, memw_a32[ds, eax + 0x18]);      /* mov dx, [eax+0x18] */
            ii(0x1011_8bed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8bf0, 4); mov(memw_a32[ds, eax + 0x1b], dx);      /* mov [eax+0x1b], dx */
            ii(0x1011_8bf4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8bf7, 7); mov(memd_a32[ds, eax + 0x1d], 0);       /* mov dword [eax+0x1d], 0x0 */
            ii(0x1011_8bfe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c01, 7); mov(memd_a32[ds, eax + 0x21], 0);       /* mov dword [eax+0x21], 0x0 */
            ii(0x1011_8c08, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8c0b, 3); mov(edx, memd_a32[ds, edx + 0x14]);     /* mov edx, [edx+0x14] */
            ii(0x1011_8c0e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8c11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8c14, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_8c16, 3); mov(bl, memb_a32[ds, eax + 0x2a]);      /* mov bl, [eax+0x2a] */
            ii(0x1011_8c19, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_8c1b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_8c1e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_8c20, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_8c22, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8c25, 4); mov(memw_a32[ds, edx + 0x16], ax);      /* mov [edx+0x16], ax */
            ii(0x1011_8c29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c2c, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1011_8c2f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8c32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8c34, 2); if(jnzd(0x1011_8c43, 0xd)) goto l_0x1011_8c43; /* jnz 0x10118c43 */
            ii(0x1011_8c36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c39, 4); inc(memw_a32[ds, eax + 0x16]);          /* inc word [eax+0x16] */
            ii(0x1011_8c3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8c40, 3); inc(memb_a32[ds, eax + 0x4e]);          /* inc byte [eax+0x4e] */
        l_0x1011_8c43:
            ii(0x1011_8c43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c46, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1011_8c49, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8c4c, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1011_8c4f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_8c51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8c54, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_8c57, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8c5a, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1011_8c5c, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_8c5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c61, 3); add(edx, 0x20);                         /* add edx, 0x20 */
            ii(0x1011_8c64, 3); mov(memd_a32[ds, eax + 0x25], edx);     /* mov [eax+0x25], edx */
            ii(0x1011_8c67, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c6a, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1011_8c6d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8c70, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x1011_8c73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8c76, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_8c79, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8c7c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_8c7e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c81, 3); add(edx, 0x20);                         /* add edx, 0x20 */
            ii(0x1011_8c84, 3); mov(memd_a32[ds, eax + 0x29], edx);     /* mov [eax+0x29], edx */
            ii(0x1011_8c87, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8c8a, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x1011_8c8d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_8c90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8c93, 3); mov(ebx, memd_a32[ds, eax + 0x14]);     /* mov ebx, [eax+0x14] */
            ii(0x1011_8c96, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_8c99, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_8c9b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_8c9e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_8ca0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8ca3, 3); mov(memd_a32[ds, edx + 0x25], eax);     /* mov [edx+0x25], eax */
            ii(0x1011_8ca6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8ca9, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x1011_8cac, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_8caf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_8cb2, 3); mov(ebx, memd_a32[ds, eax + 0x14]);     /* mov ebx, [eax+0x14] */
            ii(0x1011_8cb5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_8cb8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_8cba, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_8cbd, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_8cbf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8cc2, 3); mov(memd_a32[ds, edx + 0x29], eax);     /* mov [edx+0x29], eax */
        l_0x1011_8cc5:
            ii(0x1011_8cc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8cc7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_8cc8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_8cc9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_8cca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_8ccb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_8ccc, 1); retd(); return;                         /* ret */
        }
    }
}
