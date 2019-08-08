using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ace0b9e-cf04-4c89-84a3-7e06833fe30d")]
        public void Method_100c_9b42()
        {
            ii(0x100c_9b42, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_9b47, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c206); /* call 0x10165d52 */
            ii(0x100c_9b4c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_9b4d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_9b4e, 1); pushd(esi);                             /* push esi */
            ii(0x100c_9b4f, 1); pushd(edi);                             /* push edi */
            ii(0x100c_9b50, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_9b51, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_9b53, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_9b59, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_9b5c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_9b5f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_9b61, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_9b64, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x100c_9b67, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_9b6a, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_9b6f, 5); calld(0x1007_6338, -0x5_383c);          /* call 0x10076338 */
            ii(0x100c_9b74, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100c_9b77, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9b79, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_9b7b, 5); calld(0x1007_64b8, -0x5_36c8);          /* call 0x100764b8 */
            ii(0x100c_9b80, 2); jmpd(0x100c_9b8a, 0x8); goto l_0x100c_9b8a; /* jmp 0x100c9b8a */
        l_0x100c_9b82:
            ii(0x100c_9b82, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9b85, 5); calld(0x1007_6bf8, -0x5_2f92);          /* call 0x10076bf8 */
        l_0x100c_9b8a:
            ii(0x100c_9b8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9b8c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9b8f, 5); calld(0x1013_ad71, 0x7_11dd);           /* call 0x1013ad71 */
            ii(0x100c_9b94, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9b96, 6); if(jzd(0x100c_9c50, 0xb4)) goto l_0x100c_9c50; /* jz 0x100c9c50 */
            ii(0x100c_9b9c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9b9f, 5); calld(0x1007_63a0, -0x5_3804);          /* call 0x100763a0 */
            ii(0x100c_9ba4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9ba6, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_9ba9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_9bad, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9baf, 2); if(jzd(0x100c_9bc6, 0x15)) goto l_0x100c_9bc6; /* jz 0x100c9bc6 */
            ii(0x100c_9bb1, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100c_9bb5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9bb8, 5); calld(0x1007_63a0, -0x5_381d);          /* call 0x100763a0 */
            ii(0x100c_9bbd, 5); calld(0x1007_6074, -0x5_3b4e);          /* call 0x10076074 */
            ii(0x100c_9bc2, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9bc4, 2); if(jnzd(0x100c_9bc8, 0x2)) goto l_0x100c_9bc8; /* jnz 0x100c9bc8 */
        l_0x100c_9bc6:
            ii(0x100c_9bc6, 2); jmpd(0x100c_9bdf, 0x17); goto l_0x100c_9bdf; /* jmp 0x100c9bdf */
        l_0x100c_9bc8:
            ii(0x100c_9bc8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9bcb, 5); calld(0x1007_63a0, -0x5_3830);          /* call 0x100763a0 */
            ii(0x100c_9bd0, 5); calld(0x1007_623c, -0x5_3999);          /* call 0x1007623c */
            ii(0x100c_9bd5, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_9bd8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9bdb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9bdd, 2); if(jgd(0x100c_9be1, 0x2)) goto l_0x100c_9be1; /* jg 0x100c9be1 */
        l_0x100c_9bdf:
            ii(0x100c_9bdf, 2); jmpd(0x100c_9bef, 0xe); goto l_0x100c_9bef; /* jmp 0x100c9bef */
        l_0x100c_9be1:
            ii(0x100c_9be1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9be4, 5); calld(0x1007_63a0, -0x5_3849);          /* call 0x100763a0 */
            ii(0x100c_9be9, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_9bed, 2); if(jnzd(0x100c_9bf1, 0x2)) goto l_0x100c_9bf1; /* jnz 0x100c9bf1 */
        l_0x100c_9bef:
            ii(0x100c_9bef, 2); jmpd(0x100c_9bff, 0xe); goto l_0x100c_9bff; /* jmp 0x100c9bff */
        l_0x100c_9bf1:
            ii(0x100c_9bf1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9bf4, 5); calld(0x1007_63a0, -0x5_3859);          /* call 0x100763a0 */
            ii(0x100c_9bf9, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_9bfd, 2); if(jnzd(0x100c_9c01, 0x2)) goto l_0x100c_9c01; /* jnz 0x100c9c01 */
        l_0x100c_9bff:
            ii(0x100c_9bff, 2); jmpd(0x100c_9c15, 0x14); goto l_0x100c_9c15; /* jmp 0x100c9c15 */
        l_0x100c_9c01:
            ii(0x100c_9c01, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c04, 5); calld(0x1007_63a0, -0x5_3869);          /* call 0x100763a0 */
            ii(0x100c_9c09, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100c_9c0c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9c11, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9c13, 2); if(jgd(0x100c_9c17, 0x2)) goto l_0x100c_9c17; /* jg 0x100c9c17 */
        l_0x100c_9c15:
            ii(0x100c_9c15, 2); jmpd(0x100c_9c37, 0x20); goto l_0x100c_9c37; /* jmp 0x100c9c37 */
        l_0x100c_9c17:
            ii(0x100c_9c17, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_9c1a, 3); mov(edx, memd_a32[ds, edx + 0x6]);      /* mov edx, [edx+0x6] */
            ii(0x100c_9c1d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9c20, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c23, 5); calld(0x1007_63a0, -0x5_3888);          /* call 0x100763a0 */
            ii(0x100c_9c28, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_9c2b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9c2e, 5); calld(0x1007_49d4, -0x5_525f);          /* call 0x100749d4 */
            ii(0x100c_9c33, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9c35, 2); if(jnzd(0x100c_9c39, 0x2)) goto l_0x100c_9c39; /* jnz 0x100c9c39 */
        l_0x100c_9c37:
            ii(0x100c_9c37, 2); jmpd(0x100c_9c4b, 0x12); goto l_0x100c_9c4b; /* jmp 0x100c9c4b */
        l_0x100c_9c39:
            ii(0x100c_9c39, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c3c, 5); calld(0x1007_63d4, -0x5_386d);          /* call 0x100763d4 */
            ii(0x100c_9c41, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9c43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_9c46, 5); calld(0x100c_993c, -0x30f);             /* call 0x100c993c */
        l_0x100c_9c4b:
            ii(0x100c_9c4b, 5); jmpd(0x100c_9b82, -0xce); goto l_0x100c_9b82; /* jmp 0x100c9b82 */
        l_0x100c_9c50:
            ii(0x100c_9c50, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_9c55, 5); calld(0x1007_6338, -0x5_3922);          /* call 0x10076338 */
            ii(0x100c_9c5a, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100c_9c5d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9c5f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_9c61, 5); calld(0x1007_643c, -0x5_382a);          /* call 0x1007643c */
            ii(0x100c_9c66, 2); jmpd(0x100c_9c70, 0x8); goto l_0x100c_9c70; /* jmp 0x100c9c70 */
        l_0x100c_9c68:
            ii(0x100c_9c68, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c6b, 5); calld(0x1007_6bf8, -0x5_3078);          /* call 0x10076bf8 */
        l_0x100c_9c70:
            ii(0x100c_9c70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9c72, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c75, 5); calld(0x1013_ad71, 0x7_10f7);           /* call 0x1013ad71 */
            ii(0x100c_9c7a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9c7c, 6); if(jzd(0x100c_9d36, 0xb4)) goto l_0x100c_9d36; /* jz 0x100c9d36 */
            ii(0x100c_9c82, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c85, 5); calld(0x1007_63a0, -0x5_38ea);          /* call 0x100763a0 */
            ii(0x100c_9c8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9c8c, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_9c8f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_9c93, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9c95, 2); if(jzd(0x100c_9cac, 0x15)) goto l_0x100c_9cac; /* jz 0x100c9cac */
            ii(0x100c_9c97, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100c_9c9b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9c9e, 5); calld(0x1007_63a0, -0x5_3903);          /* call 0x100763a0 */
            ii(0x100c_9ca3, 5); calld(0x1007_6074, -0x5_3c34);          /* call 0x10076074 */
            ii(0x100c_9ca8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9caa, 2); if(jnzd(0x100c_9cae, 0x2)) goto l_0x100c_9cae; /* jnz 0x100c9cae */
        l_0x100c_9cac:
            ii(0x100c_9cac, 2); jmpd(0x100c_9cc5, 0x17); goto l_0x100c_9cc5; /* jmp 0x100c9cc5 */
        l_0x100c_9cae:
            ii(0x100c_9cae, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9cb1, 5); calld(0x1007_63a0, -0x5_3916);          /* call 0x100763a0 */
            ii(0x100c_9cb6, 5); calld(0x1007_623c, -0x5_3a7f);          /* call 0x1007623c */
            ii(0x100c_9cbb, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_9cbe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9cc1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9cc3, 2); if(jgd(0x100c_9cc7, 0x2)) goto l_0x100c_9cc7; /* jg 0x100c9cc7 */
        l_0x100c_9cc5:
            ii(0x100c_9cc5, 2); jmpd(0x100c_9cd5, 0xe); goto l_0x100c_9cd5; /* jmp 0x100c9cd5 */
        l_0x100c_9cc7:
            ii(0x100c_9cc7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9cca, 5); calld(0x1007_63a0, -0x5_392f);          /* call 0x100763a0 */
            ii(0x100c_9ccf, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_9cd3, 2); if(jnzd(0x100c_9cd7, 0x2)) goto l_0x100c_9cd7; /* jnz 0x100c9cd7 */
        l_0x100c_9cd5:
            ii(0x100c_9cd5, 2); jmpd(0x100c_9ce5, 0xe); goto l_0x100c_9ce5; /* jmp 0x100c9ce5 */
        l_0x100c_9cd7:
            ii(0x100c_9cd7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9cda, 5); calld(0x1007_63a0, -0x5_393f);          /* call 0x100763a0 */
            ii(0x100c_9cdf, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_9ce3, 2); if(jnzd(0x100c_9ce7, 0x2)) goto l_0x100c_9ce7; /* jnz 0x100c9ce7 */
        l_0x100c_9ce5:
            ii(0x100c_9ce5, 2); jmpd(0x100c_9cfb, 0x14); goto l_0x100c_9cfb; /* jmp 0x100c9cfb */
        l_0x100c_9ce7:
            ii(0x100c_9ce7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9cea, 5); calld(0x1007_63a0, -0x5_394f);          /* call 0x100763a0 */
            ii(0x100c_9cef, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100c_9cf2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9cf7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9cf9, 2); if(jgd(0x100c_9cfd, 0x2)) goto l_0x100c_9cfd; /* jg 0x100c9cfd */
        l_0x100c_9cfb:
            ii(0x100c_9cfb, 2); jmpd(0x100c_9d1d, 0x20); goto l_0x100c_9d1d; /* jmp 0x100c9d1d */
        l_0x100c_9cfd:
            ii(0x100c_9cfd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_9d00, 3); mov(edx, memd_a32[ds, edx + 0x6]);      /* mov edx, [edx+0x6] */
            ii(0x100c_9d03, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9d06, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d09, 5); calld(0x1007_63a0, -0x5_396e);          /* call 0x100763a0 */
            ii(0x100c_9d0e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_9d11, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9d14, 5); calld(0x1007_49d4, -0x5_5345);          /* call 0x100749d4 */
            ii(0x100c_9d19, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9d1b, 2); if(jnzd(0x100c_9d1f, 0x2)) goto l_0x100c_9d1f; /* jnz 0x100c9d1f */
        l_0x100c_9d1d:
            ii(0x100c_9d1d, 2); jmpd(0x100c_9d31, 0x12); goto l_0x100c_9d31; /* jmp 0x100c9d31 */
        l_0x100c_9d1f:
            ii(0x100c_9d1f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d22, 5); calld(0x1007_63d4, -0x5_3953);          /* call 0x100763d4 */
            ii(0x100c_9d27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9d29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_9d2c, 5); calld(0x100c_993c, -0x3f5);             /* call 0x100c993c */
        l_0x100c_9d31:
            ii(0x100c_9d31, 5); jmpd(0x100c_9c68, -0xce); goto l_0x100c_9c68; /* jmp 0x100c9c68 */
        l_0x100c_9d36:
            ii(0x100c_9d36, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100c_9d3b, 5); calld(0x1007_6338, -0x5_3a08);          /* call 0x10076338 */
            ii(0x100c_9d40, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100c_9d43, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9d45, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_9d47, 5); calld(0x1007_643c, -0x5_3910);          /* call 0x1007643c */
            ii(0x100c_9d4c, 2); jmpd(0x100c_9d56, 0x8); goto l_0x100c_9d56; /* jmp 0x100c9d56 */
        l_0x100c_9d4e:
            ii(0x100c_9d4e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d51, 5); calld(0x1007_6bf8, -0x5_315e);          /* call 0x10076bf8 */
        l_0x100c_9d56:
            ii(0x100c_9d56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9d58, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d5b, 5); calld(0x1013_ad71, 0x7_1011);           /* call 0x1013ad71 */
            ii(0x100c_9d60, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9d62, 6); if(jzd(0x100c_9e1c, 0xb4)) goto l_0x100c_9e1c; /* jz 0x100c9e1c */
            ii(0x100c_9d68, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d6b, 5); calld(0x1007_63a0, -0x5_39d0);          /* call 0x100763a0 */
            ii(0x100c_9d70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9d72, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_9d75, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_9d79, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9d7b, 2); if(jzd(0x100c_9d92, 0x15)) goto l_0x100c_9d92; /* jz 0x100c9d92 */
            ii(0x100c_9d7d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100c_9d81, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d84, 5); calld(0x1007_63a0, -0x5_39e9);          /* call 0x100763a0 */
            ii(0x100c_9d89, 5); calld(0x1007_6074, -0x5_3d1a);          /* call 0x10076074 */
            ii(0x100c_9d8e, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9d90, 2); if(jnzd(0x100c_9d94, 0x2)) goto l_0x100c_9d94; /* jnz 0x100c9d94 */
        l_0x100c_9d92:
            ii(0x100c_9d92, 2); jmpd(0x100c_9dab, 0x17); goto l_0x100c_9dab; /* jmp 0x100c9dab */
        l_0x100c_9d94:
            ii(0x100c_9d94, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9d97, 5); calld(0x1007_63a0, -0x5_39fc);          /* call 0x100763a0 */
            ii(0x100c_9d9c, 5); calld(0x1007_623c, -0x5_3b65);          /* call 0x1007623c */
            ii(0x100c_9da1, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_9da4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9da7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9da9, 2); if(jgd(0x100c_9dad, 0x2)) goto l_0x100c_9dad; /* jg 0x100c9dad */
        l_0x100c_9dab:
            ii(0x100c_9dab, 2); jmpd(0x100c_9dbb, 0xe); goto l_0x100c_9dbb; /* jmp 0x100c9dbb */
        l_0x100c_9dad:
            ii(0x100c_9dad, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9db0, 5); calld(0x1007_63a0, -0x5_3a15);          /* call 0x100763a0 */
            ii(0x100c_9db5, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_9db9, 2); if(jnzd(0x100c_9dbd, 0x2)) goto l_0x100c_9dbd; /* jnz 0x100c9dbd */
        l_0x100c_9dbb:
            ii(0x100c_9dbb, 2); jmpd(0x100c_9dcb, 0xe); goto l_0x100c_9dcb; /* jmp 0x100c9dcb */
        l_0x100c_9dbd:
            ii(0x100c_9dbd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9dc0, 5); calld(0x1007_63a0, -0x5_3a25);          /* call 0x100763a0 */
            ii(0x100c_9dc5, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_9dc9, 2); if(jnzd(0x100c_9dcd, 0x2)) goto l_0x100c_9dcd; /* jnz 0x100c9dcd */
        l_0x100c_9dcb:
            ii(0x100c_9dcb, 2); jmpd(0x100c_9de1, 0x14); goto l_0x100c_9de1; /* jmp 0x100c9de1 */
        l_0x100c_9dcd:
            ii(0x100c_9dcd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9dd0, 5); calld(0x1007_63a0, -0x5_3a35);          /* call 0x100763a0 */
            ii(0x100c_9dd5, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100c_9dd8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9ddd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9ddf, 2); if(jgd(0x100c_9de3, 0x2)) goto l_0x100c_9de3; /* jg 0x100c9de3 */
        l_0x100c_9de1:
            ii(0x100c_9de1, 2); jmpd(0x100c_9e03, 0x20); goto l_0x100c_9e03; /* jmp 0x100c9e03 */
        l_0x100c_9de3:
            ii(0x100c_9de3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_9de6, 3); mov(edx, memd_a32[ds, edx + 0x6]);      /* mov edx, [edx+0x6] */
            ii(0x100c_9de9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9dec, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9def, 5); calld(0x1007_63a0, -0x5_3a54);          /* call 0x100763a0 */
            ii(0x100c_9df4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_9df7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9dfa, 5); calld(0x1007_49d4, -0x5_542b);          /* call 0x100749d4 */
            ii(0x100c_9dff, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9e01, 2); if(jnzd(0x100c_9e05, 0x2)) goto l_0x100c_9e05; /* jnz 0x100c9e05 */
        l_0x100c_9e03:
            ii(0x100c_9e03, 2); jmpd(0x100c_9e17, 0x12); goto l_0x100c_9e17; /* jmp 0x100c9e17 */
        l_0x100c_9e05:
            ii(0x100c_9e05, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9e08, 5); calld(0x1007_63d4, -0x5_3a39);          /* call 0x100763d4 */
            ii(0x100c_9e0d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9e0f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_9e12, 5); calld(0x100c_993c, -0x4db);             /* call 0x100c993c */
        l_0x100c_9e17:
            ii(0x100c_9e17, 5); jmpd(0x100c_9d4e, -0xce); goto l_0x100c_9d4e; /* jmp 0x100c9d4e */
        l_0x100c_9e1c:
            ii(0x100c_9e1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9e1e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_9e21, 5); calld(0x1007_5f6c, -0x5_3eba);          /* call 0x10075f6c */
            ii(0x100c_9e26, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9e28, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_9e29, 1); popd(edi);                              /* pop edi */
            ii(0x100c_9e2a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_9e2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_9e2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_9e2d, 1); retd(); return;                         /* ret */
        }
    }
}
