using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc1f06f3-c877-4a7b-b27c-76db8c5bee9b")]
        public void /* sys */ Method_1016_c184()
        {
            ii(0x1016_c184, 1); pushd(esi);                             /* push esi */
            ii(0x1016_c185, 1); pushd(edi);                             /* push edi */
            ii(0x1016_c186, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_c187, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_c189, 7); cmp(memd_a32[ds, 0x101c_fbe8], 0);      /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_c190, 2); if(jzd(0x1016_c1e8, 0x56)) goto l_0x1016_c1e8; /* jz 0x1016c1e8 */
            ii(0x1016_c192, 5); mov(eax, memd_a32[ds, 0x101c_fbd4]);    /* mov eax, [0x101cfbd4] */
            ii(0x1016_c197, 6); add(eax, memd_a32[ds, 0x101c_fbf0]);    /* add eax, [0x101cfbf0] */
            ii(0x1016_c19d, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_c19f, 3); setg(al);                               /* setg al */
            ii(0x1016_c1a2, 6); mov(edi, memd_a32[ds, 0x101c_fbd4]);    /* mov edi, [0x101cfbd4] */
            ii(0x1016_c1a8, 3); movzx(esi, al);                         /* movzx esi, al */
            ii(0x1016_c1ab, 2); cmp(ebx, edi);                          /* cmp ebx, edi */
            ii(0x1016_c1ad, 3); setge(al);                              /* setge al */
            ii(0x1016_c1b0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c1b5, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1016_c1b7, 6); mov(ebp, memd_a32[ds, 0x101c_fb94]);    /* mov ebp, [0x101cfb94] */
            ii(0x1016_c1bd, 2); and(ebx, eax);                          /* and ebx, eax */
            ii(0x1016_c1bf, 5); mov(eax, memd_a32[ds, 0x101c_fbd0]);    /* mov eax, [0x101cfbd0] */
            ii(0x1016_c1c4, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c1c6, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_c1c8, 3); setg(al);                               /* setg al */
            ii(0x1016_c1cb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c1d0, 6); mov(edx, memd_a32[ds, 0x101c_fbd0]);    /* mov edx, [0x101cfbd0] */
            ii(0x1016_c1d6, 2); and(ebx, eax);                          /* and ebx, eax */
            ii(0x1016_c1d8, 2); cmp(ecx, edx);                          /* cmp ecx, edx */
            ii(0x1016_c1da, 3); setge(al);                              /* setge al */
            ii(0x1016_c1dd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c1e2, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x1016_c1e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c1e5, 1); popd(edi);                              /* pop edi */
            ii(0x1016_c1e6, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c1e7, 1); retd(); return;                         /* ret */
        l_0x1016_c1e8:
            ii(0x1016_c1e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_c1ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c1eb, 1); popd(edi);                              /* pop edi */
            ii(0x1016_c1ec, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c1ed, 1); retd(); return;                         /* ret */
        }
    }
}
