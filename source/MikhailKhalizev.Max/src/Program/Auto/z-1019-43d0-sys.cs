using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_43d0-9af6e476")]
        public void /* sys */ Method_1019_43d0()
        {
            ii(0x1019_43d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_43d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_43d3, 1); pushd(edx);                             /* push edx */
            ii(0x1019_43d4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_43d6, 3); xor(dx, ax);                            /* xor dx, ax */
            ii(0x1019_43d9, 3); shr(edx, 0xc);                          /* shr edx, 0xc */
            ii(0x1019_43dc, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1019_43e1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1019_43e3, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1019_43e6, 1); popd(edx);                              /* pop edx */
            ii(0x1019_43e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_43e8, 1); retd(); return;                         /* ret */
        }
    }
}
