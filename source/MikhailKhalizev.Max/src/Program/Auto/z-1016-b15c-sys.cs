using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0174e665-a969-4fd9-a93b-42cd43c27c38")]
        public void /* sys */ Method_1016_b15c()
        {
            ii(0x1016_b15c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b15d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b15e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b15f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_b160, 1); pushd(edi);                             /* push edi */
            ii(0x1016_b161, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_b162, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b164, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1016_b169, 5); mov(ecx, 0x119);                        /* mov ecx, 0x119 */
            ii(0x1016_b16e, 5); mov(edi, /* sys */ 0x1016_b4a0);        /* mov edi, 0x1016b4a0 */
            ii(0x1016_b173, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_b175, 5); mov(ebp, /* sys */ 0x1016_b69c);        /* mov ebp, 0x1016b69c */
            ii(0x1016_b17a, 6); mov(memd_a32[ds, 0x101c_fb54], ebx);    /* mov [0x101cfb54], ebx */
            ii(0x1016_b180, 6); mov(memd_a32[ds, 0x101c_fb78], ebx);    /* mov [0x101cfb78], ebx */
            ii(0x1016_b186, 6); mov(memd_a32[ds, 0x101c_fb6c], esi);    /* mov [0x101cfb6c], esi */
            ii(0x1016_b18c, 6); mov(memd_a32[ds, 0x101c_fb4c], esi);    /* mov [0x101cfb4c], esi */
            ii(0x1016_b192, 6); mov(memd_a32[ds, 0x101c_fb50], esi);    /* mov [0x101cfb50], esi */
            ii(0x1016_b198, 5); calld(/* sys */ 0x1017_2ab0, 0x7913);   /* call 0x10172ab0 */
            ii(0x1016_b19d, 5); calld(/* sys */ 0x1016_b8d0, 0x72e);    /* call 0x1016b8d0 */
            ii(0x1016_b1a2, 5); mov(esi, 0x12e);                        /* mov esi, 0x12e */
            ii(0x1016_b1a7, 6); mov(memd_a32[ds, 0x101c_fb7c], ebx);    /* mov [0x101cfb7c], ebx */
            ii(0x1016_b1ad, 6); mov(memd_a32[ds, 0x101c_fb58], ebx);    /* mov [0x101cfb58], ebx */
            ii(0x1016_b1b3, 6); mov(memd_a32[ds, 0x101c_fb64], ecx);    /* mov [0x101cfb64], ecx */
            ii(0x1016_b1b9, 6); mov(memd_a32[ds, 0x101c_fb74], edi);    /* mov [0x101cfb74], edi */
            ii(0x1016_b1bf, 6); mov(memd_a32[ds, 0x101c_fb68], ebp);    /* mov [0x101cfb68], ebp */
            ii(0x1016_b1c5, 6); mov(memd_a32[ds, 0x101c_fb60], edx);    /* mov [0x101cfb60], edx */
            ii(0x1016_b1cb, 6); mov(memd_a32[ds, 0x101c_fb5c], esi);    /* mov [0x101cfb5c], esi */
            ii(0x1016_b1d1, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b1d3, 2); if(jzd(0x1016_b1da, 0x5)) goto l_0x1016_b1da; /* jz 0x1016b1da */
            ii(0x1016_b1d5, 5); calld(/* sys */ 0x1018_70e8, 0x1_bf0e); /* call 0x101870e8 */
        l_0x1016_b1da:
            ii(0x1016_b1da, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_b1db, 1); popd(edi);                              /* pop edi */
            ii(0x1016_b1dc, 1); popd(esi);                              /* pop esi */
            ii(0x1016_b1dd, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b1de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b1df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b1e0, 1); retd(); return;                         /* ret */
        }
    }
}
