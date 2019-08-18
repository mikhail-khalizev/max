using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d907d3fd-eb7d-4802-9a54-fd492cdb8391")]
        public void Method_1015_50bc()
        {
            ii(0x1015_50bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_50bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_50be, 1); pushd(edx);                             /* push edx */
            ii(0x1015_50bf, 1); pushd(esi);                             /* push esi */
            ii(0x1015_50c0, 1); pushd(edi);                             /* push edi */
            ii(0x1015_50c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_50c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_50c4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_50ca, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1015_50d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_50d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_50d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_50d7, 1); popd(edi);                              /* pop edi */
            ii(0x1015_50d8, 1); popd(esi);                              /* pop esi */
            ii(0x1015_50d9, 1); popd(edx);                              /* pop edx */
            ii(0x1015_50da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_50db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_50dc, 1); retd(); return;                         /* ret */
        }
    }
}
