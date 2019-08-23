using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_213f-eb15149")]
        public void Method_1007_213f()
        {
            ii(0x1007_213f, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_2144, 5); call(Definitions.sys_check_available_stack_size, 0xf_3c09); /* call 0x10165d52 */
            ii(0x1007_2149, 1); push(ebx);                              /* push ebx */
            ii(0x1007_214a, 1); push(ecx);                              /* push ecx */
            ii(0x1007_214b, 1); push(esi);                              /* push esi */
            ii(0x1007_214c, 1); push(edi);                              /* push edi */
            ii(0x1007_214d, 1); push(ebp);                              /* push ebp */
            ii(0x1007_214e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2150, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_2156, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_2159, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_215c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_215f, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1007_2162, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2165, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x1007_2168, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_216b, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1007_216f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2172, 4); add(memw[ds, eax + 0x2], dx);           /* add [eax+0x2], dx */
            ii(0x1007_2176, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2179, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x1007_217d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2180, 4); add(memw[ds, eax + 0x4], dx);           /* add [eax+0x4], dx */
            ii(0x1007_2184, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2187, 4); mov(dx, memw[ds, eax + 0x6]);           /* mov dx, [eax+0x6] */
            ii(0x1007_218b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_218e, 4); add(memw[ds, eax + 0x6], dx);           /* add [eax+0x6], dx */
            ii(0x1007_2192, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2195, 4); mov(dx, memw[ds, eax + 0x8]);           /* mov dx, [eax+0x8] */
            ii(0x1007_2199, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_219c, 4); add(memw[ds, eax + 0x8], dx);           /* add [eax+0x8], dx */
            ii(0x1007_21a0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_21a3, 4); mov(dx, memw[ds, eax + 0xa]);           /* mov dx, [eax+0xa] */
            ii(0x1007_21a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_21aa, 4); add(memw[ds, eax + 0xa], dx);           /* add [eax+0xa], dx */
            ii(0x1007_21ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_21b0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_21b1, 1); pop(edi);                               /* pop edi */
            ii(0x1007_21b2, 1); pop(esi);                               /* pop esi */
            ii(0x1007_21b3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_21b4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_21b5, 1); ret();                                  /* ret */
        }
    }
}
