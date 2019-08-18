using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5b35-8c7465cc")]
        public void /* sys */ Method_1019_5b35()
        {
            ii(0x1019_5b35, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5b36, 1); pushd(edi);                             /* push edi */
            ii(0x1019_5b37, 1); pushd(ds);                              /* push ds */
            ii(0x1019_5b38, 1); pushd(es);                              /* push es */
            ii(0x1019_5b39, 1); pushd(eax);                             /* push eax */
            ii(0x1019_5b3a, 3); mov(es, dx);                            /* mov es, dx */
            ii(0x1019_5b3d, 3); mov(ds, cx);                            /* mov ds, cx */
            ii(0x1019_5b40, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1019_5b42, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1019_5b44:
            ii(0x1019_5b44, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1019_5b46, 3); mov(memb_a32[es, edi], al);             /* mov [es:edi], al */
            ii(0x1019_5b49, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1019_5b4b, 2); if(jzd(0x1019_5b5e, 0x11)) goto l_0x1019_5b5e; /* jz 0x10195b5e */
            ii(0x1019_5b4d, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1019_5b50, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1019_5b53, 4); mov(memb_a32[es, edi + 0x1], al);       /* mov [es:edi+0x1], al */
            ii(0x1019_5b57, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1019_5b5a, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1019_5b5c, 2); if(jnzd(0x1019_5b44, -0x1a)) goto l_0x1019_5b44; /* jnz 0x10195b44 */
        l_0x1019_5b5e:
            ii(0x1019_5b5e, 1); popd(eax);                              /* pop eax */
            ii(0x1019_5b5f, 1); popd(es);                               /* pop es */
            ii(0x1019_5b60, 1); popd(ds);                               /* pop ds */
            ii(0x1019_5b61, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5b62, 1); popd(esi);                              /* pop esi */
            ii(0x1019_5b63, 1); retd(); return;                         /* ret */
        }
    }
}
