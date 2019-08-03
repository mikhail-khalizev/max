using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16c9fdc4-81cc-4e28-b0f5-58dd251140ed")]
        public void /* sys */ Method_1019_46a5()
        {
            ii(0x1019_46a5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_46a6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_46a7, 1); pushd(edx);                             /* push edx */
            ii(0x1019_46a8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_46aa, 6); cmp(eax, memd_a32[ds, 0x101c_09d0]);    /* cmp eax, [0x101c09d0] */
            ii(0x1019_46b0, 2); if(jbd(0x1019_46b8, 0x6)) goto l_0x1019_46b8; /* jb 0x101946b8 */
            ii(0x1019_46b2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_46b4, 1); popd(edx);                              /* pop edx */
            ii(0x1019_46b5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_46b6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_46b7, 1); retd(); return;                         /* ret */
        l_0x1019_46b8:
            ii(0x1019_46b8, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1019_46bb, 2); if(jgd(0x1019_46ee, 0x31)) goto l_0x1019_46ee; /* jg 0x101946ee */
            ii(0x1019_46bd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_46bf, 5); mov(eax, memd_a32[ds, Definitions.ptr_of_fd_table_]); /* mov eax, [0x101c0a24] */
            ii(0x1019_46c4, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1019_46c7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1019_46c9, 3); mov(cl, memb_a32[ds, eax + 0x1]);       /* mov cl, [eax+0x1] */
            ii(0x1019_46cc, 3); test(cl, 0x40);                         /* test cl, 0x40 */
            ii(0x1019_46cf, 2); if(jnzd(0x1019_46ee, 0x1d)) goto l_0x1019_46ee; /* jnz 0x101946ee */
            ii(0x1019_46d1, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1019_46d3, 3); or(ch, 0x40);                           /* or ch, 0x40 */
            ii(0x1019_46d6, 3); mov(memb_a32[ds, eax + 0x1], ch);       /* mov [eax+0x1], ch */
            ii(0x1019_46d9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_46db, 5); calld(/* sys */ 0x1019_467e, -0x62);    /* call 0x1019467e */
            ii(0x1019_46e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_46e2, 2); if(jzd(0x1019_46ee, 0xa)) goto l_0x1019_46ee; /* jz 0x101946ee */
            ii(0x1019_46e4, 5); mov(eax, memd_a32[ds, Definitions.ptr_of_fd_table_]); /* mov eax, [0x101c0a24] */
            ii(0x1019_46e9, 5); or(memb_a32[ds, ebx + eax + 0x1], 0x20); /* or byte [ebx+eax+0x1], 0x20 */
        l_0x1019_46ee:
            ii(0x1019_46ee, 5); mov(eax, memd_a32[ds, Definitions.ptr_of_fd_table_]); /* mov eax, [0x101c0a24] */
            ii(0x1019_46f3, 3); mov(eax, memd_a32[ds, eax + edx * 4]);  /* mov eax, [eax+edx*4] */
            ii(0x1019_46f6, 1); popd(edx);                              /* pop edx */
            ii(0x1019_46f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_46f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_46f9, 1); retd(); return;                         /* ret */
        }
    }
}
