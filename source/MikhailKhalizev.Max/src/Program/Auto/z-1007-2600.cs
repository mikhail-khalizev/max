using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2600-9db19fca")]
        public void Method_1007_2600()
        {
            ii(0x1007_2600, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_2605, 5); call(Definitions.sys_check_available_stack_size, 0xf_3748); /* call 0x10165d52 */
            ii(0x1007_260a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_260b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_260c, 1); push(esi);                              /* push esi */
            ii(0x1007_260d, 1); push(edi);                              /* push edi */
            ii(0x1007_260e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_260f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2611, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_2617, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_261a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_261d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2620, 5); call(0x1007_6204, 0x3bdf);              /* call 0x10076204 */
            ii(0x1007_2625, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x1007_2628, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_262a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_262c, 5); call(0x1007_6954, 0x4323);              /* call 0x10076954 */
            ii(0x1007_2631, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_2634, 5); call(0x1007_6884, 0x424b);              /* call 0x10076884 */
            ii(0x1007_2639, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_263b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_263e, 5); call(0x1015_03d0, 0xd_dd8d);            /* call 0x101503d0 */
            ii(0x1007_2643, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_2647, 4); add(memw[ds, edx + 8], ax);             /* add [edx+0x8], ax */
            ii(0x1007_264b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_264e, 5); call(0x1007_6884, 0x4231);              /* call 0x10076884 */
            ii(0x1007_2653, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2655, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2658, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_265b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_265e, 5); call(0x1007_1ec5, -0x79e);              /* call 0x10071ec5 */
            ii(0x1007_2663, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_2667, 4); add(memw[ds, edx + 0xa], ax);           /* add [edx+0xa], ax */
            ii(0x1007_266b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_266e, 5); call(0x1007_6884, 0x4211);              /* call 0x10076884 */
            ii(0x1007_2673, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2675, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2678, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_267b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_267e, 5); call(0x1007_1f2e, -0x755);              /* call 0x10071f2e */
            ii(0x1007_2683, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_2687, 4); add(memw[ds, edx + 0xe], ax);           /* add [edx+0xe], ax */
            ii(0x1007_268b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_268e, 5); call(0x1007_6884, 0x41f1);              /* call 0x10076884 */
            ii(0x1007_2693, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2695, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2698, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_269b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_269e, 5); call(0x1007_1ff5, -0x6ae);              /* call 0x10071ff5 */
            ii(0x1007_26a3, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_26a7, 4); add(memw[ds, edx + 0x10], ax);          /* add [edx+0x10], ax */
            ii(0x1007_26ab, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_26ae, 5); call(0x1007_6884, 0x41d1);              /* call 0x10076884 */
            ii(0x1007_26b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_26b5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_26b8, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_26bb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_26be, 5); call(0x1007_2073, -0x650);              /* call 0x10072073 */
            ii(0x1007_26c3, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_26c7, 4); add(memw[ds, edx + 0xc], ax);           /* add [edx+0xc], ax */
            ii(0x1007_26cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_26cd, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_26d0, 5); call(0x1007_5eac, 0x37d7);              /* call 0x10075eac */
            ii(0x1007_26d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_26d7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_26d8, 1); pop(edi);                               /* pop edi */
            ii(0x1007_26d9, 1); pop(esi);                               /* pop esi */
            ii(0x1007_26da, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_26db, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_26dc, 1); ret();                                  /* ret */
        }
    }
}
