using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f4b4386d-8612-4cc0-a984-4c8479069e93")]
        public void /* sys */ Method_1016_b8d0()
        {
            ii(0x1016_b8d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b8d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b8d2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b8d3, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_b8d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b8da, 5); mov(eax, memd_a32[ds, 0x1020_892c]);    /* mov eax, [0x1020892c] */
            ii(0x1016_b8df, 6); mov(memd_a32[ds, 0x101c_fbe8], edx);    /* mov [0x101cfbe8], edx */
            ii(0x1016_b8e5, 6); mov(memd_a32[ds, 0x101c_fbd8], edx);    /* mov [0x101cfbd8], edx */
            ii(0x1016_b8eb, 6); mov(memd_a32[ds, 0x101c_fb90], ecx);    /* mov [0x101cfb90], ecx */
            ii(0x1016_b8f1, 5); mov(memd_a32[ds, 0x101c_fc00], eax);    /* mov [0x101cfc00], eax */
            ii(0x1016_b8f6, 5); calld(/* sys */ 0x1016_b9ac, 0xb1);     /* call 0x1016b9ac */
            ii(0x1016_b8fb, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b8fc, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b8fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_b8ff, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b900, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_b902, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_b904, 5); calld(/* sys */ 0x1016_ba3c, 0x133);    /* call 0x1016ba3c */
            ii(0x1016_b909, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b90c, 2); if(jzd(0x1016_b967, 0x59)) goto l_0x1016_b967; /* jz 0x1016b967 */
            ii(0x1016_b90e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b910, 7); mov(memw_a32[ds, 0x101c_fbb4], dx);     /* mov [0x101cfbb4], dx */
            ii(0x1016_b917, 5); mov(ebx, 0x101c_fb98);                  /* mov ebx, 0x101cfb98 */
            ii(0x1016_b91c, 5); mov(edx, 0x101c_fbb4);                  /* mov edx, 0x101cfbb4 */
            ii(0x1016_b921, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1016_b926, 5); calld(/* sys */ 0x1016_c606, 0xcdb);    /* call 0x1016c606 */
            ii(0x1016_b92b, 8); cmp(memw_a32[ds, 0x101c_fb98], 0);      /* cmp word [0x101cfb98], 0x0 */
            ii(0x1016_b933, 2); if(jzd(0x1016_b967, 0x32)) goto l_0x1016_b967; /* jz 0x1016b967 */
            ii(0x1016_b935, 6); mov(edx, memd_a32[ds, 0x1020_88e8]);    /* mov edx, [0x102088e8] */
            ii(0x1016_b93b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b93d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_b940, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_b942, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_b944, 6); mov(edx, memd_a32[ds, 0x1020_88ec]);    /* mov edx, [0x102088ec] */
            ii(0x1016_b94a, 5); mov(memd_a32[ds, 0x101c_fbd4], eax);    /* mov [0x101cfbd4], eax */
            ii(0x1016_b94f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b951, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_b954, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_b956, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_b958, 10); mov(memd_a32[ds, 0x101c_fbe8], 0x1);   /* mov dword [0x101cfbe8], 0x1 */
            ii(0x1016_b962, 5); mov(memd_a32[ds, 0x101c_fbd0], eax);    /* mov [0x101cfbd0], eax */
        l_0x1016_b967:
            ii(0x1016_b967, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b968, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b969, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b96a, 1); retd(); return;                         /* ret */
        }
    }
}
