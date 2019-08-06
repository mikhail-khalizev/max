using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("41653ed1-0e50-401b-871c-be27be692898")]
        public void Method_100a_1c16()
        {
            ii(0x100a_1c16, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_1c1b, 5); calld(Definitions.sys_check_available_stack_size, 0xc4132); /* call 0x10165d52 */
            ii(0x100a_1c20, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_1c21, 1); pushd(esi);                             /* push esi */
            ii(0x100a_1c22, 1); pushd(edi);                             /* push edi */
            ii(0x100a_1c23, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_1c24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1c26, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_1c2c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_1c2f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_1c32, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_1c35, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_1c39, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1c3c, 5); calld(0x1007_64fc, -0x2b745);           /* call 0x100764fc */
            ii(0x100a_1c41, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_1c44, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_1c48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1c4a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1c4d, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1c50, 5); calld(0x1013_ad71, 0x9911c);            /* call 0x1013ad71 */
            ii(0x100a_1c55, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1c57, 2); if(jzd(0x100a_1c6e, 0x15)) goto l_0x100a_1c6e; /* jz 0x100a1c6e */
            ii(0x100a_1c59, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1c5c, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1c5f, 5); calld(0x1007_6574, -0x2b6f0);           /* call 0x10076574 */
            ii(0x100a_1c64, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100a_1c68, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100a_1c6c, 2); if(jzd(0x100a_1c70, 0x2)) goto l_0x100a_1c70; /* jz 0x100a1c70 */
        l_0x100a_1c6e:
            ii(0x100a_1c6e, 2); jmpd(0x100a_1c90, 0x20); goto l_0x100a_1c90; /* jmp 0x100a1c90 */
        l_0x100a_1c70:
            ii(0x100a_1c70, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1c72, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100a_1c75, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1c78, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1c7b, 5); calld(0x1007_6600, -0x2b680);           /* call 0x10076600 */
            ii(0x100a_1c80, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100a_1c83, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1c85, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_1c87, 5); calld(0x100a_1984, -0x308);             /* call 0x100a1984 */
            ii(0x100a_1c8c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1c8e, 2); if(jnzd(0x100a_1c92, 0x2)) goto l_0x100a_1c92; /* jnz 0x100a1c92 */
        l_0x100a_1c90:
            ii(0x100a_1c90, 2); jmpd(0x100a_1ca8, 0x16); goto l_0x100a_1ca8; /* jmp 0x100a1ca8 */
        l_0x100a_1c92:
            ii(0x100a_1c92, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100a_1c99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1c9b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1c9e, 5); calld(0x1007_5f6c, -0x2bd37);           /* call 0x10075f6c */
            ii(0x100a_1ca3, 5); jmpd(0x100a_1d37, 0x8f); goto l_0x100a_1d37; /* jmp 0x100a1d37 */
        l_0x100a_1ca8:
            ii(0x100a_1ca8, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_1cad, 5); calld(0x1007_6338, -0x2b97a);           /* call 0x10076338 */
            ii(0x100a_1cb2, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100a_1cb5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1cb7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_1cb9, 5); calld(0x1007_643c, -0x2b882);           /* call 0x1007643c */
        l_0x100a_1cbe:
            ii(0x100a_1cbe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1cc0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1cc3, 5); calld(0x1013_ad71, 0x990a9);            /* call 0x1013ad71 */
            ii(0x100a_1cc8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1cca, 2); if(jzd(0x100a_1d1a, 0x4e)) goto l_0x100a_1d1a; /* jz 0x100a1d1a */
            ii(0x100a_1ccc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1ccf, 5); calld(0x1007_63a0, -0x2b934);           /* call 0x100763a0 */
            ii(0x100a_1cd4, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100a_1cd8, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100a_1cdc, 2); if(jnzd(0x100a_1cfb, 0x1d)) goto l_0x100a_1cfb; /* jnz 0x100a1cfb */
            ii(0x100a_1cde, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1ce0, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100a_1ce3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1ce6, 5); calld(0x1007_6408, -0x2b8e3);           /* call 0x10076408 */
            ii(0x100a_1ceb, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100a_1cee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1cf0, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_1cf2, 5); calld(0x100a_1984, -0x373);             /* call 0x100a1984 */
            ii(0x100a_1cf7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1cf9, 2); if(jnzd(0x100a_1cfd, 0x2)) goto l_0x100a_1cfd; /* jnz 0x100a1cfd */
        l_0x100a_1cfb:
            ii(0x100a_1cfb, 2); jmpd(0x100a_1d10, 0x13); goto l_0x100a_1d10; /* jmp 0x100a1d10 */
        l_0x100a_1cfd:
            ii(0x100a_1cfd, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100a_1d04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1d06, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1d09, 5); calld(0x1007_5f6c, -0x2bda2);           /* call 0x10075f6c */
            ii(0x100a_1d0e, 2); jmpd(0x100a_1d37, 0x27); goto l_0x100a_1d37; /* jmp 0x100a1d37 */
        l_0x100a_1d10:
            ii(0x100a_1d10, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1d13, 5); calld(0x1007_6bf8, -0x2b120);           /* call 0x10076bf8 */
            ii(0x100a_1d18, 2); jmpd(0x100a_1cbe, -0x5c); goto l_0x100a_1cbe; /* jmp 0x100a1cbe */
        l_0x100a_1d1a:
            ii(0x100a_1d1a, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_1d21, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1d23, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_1d26, 5); calld(0x1007_5f6c, -0x2bdbf);           /* call 0x10075f6c */
            ii(0x100a_1d2b, 2); jmpd(0x100a_1d37, 0xa); goto l_0x100a_1d37; /* jmp 0x100a1d37 */
        //  ii(0x100a_1d2d, 10); Недостижимый код.
        l_0x100a_1d37:
            ii(0x100a_1d37, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_1d3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1d3c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_1d3d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_1d3e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_1d3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_1d40, 1); retd(); return;                         /* ret */
        }
    }
}
