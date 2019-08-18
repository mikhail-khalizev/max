using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3b92-6075fd06")]
        public void /* sys */ Method_1019_3b92()
        {
            ii(0x1019_3b92, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_3b93, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3b94, 1); pushd(edx);                             /* push edx */
            ii(0x1019_3b95, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3b97, 3); shl(ecx, 0x2);                          /* shl ecx, 0x2 */
            ii(0x1019_3b9a, 2); neg(ecx);                               /* neg ecx */
            ii(0x1019_3b9c, 3); mov(memd_a32[ss, ebp - 0x2c], ecx);     /* mov [ebp-0x2c], ecx */
            ii(0x1019_3b9f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1019_3ba2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1019_3ba5, 6); sub(edi, memd_a32[ds, Definitions.video_win_start]); /* sub edi, [0x10209ca8] */
            ii(0x1019_3bab, 5); mov(ecx, /* sys */ 0x1019_3c65);        /* mov ecx, 0x10193c65 */
            ii(0x1019_3bb0, 6); if(jnsd(0x1019_3c3e, 0x88)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3bb6, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3bb9, 6); if(jsd(0x1019_3c4e, 0x8f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3bbf, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3bc1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3bc3, 5); mov(ecx, /* sys */ 0x1019_3c6d);        /* mov ecx, 0x10193c6d */
            ii(0x1019_3bc8, 2); if(jnsd(0x1019_3c3e, 0x74)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3bca, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3bcd, 2); if(jsd(0x1019_3c4e, 0x7f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3bcf, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3bd1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3bd3, 5); mov(ecx, /* sys */ 0x1019_3c75);        /* mov ecx, 0x10193c75 */
            ii(0x1019_3bd8, 2); if(jnsd(0x1019_3c3e, 0x64)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3bda, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3bdd, 2); if(jsd(0x1019_3c4e, 0x6f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3bdf, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3be1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3be3, 5); mov(ecx, /* sys */ 0x1019_3c7d);        /* mov ecx, 0x10193c7d */
            ii(0x1019_3be8, 2); if(jnsd(0x1019_3c3e, 0x54)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3bea, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3bed, 2); if(jsd(0x1019_3c4e, 0x5f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3bef, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3bf1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3bf3, 5); mov(ecx, /* sys */ 0x1019_3c85);        /* mov ecx, 0x10193c85 */
            ii(0x1019_3bf8, 2); if(jnsd(0x1019_3c3e, 0x44)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3bfa, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3bfd, 2); if(jsd(0x1019_3c4e, 0x4f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3bff, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3c01, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3c03, 5); mov(ecx, /* sys */ 0x1019_3c8d);        /* mov ecx, 0x10193c8d */
            ii(0x1019_3c08, 2); if(jnsd(0x1019_3c3e, 0x34)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3c0a, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3c0d, 2); if(jsd(0x1019_3c4e, 0x3f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3c0f, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3c11, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3c13, 5); mov(ecx, /* sys */ 0x1019_3c95);        /* mov ecx, 0x10193c95 */
            ii(0x1019_3c18, 2); if(jnsd(0x1019_3c3e, 0x24)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3c1a, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3c1d, 2); if(jsd(0x1019_3c4e, 0x2f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3c1f, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3c21, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3c23, 5); mov(ecx, /* sys */ 0x1019_3c9d);        /* mov ecx, 0x10193c9d */
            ii(0x1019_3c28, 2); if(jnsd(0x1019_3c3e, 0x14)) goto l_0x1019_3c3e; /* jns 0x10193c3e */
            ii(0x1019_3c2a, 3); cmp(memd_a32[ss, ebp - 0x2c], edi);     /* cmp [ebp-0x2c], edi */
            ii(0x1019_3c2d, 2); if(jsd(0x1019_3c4e, 0x1f)) goto l_0x1019_3c4e; /* js 0x10193c4e */
            ii(0x1019_3c2f, 6); add(edi, memd_a32[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_3c35, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_3c38, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_3c3a, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1019_3c3c, 2); jmpd(0x1019_3c9f, 0x61); goto l_0x1019_3c9f; /* jmp 0x10193c9f */
        l_0x1019_3c3e:
            ii(0x1019_3c3e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3c3f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3c41, 3); add(ebx, memd_a32[ss, ebp - 0x2c]);     /* add ebx, [ebp-0x2c] */
            ii(0x1019_3c44, 3); add(edx, memd_a32[ss, ebp - 0x2c]);     /* add edx, [ebp-0x2c] */
            ii(0x1019_3c47, 6); add(edi, memd_a32[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_3c4d, 1); retd(); return;                         /* ret */
        l_0x1019_3c4e:
            ii(0x1019_3c4e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3c4f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3c51, 2); sub(esi, edi);                          /* sub esi, edi */
            ii(0x1019_3c53, 3); sar(edi, 0x2);                          /* sar edi, 0x2 */
            ii(0x1019_3c56, 2); add(ecx, edi);                          /* add ecx, edi */
            ii(0x1019_3c58, 6); mov(edi, memd_a32[ds, Definitions.video_win_start]); /* mov edi, [0x10209ca8] */
            ii(0x1019_3c5e, 3); add(ebx, memd_a32[ss, ebp - 0x2c]);     /* add ebx, [ebp-0x2c] */
            ii(0x1019_3c61, 3); add(edx, memd_a32[ss, ebp - 0x2c]);     /* add edx, [ebp-0x2c] */
            ii(0x1019_3c64, 1); retd(); return;                         /* ret */
        //  ii(0x1019_3c65, 58); Недостижимый (и не декодированный) код.
        l_0x1019_3c9f:
            ii(0x1019_3c9f, 3); sub(esi, memd_a32[ss, ebp - 0x10]);     /* sub esi, [ebp-0x10] */
            ii(0x1019_3ca2, 3); sub(edi, memd_a32[ss, ebp - 0x14]);     /* sub edi, [ebp-0x14] */
            ii(0x1019_3ca5, 1); popd(edx);                              /* pop edx */
            ii(0x1019_3ca6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_3ca7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_3ca8, 1); retd(); return;                         /* ret */
        }
    }
}
