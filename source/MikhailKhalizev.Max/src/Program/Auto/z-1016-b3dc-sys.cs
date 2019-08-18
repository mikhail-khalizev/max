using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4ce22479-60c3-40bc-a28c-82d1a2c33068")]
        public void /* sys */ Method_1016_b3dc()
        {
            ii(0x1016_b3dc, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b3dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b3df, 5); mov(eax, memd_a32[ds, 0x101c_fb54]);    /* mov eax, [0x101cfb54] */
            ii(0x1016_b3e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b3e6, 2); if(jzd(0x1016_b404, 0x1c)) goto l_0x1016_b404; /* jz 0x1016b404 */
        l_0x1016_b3e8:
            ii(0x1016_b3e8, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x1016_b3eb, 2); if(jnzd(0x1016_b3fd, 0x10)) goto l_0x1016_b3fd; /* jnz 0x1016b3fd */
            ii(0x1016_b3ed, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1016_b3ef, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1016_b3f2, 2); if(jzd(0x1016_b429, 0x35)) goto l_0x1016_b429; /* jz 0x1016b429 */
            ii(0x1016_b3f4, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1016_b3f6, 3); and(dh, 0xfe);                          /* and dh, 0xfe */
            ii(0x1016_b3f9, 2); mov(memb_a32[ds, eax], dh);             /* mov [eax], dh */
            ii(0x1016_b3fb, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b3fc, 1); retd(); return;                         /* ret */
        l_0x1016_b3fd:
            ii(0x1016_b3fd, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1016_b400, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b402, 2); if(jnzd(0x1016_b3e8, -0x1c)) goto l_0x1016_b3e8; /* jnz 0x1016b3e8 */
        l_0x1016_b404:
            ii(0x1016_b404, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1016_b409, 5); calld(Definitions.sys_malloc_internal, 0x1_6ee2); /* call 0x101822f0 */
            ii(0x1016_b40e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b410, 2); if(jzd(0x1016_b429, 0x17)) goto l_0x1016_b429; /* jz 0x1016b429 */
            ii(0x1016_b412, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1016_b418, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1016_b41b, 6); mov(edx, memd_a32[ds, 0x101c_fb54]);    /* mov edx, [0x101cfb54] */
            ii(0x1016_b421, 5); mov(memd_a32[ds, 0x101c_fb54], eax);    /* mov [0x101cfb54], eax */
            ii(0x1016_b426, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
        l_0x1016_b429:
            ii(0x1016_b429, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b42a, 1); retd(); return;                         /* ret */
        }
    }
}
