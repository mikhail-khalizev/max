using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("912daf7f-6ff4-42bd-b435-1bc5828ba9a6")]
        public void /* sys */ Method_1018_5edc()
        {
            ii(0x1018_5edc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_5edd, 1); pushd(edx);                             /* push edx */
            ii(0x1018_5ede, 6); mov(edx, memd_a32[ds, 0x101b_e850]);    /* mov edx, [0x101be850] */
            ii(0x1018_5ee4, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_5ee6, 2); if(jnzd(0x1018_5f0a, 0x22)) goto l_0x1018_5f0a; /* jnz 0x10185f0a */
        l_0x1018_5ee8:
            ii(0x1018_5ee8, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1018_5eed, 5); calld(Definitions.sys_malloc_internal, -0x3c02); /* call 0x101822f0 */
            ii(0x1018_5ef2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_5ef4, 2); if(jzd(0x1018_5f0a, 0x14)) goto l_0x1018_5f0a; /* jz 0x10185f0a */
            ii(0x1018_5ef6, 6); mov(ebx, memd_a32[ds, 0x101b_e850]);    /* mov ebx, [0x101be850] */
            ii(0x1018_5efc, 1); inc(edx);                               /* inc edx */
            ii(0x1018_5efd, 5); mov(memd_a32[ds, 0x101b_e850], eax);    /* mov [0x101be850], eax */
            ii(0x1018_5f02, 3); mov(memd_a32[ds, eax + 0x10], ebx);     /* mov [eax+0x10], ebx */
            ii(0x1018_5f05, 3); cmp(edx, 0xa);                          /* cmp edx, 0xa */
            ii(0x1018_5f08, 2); if(jld(0x1018_5ee8, -0x22)) goto l_0x1018_5ee8; /* jl 0x10185ee8 */
        l_0x1018_5f0a:
            ii(0x1018_5f0a, 6); mov(ebx, memd_a32[ds, 0x101b_e850]);    /* mov ebx, [0x101be850] */
            ii(0x1018_5f10, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_5f12, 2); if(jnzd(0x1018_5f19, 0x5)) goto l_0x1018_5f19; /* jnz 0x10185f19 */
            ii(0x1018_5f14, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_5f16, 1); popd(edx);                              /* pop edx */
            ii(0x1018_5f17, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_5f18, 1); retd(); return;                         /* ret */
        l_0x1018_5f19:
            ii(0x1018_5f19, 3); mov(edx, memd_a32[ds, ebx + 0x10]);     /* mov edx, [ebx+0x10] */
            ii(0x1018_5f1c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_5f1e, 6); mov(memd_a32[ds, 0x101b_e850], edx);    /* mov [0x101be850], edx */
            ii(0x1018_5f24, 1); popd(edx);                              /* pop edx */
            ii(0x1018_5f25, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_5f26, 1); retd(); return;                         /* ret */
        }
    }
}
