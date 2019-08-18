using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_0c8c-12a0c2b6")]
        public void /* sys */ Method_1017_0c8c()
        {
            ii(0x1017_0c8c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_0c8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_0c8e, 1); pushd(esi);                             /* push esi */
            ii(0x1017_0c8f, 1); pushd(edi);                             /* push edi */
            ii(0x1017_0c90, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_0c92, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0c94, 6); if(jzd(0x1017_0d1f, 0x85)) goto l_0x1017_0d1f; /* jz 0x10170d1f */
            ii(0x1017_0c9a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_0c9c, 2); if(jnzd(0x1017_0ca6, 0x8)) goto l_0x1017_0ca6; /* jnz 0x10170ca6 */
            ii(0x1017_0c9e, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x1017_0ca1, 5); jmpd(0x1017_0d18, 0x72); goto l_0x1017_0d18; /* jmp 0x10170d18 */
        l_0x1017_0ca6:
            ii(0x1017_0ca6, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_0ca8, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1017_0caa, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_0cab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_0cad, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_0caf, 2); not(ecx);                               /* not ecx */
            ii(0x1017_0cb1, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_0cb2, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_0cb4, 2); if(jzd(0x1017_0d11, 0x5b)) goto l_0x1017_0d11; /* jz 0x10170d11 */
            ii(0x1017_0cb6, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1017_0cbb, 3); lea(eax, ecx + 0x2);                    /* lea eax, [ecx+0x2] */
            ii(0x1017_0cbe, 6); mov(memd_a32[ds, 0x101b_e1c4], esi);    /* mov [0x101be1c4], esi */
            ii(0x1017_0cc4, 6); calld_abs(memd_a32[ds, 0x101b_e1c8]);   /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1017_0cca, 3); mov(memd_a32[ds, ebx + 0xc], eax);      /* mov [ebx+0xc], eax */
            ii(0x1017_0ccd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0ccf, 2); if(jzd(0x1017_0d1f, 0x4e)) goto l_0x1017_0d1f; /* jz 0x10170d1f */
            ii(0x1017_0cd1, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_0cd3, 3); mov(edi, memd_a32[ds, ebx + 0xc]);      /* mov edi, [ebx+0xc] */
            ii(0x1017_0cd6, 4); mov(memb_a32[ds, ebx + 0x10], 0x1);     /* mov byte [ebx+0x10], 0x1 */
            ii(0x1017_0cda, 1); pushd(edi);                             /* push edi */
        l_0x1017_0cdb:
            ii(0x1017_0cdb, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_0cdd, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1017_0cdf, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_0ce1, 2); if(jzd(0x1017_0cf3, 0x10)) goto l_0x1017_0cf3; /* jz 0x10170cf3 */
            ii(0x1017_0ce3, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1017_0ce6, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1017_0ce9, 3); mov(memb_a32[ds, edi + 0x1], al);       /* mov [edi+0x1], al */
            ii(0x1017_0cec, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1017_0cef, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_0cf1, 2); if(jnzd(0x1017_0cdb, -0x18)) goto l_0x1017_0cdb; /* jnz 0x10170cdb */
        l_0x1017_0cf3:
            ii(0x1017_0cf3, 1); popd(edi);                              /* pop edi */
            ii(0x1017_0cf4, 3); mov(eax, memd_a32[ds, ebx + 0xc]);      /* mov eax, [ebx+0xc] */
            ii(0x1017_0cf7, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_0cf9, 4); cmp(memb_a32[ds, eax - 0x1], 0x5c);     /* cmp byte [eax-0x1], 0x5c */
            ii(0x1017_0cfd, 2); if(jzd(0x1017_0d18, 0x19)) goto l_0x1017_0d18; /* jz 0x10170d18 */
            ii(0x1017_0cff, 3); mov(memb_a32[ds, eax], 0x5c);           /* mov byte [eax], 0x5c */
            ii(0x1017_0d02, 3); mov(eax, memd_a32[ds, ebx + 0xc]);      /* mov eax, [ebx+0xc] */
            ii(0x1017_0d05, 5); mov(memb_a32[ds, ecx + eax + 0x1], 0);  /* mov byte [ecx+eax+0x1], 0x0 */
            ii(0x1017_0d0a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_0d0c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_0d0d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_0d0e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_0d0f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_0d10, 1); retd(); return;                         /* ret */
        l_0x1017_0d11:
            ii(0x1017_0d11, 7); mov(memd_a32[ds, ebx + 0xc], StringDefinitions.Empty3); /* mov dword [ebx+0xc], 0x101b2f00 */
        l_0x1017_0d18:
            ii(0x1017_0d18, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_0d1a, 1); popd(edi);                              /* pop edi */
            ii(0x1017_0d1b, 1); popd(esi);                              /* pop esi */
            ii(0x1017_0d1c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_0d1d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_0d1e, 1); retd(); return;                         /* ret */
        l_0x1017_0d1f:
            ii(0x1017_0d1f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_0d24, 1); popd(edi);                              /* pop edi */
            ii(0x1017_0d25, 1); popd(esi);                              /* pop esi */
            ii(0x1017_0d26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_0d27, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_0d28, 1); retd(); return;                         /* ret */
        }
    }
}
