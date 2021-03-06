using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2747-9bf5c9b9")]
        public void /* sys */ sys_ftell()
        {
            ii(0x1017_2747, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_2748, 1);  push(edx);                            /* push edx */
            ii(0x1017_2749, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_274b, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1017_274e, 5);  call(/* sys */ 0x1018_d71d, 0x1_afca);/* call 0x1018d71d */
            ii(0x1017_2753, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_2755, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_2758, 2);  if(jz(0x1017_2784, 0x2a)) goto l_0x1017_2784;/* jz 0x10172784 */
            ii(0x1017_275a, 4);  test(memb[ds, edx + 12], 0x80);       /* test byte [edx+0xc], 0x80 */
            ii(0x1017_275e, 2);  if(jz(0x1017_276d, 0xd)) goto l_0x1017_276d;/* jz 0x1017276d */
            ii(0x1017_2760, 4);  test(memb[ds, edx + 13], 0x10);       /* test byte [edx+0xd], 0x10 */
            ii(0x1017_2764, 2);  if(jz(0x1017_276d, 7)) goto l_0x1017_276d;/* jz 0x1017276d */
            ii(0x1017_2766, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_2768, 5);  call(/* sys */ 0x1018_7160, 0x1_49f3);/* call 0x10187160 */
        l_0x1017_276d:
            ii(0x1017_276d, 4);  cmp(memd[ds, edx + 4], 0);            /* cmp dword [edx+0x4], 0x0 */
            ii(0x1017_2771, 2);  if(jz(0x1017_2784, 0x11)) goto l_0x1017_2784;/* jz 0x10172784 */
            ii(0x1017_2773, 4);  test(memb[ds, edx + 13], 0x10);       /* test byte [edx+0xd], 0x10 */
            ii(0x1017_2777, 2);  if(jz(0x1017_2781, 8)) goto l_0x1017_2781;/* jz 0x10172781 */
            ii(0x1017_2779, 3);  add(ebx, memd[ds, edx + 4]);          /* add ebx, [edx+0x4] */
            ii(0x1017_277c, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_277e, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_277f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_2780, 1);  ret(); return;                        /* ret */
        l_0x1017_2781:
            ii(0x1017_2781, 3);  sub(ebx, memd[ds, edx + 4]);          /* sub ebx, [edx+0x4] */
        l_0x1017_2784:
            ii(0x1017_2784, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_2786, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_2787, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_2788, 1);  ret();                                /* ret */
        }
    }
}
