using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9746834-46e5-4eaa-88c8-83d96d826f1b")]
        public void /* sys */ Method_1019_3ec1()
        {
            ii(0x1019_3ec1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_3ec2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3ec3, 1); pushd(edx);                             /* push edx */
            ii(0x1019_3ec4, 1); pushd(esi);                             /* push esi */
            ii(0x1019_3ec5, 1); pushd(edi);                             /* push edi */
            ii(0x1019_3ec6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3ec8, 3); shl(ecx, 0x2);                          /* shl ecx, 0x2 */
            ii(0x1019_3ecb, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1019_3ece, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1019_3ed0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1019_3ed3, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1019_3ed5, 6); sub(ecx, memd_a32[ds, Definitions.video_win_end]); /* sub ecx, [0x10209cac] */
            ii(0x1019_3edb, 2); neg(ecx);                               /* neg ecx */
            ii(0x1019_3edd, 3); mov(memd_a32[ss, ebp - 0x2c], ecx);     /* mov [ebp-0x2c], ecx */
            ii(0x1019_3ee0, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ee3, 2); if(jnsd(0x1019_3f44, 0x5f)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3ee5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3ee7, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3ee9, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3eeb, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3eed, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ef0, 2); if(jnsd(0x1019_3f44, 0x52)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3ef2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3ef4, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3ef6, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3ef8, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3efa, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3efd, 2); if(jnsd(0x1019_3f44, 0x45)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3eff, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f01, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3f03, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3f05, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3f07, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3f0a, 2); if(jnsd(0x1019_3f44, 0x38)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3f0c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f0e, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3f10, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3f12, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3f14, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3f17, 2); if(jnsd(0x1019_3f44, 0x2b)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3f19, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f1b, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3f1d, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3f1f, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3f21, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3f24, 2); if(jnsd(0x1019_3f44, 0x1e)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3f26, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f28, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3f2a, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3f2c, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3f2e, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3f31, 2); if(jnsd(0x1019_3f44, 0x11)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3f33, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f35, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3f37, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3f39, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3f3b, 3); cmp(edi, memd_a32[ss, ebp - 0x2c]);     /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3f3e, 2); if(jnsd(0x1019_3f44, 0x4)) goto l_0x1019_3f44; /* jns 0x10193f44 */
            ii(0x1019_3f40, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f42, 2); jmpd(0x1019_3f51, 0xd); goto l_0x1019_3f51; /* jmp 0x10193f51 */
        l_0x1019_3f44:
            ii(0x1019_3f44, 6); mov(ecx, memd_a32[ds, Definitions.video_win_end]); /* mov ecx, [0x10209cac] */
            ii(0x1019_3f4a, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1019_3f4c, 2); if(jsd(0x1019_3f53, 0x5)) goto l_0x1019_3f53; /* js 0x10193f53 */
            ii(0x1019_3f4e, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
        l_0x1019_3f51:
            ii(0x1019_3f51, 2); rep_a32(() => movsd_a32());             /* rep movsd */
        l_0x1019_3f53:
            ii(0x1019_3f53, 1); popd(edi);                              /* pop edi */
            ii(0x1019_3f54, 1); popd(esi);                              /* pop esi */
            ii(0x1019_3f55, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3f57, 3); shl(ecx, 0x2);                          /* shl ecx, 0x2 */
            ii(0x1019_3f5a, 2); add(esi, ecx);                          /* add esi, ecx */
            ii(0x1019_3f5c, 2); add(edi, ecx);                          /* add edi, ecx */
            ii(0x1019_3f5e, 1); popd(edx);                              /* pop edx */
            ii(0x1019_3f5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_3f60, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_3f61, 1); retd(); return;                         /* ret */
        }
    }
}
