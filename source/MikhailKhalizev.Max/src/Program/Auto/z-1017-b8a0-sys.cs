using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_b8a0-8fbd443a")]
        public void /* sys */ Method_1017_b8a0()
        {
            ii(0x1017_b8a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_b8a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b8a3, 1); pushd(esi);                             /* push esi */
            ii(0x1017_b8a4, 1); pushd(edi);                             /* push edi */
            ii(0x1017_b8a5, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1017_b8a8, 3); mov(ecx, memd_a32[ss, ebp + 0x14]);     /* mov ecx, [ebp+0x14] */
            ii(0x1017_b8ab, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1017_b8ae, 6); mov(memd_a32[ds, 0x1020_9c84], edx);    /* mov [0x10209c84], edx */
            ii(0x1017_b8b4, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1017_b8b7, 6); mov(memd_a32[ds, 0x1020_9c88], edx);    /* mov [0x10209c88], edx */
            ii(0x1017_b8bd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_b8c2, 2); shl(edx, cl);                           /* shl edx, cl */
            ii(0x1017_b8c4, 6); mov(memd_a32[ds, 0x1020_9c80], edx);    /* mov [0x10209c80], edx */
            ii(0x1017_b8ca, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_b8cc, 2); if(jnzd(0x1017_b8d8, 0xa)) goto l_0x1017_b8d8; /* jnz 0x1017b8d8 */
            ii(0x1017_b8ce, 10); mov(memd_a32[ds, 0x1020_9c80], 0x1);   /* mov dword [0x10209c80], 0x1 */
        l_0x1017_b8d8:
            ii(0x1017_b8d8, 5); calld(/* sys */ 0x1017_98b0, -0x202d);  /* call 0x101798b0 */
            ii(0x1017_b8dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b8df, 2); if(jnzd(0x1017_b90b, 0x2a)) goto l_0x1017_b90b; /* jnz 0x1017b90b */
            ii(0x1017_b8e1, 7); cmp(memd_a32[ds, 0x101b_e458], 0);      /* cmp dword [0x101be458], 0x0 */
            ii(0x1017_b8e8, 2); if(jzd(0x1017_b901, 0x17)) goto l_0x1017_b901; /* jz 0x1017b901 */
            ii(0x1017_b8ea, 5); calld(/* sys */ 0x1017_97f0, -0x20ff);  /* call 0x101797f0 */
            ii(0x1017_b8ef, 5); calld(/* sys */ 0x1017_9650, -0x22a4);  /* call 0x10179650 */
            ii(0x1017_b8f4, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_b8f6, 5); calld(/* sys */ 0x1017_9cb0, -0x1c4b);  /* call 0x10179cb0 */
            ii(0x1017_b8fb, 6); mov(memd_a32[ds, 0x101b_e458], edi);    /* mov [0x101be458], edi */
        l_0x1017_b901:
            ii(0x1017_b901, 5); mov(eax, 0xffff_fff8);                  /* mov eax, 0xfffffff8 */
            ii(0x1017_b906, 5); jmpd(0x1017_b98b, 0x80); goto l_0x1017_b98b; /* jmp 0x1017b98b */
        l_0x1017_b90b:
            ii(0x1017_b90b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b90d, 6); mov(ax, memw_a32[ds, 0x1020_9db4]);     /* mov ax, [0x10209db4] */
            ii(0x1017_b913, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_b916, 5); calld(/* sys */ 0x1017_9970, -0x1fab);  /* call 0x10179970 */
            ii(0x1017_b91b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b91d, 2); if(jzd(0x1017_b931, 0x12)) goto l_0x1017_b931; /* jz 0x1017b931 */
            ii(0x1017_b91f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b921, 7); mov(dx, memw_a32[ds, 0x1020_9db4]);     /* mov dx, [0x10209db4] */
            ii(0x1017_b928, 3); mov(edx, memd_a32[ds, edx + eax]);      /* mov edx, [edx+eax] */
            ii(0x1017_b92b, 6); mov(memd_a32[ds, 0x1020_9db4], edx);    /* mov [0x10209db4], edx */
        l_0x1017_b931:
            ii(0x1017_b931, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b933, 5); mov(memd_a32[ds, 0x1020_9c70], eax);    /* mov [0x10209c70], eax */
            ii(0x1017_b938, 6); mov(memd_a32[ds, 0x1020_9c74], ecx);    /* mov [0x10209c74], ecx */
            ii(0x1017_b93e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b940, 2); if(jnzd(0x1017_b96c, 0x2a)) goto l_0x1017_b96c; /* jnz 0x1017b96c */
            ii(0x1017_b942, 7); cmp(memd_a32[ds, 0x101b_e458], 0);      /* cmp dword [0x101be458], 0x0 */
            ii(0x1017_b949, 2); if(jzd(0x1017_b960, 0x15)) goto l_0x1017_b960; /* jz 0x1017b960 */
            ii(0x1017_b94b, 5); calld(/* sys */ 0x1017_97f0, -0x2160);  /* call 0x101797f0 */
            ii(0x1017_b950, 5); calld(/* sys */ 0x1017_9650, -0x2305);  /* call 0x10179650 */
            ii(0x1017_b955, 5); calld(/* sys */ 0x1017_9cb0, -0x1caa);  /* call 0x10179cb0 */
            ii(0x1017_b95a, 6); mov(memd_a32[ds, 0x101b_e458], ecx);    /* mov [0x101be458], ecx */
        l_0x1017_b960:
            ii(0x1017_b960, 5); mov(eax, 0xffff_fffe);                  /* mov eax, 0xfffffffe */
            ii(0x1017_b965, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_b968, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b969, 1); popd(esi);                              /* pop esi */
            ii(0x1017_b96a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b96b, 1); retd(); return;                         /* ret */
        l_0x1017_b96c:
            ii(0x1017_b96c, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1017_b971, 6); mov(memd_a32[ds, 0x101b_e454], ecx);    /* mov [0x101be454], ecx */
            ii(0x1017_b977, 6); mov(memd_a32[ds, 0x1020_9c7c], ecx);    /* mov [0x10209c7c], ecx */
            ii(0x1017_b97d, 6); mov(memd_a32[ds, 0x1020_9c78], ecx);    /* mov [0x10209c78], ecx */
            ii(0x1017_b983, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b985, 6); mov(memd_a32[ds, 0x101b_e458], esi);    /* mov [0x101be458], esi */
        l_0x1017_b98b:
            ii(0x1017_b98b, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_b98e, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b98f, 1); popd(esi);                              /* pop esi */
            ii(0x1017_b990, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b991, 1); retd();                                 /* ret */
        }
    }
}
