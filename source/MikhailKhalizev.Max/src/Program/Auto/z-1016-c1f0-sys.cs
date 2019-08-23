using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c1f0-8eaa7cf8")]
        public void /* sys */ Method_1016_c1f0()
        {
            ii(0x1016_c1f0, 1); pushd(esi);                             /* push esi */
            ii(0x1016_c1f1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_c1f2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_c1f4, 7); cmp(memd_a32[ds, 0x101c_fbe8], 0);      /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_c1fb, 2); if(jzd(0x1016_c256, 0x59)) goto l_0x1016_c256; /* jz 0x1016c256 */
            ii(0x1016_c1fd, 5); mov(eax, memd_a32[ds, 0x101c_fbd4]);    /* mov eax, [0x101cfbd4] */
            ii(0x1016_c202, 6); mov(ebp, memd_a32[ds, 0x101c_fbfc]);    /* mov ebp, [0x101cfbfc] */
            ii(0x1016_c208, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c20a, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_c20c, 3); setge(al);                              /* setge al */
            ii(0x1016_c20f, 3); movzx(esi, al);                         /* movzx esi, al */
            ii(0x1016_c212, 5); mov(eax, memd_a32[ds, 0x101c_fbd4]);    /* mov eax, [0x101cfbd4] */
            ii(0x1016_c217, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c219, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_c21b, 3); setle(al);                              /* setle al */
            ii(0x1016_c21e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c223, 6); mov(ebp, memd_a32[ds, 0x101c_fbf8]);    /* mov ebp, [0x101cfbf8] */
            ii(0x1016_c229, 2); and(esi, eax);                          /* and esi, eax */
            ii(0x1016_c22b, 5); mov(eax, memd_a32[ds, 0x101c_fbd0]);    /* mov eax, [0x101cfbd0] */
            ii(0x1016_c230, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c232, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_c234, 3); setge(al);                              /* setge al */
            ii(0x1016_c237, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c23c, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_c23e, 2); and(edx, eax);                          /* and edx, eax */
            ii(0x1016_c240, 5); mov(eax, memd_a32[ds, 0x101c_fbd0]);    /* mov eax, [0x101cfbd0] */
            ii(0x1016_c245, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c247, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_c249, 3); setle(al);                              /* setle al */
            ii(0x1016_c24c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c251, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1016_c253, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c254, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c255, 1); retd(); return;                         /* ret */
        l_0x1016_c256:
            ii(0x1016_c256, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_c258, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c259, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c25a, 1); retd();                                 /* ret */
        }
    }
}
