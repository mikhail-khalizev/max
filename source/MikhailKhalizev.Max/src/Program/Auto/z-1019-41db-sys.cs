using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("65645412-f604-4241-922f-9d6b19589bf7")]
        public void /* sys */ Method_1019_41db()
        {
            ii(0x1019_41db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_41dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_41de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_41df, 1); pushd(esi);                             /* push esi */
            ii(0x1019_41e0, 1); pushd(edi);                             /* push edi */
            ii(0x1019_41e1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_41e2, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_41e5, 2); @int(0x10);                             /* int 0x10 */
            ii(0x1019_41e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_41e8, 1); popd(edi);                              /* pop edi */
            ii(0x1019_41e9, 1); popd(esi);                              /* pop esi */
            ii(0x1019_41ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_41eb, 1); leaved();                               /* leave */
            ii(0x1019_41ec, 1); retd(); return;                         /* ret */
        }
    }
}
