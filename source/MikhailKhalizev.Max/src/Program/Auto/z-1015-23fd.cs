using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_23fd-13b20427")]
        public void Method_1015_23fd()
        {
            ii(0x1015_23fd, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_2402, 5); call(Definitions.sys_check_available_stack_size, 0x1_394b); /* call 0x10165d52 */
            ii(0x1015_2407, 1); push(ecx);                              /* push ecx */
            ii(0x1015_2408, 1); push(esi);                              /* push esi */
            ii(0x1015_2409, 1); push(edi);                              /* push edi */
            ii(0x1015_240a, 1); push(ebp);                              /* push ebp */
            ii(0x1015_240b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_240d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_2413, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_2416, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1015_2419, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1015_241c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_241f, 5); call(0x1015_24a1, 0x7d);                /* call 0x101524a1 */
            ii(0x1015_2424, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_2427, 7); mov(memb[ds, eax + 0x9e], 1);           /* mov byte [eax+0x9e], 0x1 */
            ii(0x1015_242e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_2431, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_2434, 7); mov(memw[ds, edx + 0x9f], ax);          /* mov [edx+0x9f], ax */
            ii(0x1015_243b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_243e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_2441, 7); mov(memw[ds, edx + 0xa1], ax);          /* mov [edx+0xa1], ax */
            ii(0x1015_2448, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_244b, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_244f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_2452, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_2455, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_2459, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_245c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_245f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_2462, 4); mov(memw[ds, edx + 0x1a], ax);          /* mov [edx+0x1a], ax */
            ii(0x1015_2466, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_2469, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_246c, 4); mov(memw[ds, edx + 0x1c], ax);          /* mov [edx+0x1c], ax */
            ii(0x1015_2470, 5); call(0x100d_53f0, -0x7_d085);           /* call 0x100d53f0 */
            ii(0x1015_2475, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_2477, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_2479, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_247c, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_2481, 5); call(0x1010_346f, -0x4_f017);           /* call 0x1010346f */
            ii(0x1015_2486, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_2489, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_248c, 4); mov(memw[ds, edx + 0x1a], ax);          /* mov [edx+0x1a], ax */
            ii(0x1015_2490, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_2493, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_2496, 4); mov(memw[ds, edx + 0x1c], ax);          /* mov [edx+0x1c], ax */
            ii(0x1015_249a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_249c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_249d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_249e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_249f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_24a0, 1); ret();                                  /* ret */
        }
    }
}
