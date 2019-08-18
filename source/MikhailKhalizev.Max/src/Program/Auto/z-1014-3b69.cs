using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_3b69-31bf8b12")]
        public void Method_1014_3b69()
        {
            ii(0x1014_3b69, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_3b6e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_21df); /* call 0x10165d52 */
            ii(0x1014_3b73, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_3b74, 1); pushd(esi);                             /* push esi */
            ii(0x1014_3b75, 1); pushd(edi);                             /* push edi */
            ii(0x1014_3b76, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_3b77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_3b79, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_3b7f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_3b82, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_3b85, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_3b88, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_3b8c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3b8f, 5); calld(0x1007_64fc, -0xc_d698);          /* call 0x100764fc */
            ii(0x1014_3b94, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_3b97, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_3b9b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_3ba0, 5); calld(0x1007_6338, -0xc_d86d);          /* call 0x10076338 */
            ii(0x1014_3ba5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3ba7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3baa, 5); calld(0x1007_643c, -0xc_d773);          /* call 0x1007643c */
        l_0x1014_3baf:
            ii(0x1014_3baf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3bb1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3bb4, 5); calld(0x1013_ad71, -0x8e48);            /* call 0x1013ad71 */
            ii(0x1014_3bb9, 2); test(al, al);                           /* test al, al */
            ii(0x1014_3bbb, 6); if(jzd(0x1014_3cdb, 0x11a)) goto l_0x1014_3cdb; /* jz 0x10143cdb */
            ii(0x1014_3bc1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3bc4, 5); calld(0x1007_63a0, -0xc_d829);          /* call 0x100763a0 */
            ii(0x1014_3bc9, 5); calld(0x1007_6204, -0xc_d9ca);          /* call 0x10076204 */
            ii(0x1014_3bce, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1014_3bd1, 2); if(jnzd(0x1014_3be2, 0xf)) goto l_0x1014_3be2; /* jnz 0x10143be2 */
            ii(0x1014_3bd3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3bd6, 5); calld(0x1007_63a0, -0xc_d83b);          /* call 0x100763a0 */
            ii(0x1014_3bdb, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1014_3be0, 2); if(jzd(0x1014_3be4, 0x2)) goto l_0x1014_3be4; /* jz 0x10143be4 */
        l_0x1014_3be2:
            ii(0x1014_3be2, 2); jmpd(0x1014_3bf2, 0xe); goto l_0x1014_3bf2; /* jmp 0x10143bf2 */
        l_0x1014_3be4:
            ii(0x1014_3be4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3be7, 5); calld(0x1007_63a0, -0xc_d84c);          /* call 0x100763a0 */
            ii(0x1014_3bec, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1014_3bf0, 2); if(jnzd(0x1014_3bf4, 0x2)) goto l_0x1014_3bf4; /* jnz 0x10143bf4 */
        l_0x1014_3bf2:
            ii(0x1014_3bf2, 2); jmpd(0x1014_3c02, 0xe); goto l_0x1014_3c02; /* jmp 0x10143c02 */
        l_0x1014_3bf4:
            ii(0x1014_3bf4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3bf7, 5); calld(0x1007_63a0, -0xc_d85c);          /* call 0x100763a0 */
            ii(0x1014_3bfc, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1014_3c00, 2); if(jnzd(0x1014_3c04, 0x2)) goto l_0x1014_3c04; /* jnz 0x10143c04 */
        l_0x1014_3c02:
            ii(0x1014_3c02, 2); jmpd(0x1014_3c12, 0xe); goto l_0x1014_3c12; /* jmp 0x10143c12 */
        l_0x1014_3c04:
            ii(0x1014_3c04, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c07, 5); calld(0x1007_63a0, -0xc_d86c);          /* call 0x100763a0 */
            ii(0x1014_3c0c, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1014_3c10, 2); if(jnzd(0x1014_3c17, 0x5)) goto l_0x1014_3c17; /* jnz 0x10143c17 */
        l_0x1014_3c12:
            ii(0x1014_3c12, 5); jmpd(0x1014_3cce, 0xb7); goto l_0x1014_3cce; /* jmp 0x10143cce */
        l_0x1014_3c17:
            ii(0x1014_3c17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_3c1a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_3c1d, 2); jmpd(0x1014_3c51, 0x32); goto l_0x1014_3c51; /* jmp 0x10143c51 */
        l_0x1014_3c1f:
            ii(0x1014_3c1f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c22, 5); calld(0x1007_63a0, -0xc_d887);          /* call 0x100763a0 */
            ii(0x1014_3c27, 3); add(eax, 0x47);                         /* add eax, 0x47 */
            ii(0x1014_3c2a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_3c2d, 2); jmpd(0x1014_3c70, 0x41); goto l_0x1014_3c70; /* jmp 0x10143c70 */
        l_0x1014_3c2f:
            ii(0x1014_3c2f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c32, 5); calld(0x1007_63a0, -0xc_d897);          /* call 0x100763a0 */
            ii(0x1014_3c37, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x1014_3c3a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_3c3d, 2); jmpd(0x1014_3c70, 0x31); goto l_0x1014_3c70; /* jmp 0x10143c70 */
        l_0x1014_3c3f:
            ii(0x1014_3c3f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c42, 5); calld(0x1007_63a0, -0xc_d8a7);          /* call 0x100763a0 */
            ii(0x1014_3c47, 3); add(eax, 0x49);                         /* add eax, 0x49 */
            ii(0x1014_3c4a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_3c4d, 2); jmpd(0x1014_3c70, 0x21); goto l_0x1014_3c70; /* jmp 0x10143c70 */
        l_0x1014_3c4f:
            ii(0x1014_3c4f, 2); jmpd(0x1014_3c70, 0x1f); goto l_0x1014_3c70; /* jmp 0x10143c70 */
        l_0x1014_3c51:
            ii(0x1014_3c51, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x40);    /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x1014_3c55, 2); if(jbd(0x1014_3c68, 0x11)) goto l_0x1014_3c68; /* jb 0x10143c68 */
            ii(0x1014_3c57, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x40);    /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x1014_3c5b, 2); if(jbed(0x1014_3c3f, -0x1e)) goto l_0x1014_3c3f; /* jbe 0x10143c3f */
            ii(0x1014_3c5d, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x80);    /* cmp dword [ebp-0x1c], 0x80 */
            ii(0x1014_3c64, 2); if(jzd(0x1014_3c1f, -0x47)) goto l_0x1014_3c1f; /* jz 0x10143c1f */
            ii(0x1014_3c66, 2); jmpd(0x1014_3c4f, -0x19); goto l_0x1014_3c4f; /* jmp 0x10143c4f */
        l_0x1014_3c68:
            ii(0x1014_3c68, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x20);    /* cmp dword [ebp-0x1c], 0x20 */
            ii(0x1014_3c6c, 2); if(jzd(0x1014_3c2f, -0x3f)) goto l_0x1014_3c2f; /* jz 0x10143c2f */
            ii(0x1014_3c6e, 2); jmpd(0x1014_3c4f, -0x21); goto l_0x1014_3c4f; /* jmp 0x10143c4f */
        l_0x1014_3c70:
            ii(0x1014_3c70, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_3c73, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_3c75, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3c7a, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1014_3c7d, 2); if(jld(0x1014_3ca3, 0x24)) goto l_0x1014_3ca3; /* jl 0x10143ca3 */
            ii(0x1014_3c7f, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1014_3c82, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_3c85, 2); sub(memb_a32[ds, edx], al);             /* sub [edx], al */
            ii(0x1014_3c87, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c8a, 5); calld(0x1007_63a0, -0xc_d8ef);          /* call 0x100763a0 */
            ii(0x1014_3c8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3c91, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1014_3c94, 3); sub(memb_a32[ds, edx + 0x46], al);      /* sub [edx+0x46], al */
            ii(0x1014_3c97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3c99, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3c9c, 5); calld(0x1007_5f6c, -0xc_dd35);          /* call 0x10075f6c */
            ii(0x1014_3ca1, 2); jmpd(0x1014_3ce5, 0x42); goto l_0x1014_3ce5; /* jmp 0x10143ce5 */
        l_0x1014_3ca3:
            ii(0x1014_3ca3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_3ca6, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1014_3ca9, 2); if(jzd(0x1014_3cce, 0x23)) goto l_0x1014_3cce; /* jz 0x10143cce */
            ii(0x1014_3cab, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_3cae, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_3cb0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3cb5, 3); sub(memd_a32[ss, ebp - 0x4], eax);      /* sub [ebp-0x4], eax */
            ii(0x1014_3cb8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3cbb, 5); calld(0x1007_63a0, -0xc_d920);          /* call 0x100763a0 */
            ii(0x1014_3cc0, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_3cc3, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1014_3cc5, 3); sub(memb_a32[ds, eax + 0x46], dl);      /* sub [eax+0x46], dl */
            ii(0x1014_3cc8, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_3ccb, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1014_3cce:
            ii(0x1014_3cce, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3cd1, 5); calld(0x1007_6bf8, -0xc_d0de);          /* call 0x10076bf8 */
            ii(0x1014_3cd6, 5); jmpd(0x1014_3baf, -0x12c); goto l_0x1014_3baf; /* jmp 0x10143baf */
        l_0x1014_3cdb:
            ii(0x1014_3cdb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3cdd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3ce0, 5); calld(0x1007_5f6c, -0xc_dd79);          /* call 0x10075f6c */
        l_0x1014_3ce5:
            ii(0x1014_3ce5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3ce7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_3ce8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_3ce9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_3cea, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_3ceb, 1); retd(); return;                         /* ret */
        }
    }
}
