using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_394d-42c01709")]
        public void /* sys */ Method_1019_394d()
        {
            ii(0x1019_394d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_394e, 3);  add(esi, memd[ss, ebp - 24]);         /* add esi, [ebp-0x18] */
            ii(0x1019_3951, 3);  add(edi, memd[ss, ebp - 28]);         /* add edi, [ebp-0x1c] */
            ii(0x1019_3954, 3);  add(edi, memd[ss, ebp - 32]);         /* add edi, [ebp-0x20] */
            ii(0x1019_3957, 2);  if(loop_func(0x1019_393a, -0x1f)) return;/* loop 0x1019393a */
            ii(0x1019_3959, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_395a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_395b, 6);  add(esi, memd[ds, 0x1020_9cd0]);      /* add esi, [0x10209cd0] */
            ii(0x1019_3961, 3);  inc(memd[ss, ebp + 36]);              /* inc dword [ebp+0x24] */
            ii(0x1019_3964, 2);  dec(cl);                              /* dec cl */
            ii(0x1019_3966, 2);  if(jnz_func(0x1019_38f6, -0x72)) return;/* jnz 0x101938f6 */
            ii(0x1019_3968, 5);  if(jmp_func(0x1019_3ca9, 0x33c)) return;/* jmp 0x10193ca9 */
        }
    }
}
