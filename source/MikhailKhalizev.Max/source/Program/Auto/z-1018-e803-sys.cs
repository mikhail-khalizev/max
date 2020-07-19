using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e803-3e19e2bb")]
        public void /* sys */ Method_1018_e803()
        {
            ii(0x1018_e803, 1);  push(esi);                            /* push esi */
            ii(0x1018_e804, 1);  push(edi);                            /* push edi */
            ii(0x1018_e805, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_e806, 6);  lea(edi, memd[ds, 0x101b_e8d0]);      /* lea edi, [0x101be8d0] */
            ii(0x1018_e80c, 6);  mov(ebx, memd[ds, 0x1020_9cd0]);      /* mov ebx, [0x10209cd0] */
            ii(0x1018_e812, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1018_e817, 5);  mov(ecx, 0x80);                       /* mov ecx, 0x80 */
        l_0x1018_e81c:
            ii(0x1018_e81c, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1018_e81e, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1018_e821, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1018_e823, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1018_e824, 2);  if(jnz(0x1018_e81c, -0xa)) goto l_0x1018_e81c;/* jnz 0x1018e81c */
            ii(0x1018_e826, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1018_e828, 3);  shl(eax, 7);                          /* shl eax, 0x7 */
            ii(0x1018_e82b, 2);  neg(eax);                             /* neg eax */
            ii(0x1018_e82d, 5);  mov(ecx, 0x80);                       /* mov ecx, 0x80 */
        l_0x1018_e832:
            ii(0x1018_e832, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1018_e834, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1018_e837, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1018_e839, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1018_e83a, 2);  if(jnz(0x1018_e832, -0xa)) goto l_0x1018_e832;/* jnz 0x1018e832 */
            ii(0x1018_e83c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_e83d, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_e83e, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_e83f, 1);  ret();                                /* ret */
        }
    }
}
