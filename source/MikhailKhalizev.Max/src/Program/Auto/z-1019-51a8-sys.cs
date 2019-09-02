using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_51a8-e4301dd9")]
        public void /* sys */ Method_1019_51a8()
        {
            ii(0x1019_51a8, 1); push(ebp);                              /* push ebp */
            ii(0x1019_51a9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_51ab, 1); push(esi);                              /* push esi */
            ii(0x1019_51ac, 1); push(edi);                              /* push edi */
            ii(0x1019_51ad, 1); push(ebx);                              /* push ebx */
            ii(0x1019_51ae, 1); push(ecx);                              /* push ecx */
            ii(0x1019_51af, 2); pushd(fs);                              /* push fs */
            ii(0x1019_51b1, 2); pushd(gs);                              /* push gs */
            ii(0x1019_51b3, 1); pushd(es);                              /* push es */
            ii(0x1019_51b4, 4); lfs(edi, memd[ss, ebp + 0x10]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_51b8, 5); mov(eax, 4);                            /* mov eax, 0x4 */
            ii(0x1019_51bd, 3); call_far_ind(memd[ss, ebp + 8]);        /* call far dword [ebp+0x8] */
            ii(0x1019_51c0, 6); mov(memd[ds, 0x101c_1ab0], esi);        /* mov [0x101c1ab0], esi */
            ii(0x1019_51c6, 6); mov(memd[ds, 0x101c_1ab8], edi);        /* mov [0x101c1ab8], edi */
            ii(0x1019_51cc, 4); mov(ax, memw[ss, ebp + 0x14]);          /* mov ax, [ebp+0x14] */
            ii(0x1019_51d0, 6); mov(memw[ds, 0x101c_1ab4], ax);         /* mov [0x101c1ab4], ax */
            ii(0x1019_51d6, 6); mov(memw[ds, 0x101c_1abc], ax);         /* mov [0x101c1abc], ax */
            ii(0x1019_51dc, 1); popd(es);                               /* pop es */
            ii(0x1019_51dd, 2); popd(gs);                               /* pop gs */
            ii(0x1019_51df, 2); popd(fs);                               /* pop fs */
            ii(0x1019_51e1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_51e2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_51e3, 1); pop(edi);                               /* pop edi */
            ii(0x1019_51e4, 1); pop(esi);                               /* pop esi */
            ii(0x1019_51e5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_51e6, 1); ret();                                  /* ret */
        }
    }
}
