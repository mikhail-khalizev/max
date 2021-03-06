using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_28a8-97f5c01f")]
        public void /* sys */ Method_1018_28a8()
        {
            ii(0x1018_28a8, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_28a9, 1);  push(edx);                            /* push edx */
            ii(0x1018_28aa, 6);  sub(esp, 0x104);                      /* sub esp, 0x104 */
            ii(0x1018_28b0, 7);  cmp(memd[ds, 0x101b_e840], 0);        /* cmp dword [0x101be840], 0x0 */
            ii(0x1018_28b7, 2);  if(jz(0x1018_28e6, 0x2d)) goto l_0x1018_28e6;/* jz 0x101828e6 */
            ii(0x1018_28b9, 7);  lea(eax, memd[ss, esp + 276]);        /* lea eax, [esp+0x114] */
            ii(0x1018_28c0, 7);  lea(ebx, memd[ss, esp + 256]);        /* lea ebx, [esp+0x100] */
            ii(0x1018_28c7, 7);  mov(edx, memd[ss, esp + 272]);        /* mov edx, [esp+0x110] */
            ii(0x1018_28ce, 7);  mov(memd[ss, esp + 256], eax);        /* mov [esp+0x100], eax */
            ii(0x1018_28d5, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1018_28d7, 5);  call(/* sys */ 0x1018_0f0b, -0x19d1); /* call 0x10180f0b */
            ii(0x1018_28dc, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1018_28de, 6);  call_abs(memd[ds, 0x101b_e840]);      /* call dword [0x101be840] */
            ii(0x1018_28e4, 2);  jmp(0x1018_28eb, 5); goto l_0x1018_28eb;/* jmp 0x101828eb */
        l_0x1018_28e6:
            ii(0x1018_28e6, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1018_28eb:
            ii(0x1018_28eb, 6);  add(esp, 0x104);                      /* add esp, 0x104 */
            ii(0x1018_28f1, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_28f2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_28f3, 1);  ret();                                /* ret */
        }
    }
}
