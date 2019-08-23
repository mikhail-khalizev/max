using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_e36c-52f69792")]
        public void /* sys */ Method_1016_e36c()
        {
            ii(0x1016_e36c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_e36d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_e36e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_e36f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_e370, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_e372, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e374, 6); if(jzd(0x1016_e3f1, 0x77)) goto l_0x1016_e3f1; /* jz 0x1016e3f1 */
            ii(0x1016_e37a, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_e37d, 6); if(jzd(0x1016_e3f1, 0x6e)) goto l_0x1016_e3f1; /* jz 0x1016e3f1 */
            ii(0x1016_e383, 6); mov(esi, memd_a32[ds, 0x1020_88b8]);    /* mov esi, [0x102088b8] */
            ii(0x1016_e389, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_e38b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_e38d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_e38f, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1016_e391, 2); if(jnzd(0x1016_e3de, 0x4b)) goto l_0x1016_e3de; /* jnz 0x1016e3de */
        l_0x1016_e393:
            ii(0x1016_e393, 6); cmp(ebx, memd_a32[ds, 0x101b_e1c0]);    /* cmp ebx, [0x101be1c0] */
            ii(0x1016_e399, 2); if(jnzd(0x1016_e3a2, 0x7)) goto l_0x1016_e3a2; /* jnz 0x1016e3a2 */
            ii(0x1016_e39b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_e39d, 5); mov(memd_a32[ds, 0x101b_e1c0], eax);    /* mov [0x101be1c0], eax */
        l_0x1016_e3a2:
            ii(0x1016_e3a2, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_e3a5, 6); mov(eax, memd_a32[ds, edx + 0x1020_88b8]); /* mov eax, [edx+0x102088b8] */
            ii(0x1016_e3ab, 5); calld(/* sys */ 0x1017_0bfc, 0x284c);   /* call 0x10170bfc */
            ii(0x1016_e3b0, 6); mov(eax, memd_a32[ds, edx + 0x1020_88b8]); /* mov eax, [edx+0x102088b8] */
            ii(0x1016_e3b6, 5); calld(/* sys */ 0x1017_0d2c, 0x2971);   /* call 0x10170d2c */
            ii(0x1016_e3bb, 6); add(edx, 0x1020_88b8);                  /* add edx, 0x102088b8 */
            ii(0x1016_e3c1, 2); if(jzd(0x1016_e3d7, 0x14)) goto l_0x1016_e3d7; /* jz 0x1016e3d7 */
            ii(0x1016_e3c3, 2); mov(ebx, memd_a32[ds, edx]);            /* mov ebx, [edx] */
            ii(0x1016_e3c5, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_e3c7, 2); if(jzd(0x1016_e3d7, 0xe)) goto l_0x1016_e3d7; /* jz 0x1016e3d7 */
            ii(0x1016_e3c9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_e3cb, 6); calld_abs(memd_a32[ds, 0x101b_e1d0]);   /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
            ii(0x1016_e3d1, 6); mov(memd_a32[ds, edx], 0);              /* mov dword [edx], 0x0 */
        l_0x1016_e3d7:
            ii(0x1016_e3d7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_e3d9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_e3da, 1); popd(edx);                              /* pop edx */
            ii(0x1016_e3db, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_e3dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_e3dd, 1); retd(); return;                         /* ret */
        l_0x1016_e3de:
            ii(0x1016_e3de, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_e3e1, 1); inc(edx);                               /* inc edx */
            ii(0x1016_e3e2, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1016_e3e5, 2); if(jged(0x1016_e3f1, 0xa)) goto l_0x1016_e3f1; /* jge 0x1016e3f1 */
            ii(0x1016_e3e7, 6); cmp(ebx, memd_a32[ds, eax + 0x1020_88b8]); /* cmp ebx, [eax+0x102088b8] */
            ii(0x1016_e3ed, 2); if(jzd(0x1016_e393, -0x5c)) goto l_0x1016_e393; /* jz 0x1016e393 */
            ii(0x1016_e3ef, 2); jmpd(0x1016_e3de, -0x13); goto l_0x1016_e3de; /* jmp 0x1016e3de */
        l_0x1016_e3f1:
            ii(0x1016_e3f1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_e3f6, 1); popd(esi);                              /* pop esi */
            ii(0x1016_e3f7, 1); popd(edx);                              /* pop edx */
            ii(0x1016_e3f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_e3f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_e3fa, 1); retd();                                 /* ret */
        }
    }
}
